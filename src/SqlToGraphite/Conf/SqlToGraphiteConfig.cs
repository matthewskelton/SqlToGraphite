﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class SqlToGraphiteConfig {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Clients", typeof(SqlToGraphiteConfigClients), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("hosts", typeof(SqlToGraphiteConfigHosts), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("templates", typeof(SqlToGraphiteConfigTemplates), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SqlToGraphiteConfigClients {
    
    private SqlToGraphiteConfigClientsClient[] clientField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Client", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SqlToGraphiteConfigClientsClient[] Client {
        get {
            return this.clientField;
        }
        set {
            this.clientField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SqlToGraphiteConfigClientsClient {
    
    private string nameField;
    
    private string portField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string port {
        get {
            return this.portField;
        }
        set {
            this.portField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SqlToGraphiteConfigHosts {
    
    private SqlToGraphiteConfigHostsHost[] hostField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("host", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SqlToGraphiteConfigHostsHost[] host {
        get {
            return this.hostField;
        }
        set {
            this.hostField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SqlToGraphiteConfigHostsHost {
    
    private SqlToGraphiteConfigHostsHostRole[] roleField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("role", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SqlToGraphiteConfigHostsHostRole[] role {
        get {
            return this.roleField;
        }
        set {
            this.roleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SqlToGraphiteConfigHostsHostRole {
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SqlToGraphiteConfigTemplates {
    
    private SqlToGraphiteConfigTemplatesWorkItems[] workItemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WorkItems", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SqlToGraphiteConfigTemplatesWorkItems[] WorkItems {
        get {
            return this.workItemsField;
        }
        set {
            this.workItemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SqlToGraphiteConfigTemplatesWorkItems {
    
    private SqlToGraphiteConfigTemplatesWorkItemsTaskSet[] taskSetField;
    
    private string roleField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TaskSet", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SqlToGraphiteConfigTemplatesWorkItemsTaskSet[] TaskSet {
        get {
            return this.taskSetField;
        }
        set {
            this.taskSetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Role {
        get {
            return this.roleField;
        }
        set {
            this.roleField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SqlToGraphiteConfigTemplatesWorkItemsTaskSet {
    
    private SqlToGraphiteConfigTemplatesWorkItemsTaskSetTask[] taskField;
    
    private string frequencyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Task", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SqlToGraphiteConfigTemplatesWorkItemsTaskSetTask[] Task {
        get {
            return this.taskField;
        }
        set {
            this.taskField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string frequency {
        get {
            return this.frequencyField;
        }
        set {
            this.frequencyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SqlToGraphiteConfigTemplatesWorkItemsTaskSetTask {
    
    private string pathField;
    
    private string sqlField;
    
    private string connectionstringField;
    
    private string typeField;
    
    private string nameField;
    
    private string clientField;
    
    private string portField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string path {
        get {
            return this.pathField;
        }
        set {
            this.pathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string sql {
        get {
            return this.sqlField;
        }
        set {
            this.sqlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string connectionstring {
        get {
            return this.connectionstringField;
        }
        set {
            this.connectionstringField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string client {
        get {
            return this.clientField;
        }
        set {
            this.clientField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string port {
        get {
            return this.portField;
        }
        set {
            this.portField = value;
        }
    }
}