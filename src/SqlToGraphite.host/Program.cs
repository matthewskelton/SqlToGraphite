using System;

using SqlToGraphite.Clients;
using SqlToGraphite.Conf;
using Topshelf;
using log4net;

namespace SqlToGraphite.host
{
    public class Program
    {
        private static ILog log;

        public static TaskManager CreateTaskManager(SqlToGraphiteSection configuration)
        {            
            var cacheLength = new TimeSpan(0, configuration.ConfigCacheLengthMinutes, 0);
            var stop = new Stop();
            IDataClientFactory dataClientFactory = new DataClientFactory(log);
            IGraphiteClientFactory graphiteClientFactory = new GraphiteClientFactory(log);
            var configMapper = new ConfigMapper(configuration.Hostname, stop, dataClientFactory, graphiteClientFactory, log);
            var configReader = new ConfigReader(configuration.ConfigUri,configuration.ConfigUsername,configuration.ConfigPassword);
            var cache = new Cache(cacheLength, log);
            var sleeper = new Sleeper();
            var knownGraphiteClients = new KnownGraphiteClients();
            var cr = new ConfigRepository(configReader, knownGraphiteClients, cache, sleeper, log, configuration.MinutesBetweenRetryToGetConfigOnError);
            var configController = new ConfigController(configMapper, log, cr);
            return new TaskManager(log, configController, configuration.ConfigUri, stop, sleeper, configuration.CheckConfigUpdatedEveryMinutes);
        }

        private static SqlToGraphiteSection ReadConfigFromAppConfig()
        {
            return (SqlToGraphiteSection)System.Configuration.ConfigurationManager.GetSection(SqlToGraphiteSection.SectionName);
        }
        public static void Main(string[] args)
        {
            try
            {
                log = LogManager.GetLogger("log");
                log4net.Config.XmlConfigurator.Configure();
                var configuration = ReadConfigFromAppConfig();                                
                RunApplication(CreateTaskManager(configuration));
            }
            catch (Exception ex)
            {
                log.Error(ex);
                Console.WriteLine(ex.Message);
            }
        }

        private static void RunApplication(TaskManager taskManager)
        {
            HostFactory.Run(
                x =>
                {
                    x.Service<Application>(
                        s =>
                        {
                            s.SetServiceName("tc");
                            s.ConstructUsing(name => new Application(taskManager, log));
                            s.WhenStarted(tc => tc.Start());
                            s.WhenStopped(tc => tc.Stop());
                        });
                    x.RunAsLocalSystem();
                    x.SetDescription("Runs sql to inject data into graphite");
                    x.SetDisplayName("SqlToGraphite");
                    x.SetServiceName("SqlToGraphite");
                });
        }
    }
}
