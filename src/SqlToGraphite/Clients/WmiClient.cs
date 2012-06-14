using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;

using log4net;

namespace SqlToGraphite
{
    public class WmiClient : ISqlClient
    {
        private readonly ILog log;

        private readonly TaskParams taskParams;

        public const string RootPath = @"root\CIMV2";

        public string MachineName { get; set; }

        public WmiClient(ILog log, TaskParams taskParams)
        {
            this.log = log;
            this.taskParams = taskParams;
            MachineName = Environment.MachineName;
        }

        public IList<IResult> Get()
        {
            var rtn = new List<IResult>();

            try
            {
                foreach (ManagementObject o in this.GetWmiObject(this.taskParams.Sql, MachineName, RootPath))
                {
                    var value = -1;
                    var dateTime = DateTime.Now;
                    var name = string.Empty;

                    foreach (var col in o.Properties)
                    {
                        if (col.Type == CimType.String)
                        {
                            name = Convert.ToString(col.Value);
                        }

                        if (col.Type == CimType.UInt32)
                        {
                            value = Convert.ToInt32(col.Value);
                        }

                        if (col.Type == CimType.UInt64)
                        {
                            value = Convert.ToInt32(col.Value);
                        }

                        if (col.Type == CimType.DateTime)
                        {
                            dateTime = Convert.ToDateTime(col.Value);
                        }
                    }

                    this.log.Debug(string.Format("Name {0} value {1} datetime {2}", name, value, dateTime));
                    rtn.Add(new Result(value, name, dateTime, this.taskParams.Path));
                }
            }
            catch (ManagementException e)
            {
                this.log.Error(string.Format("Error with {0} {1} {2}", this.taskParams.Type, this.taskParams.Path, this.taskParams.Sql));
                this.log.Error(e.Message);
                this.log.Error(e.StackTrace);
            }

            return rtn;
        }

        private static string GetTheNameOfTheColumn(ManagementBaseObject queryObj)
        {
            var name = string.Empty;
            foreach (var v in queryObj.Properties)
            {
                name = v.Name;
            }

            return name;
        }

        private IEnumerable<ManagementObject> GetWmiObject(string query, string machineName, string rootPath)
        {
            try
            {
                var p = string.Format(@"\\{0}\{1}", machineName, rootPath);
                log.Debug(string.Format("{0} {1}", p, query));
                var searcher = new ManagementObjectSearcher(p, query);
                return searcher.Get().Cast<ManagementObject>().ToList();
            }
            catch (Exception e)
            {
                log.Debug(e);
                throw;
            }
        }

        public static int ConvertToInt(string value)
        {
            var l = Convert.ToInt64(value);
            if (l > Int16.MaxValue)
            {
                l = l / 1024;
            }

            return Convert.ToInt32(l);
        }
    }
}