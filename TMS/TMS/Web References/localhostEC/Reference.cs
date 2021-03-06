﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace TMS.localhostEC {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EmployeeCompetencyWebserviceSoapBinding", Namespace="http://webservice_layer")]
    public partial class EmployeeCompetencyWebserviceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback createEmployeeCompetencyOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteEmployeeCompetencyOperationCompleted;
        
        private System.Threading.SendOrPostCallback findEmployeeCompetencyOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateEmployeeCompetencyOperationCompleted;
        
        private System.Threading.SendOrPostCallback findAllEmployeeCompetenciesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllEmployeeCompetenciesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public EmployeeCompetencyWebserviceService() {
            this.Url = global::TMS.Properties.Settings.Default.TMS_localhostEC_EmployeeCompetencyWebserviceService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event createEmployeeCompetencyCompletedEventHandler createEmployeeCompetencyCompleted;
        
        /// <remarks/>
        public event deleteEmployeeCompetencyCompletedEventHandler deleteEmployeeCompetencyCompleted;
        
        /// <remarks/>
        public event findEmployeeCompetencyCompletedEventHandler findEmployeeCompetencyCompleted;
        
        /// <remarks/>
        public event updateEmployeeCompetencyCompletedEventHandler updateEmployeeCompetencyCompleted;
        
        /// <remarks/>
        public event findAllEmployeeCompetenciesCompletedEventHandler findAllEmployeeCompetenciesCompleted;
        
        /// <remarks/>
        public event getAllEmployeeCompetenciesCompletedEventHandler getAllEmployeeCompetenciesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("createEmployeeCompetencyReturn")]
        public string createEmployeeCompetency(EmployeeCompetency ec) {
            object[] results = this.Invoke("createEmployeeCompetency", new object[] {
                        ec});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void createEmployeeCompetencyAsync(EmployeeCompetency ec) {
            this.createEmployeeCompetencyAsync(ec, null);
        }
        
        /// <remarks/>
        public void createEmployeeCompetencyAsync(EmployeeCompetency ec, object userState) {
            if ((this.createEmployeeCompetencyOperationCompleted == null)) {
                this.createEmployeeCompetencyOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateEmployeeCompetencyOperationCompleted);
            }
            this.InvokeAsync("createEmployeeCompetency", new object[] {
                        ec}, this.createEmployeeCompetencyOperationCompleted, userState);
        }
        
        private void OncreateEmployeeCompetencyOperationCompleted(object arg) {
            if ((this.createEmployeeCompetencyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createEmployeeCompetencyCompleted(this, new createEmployeeCompetencyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("deleteEmployeeCompetencyReturn")]
        public string deleteEmployeeCompetency(EmployeeCompetency ec) {
            object[] results = this.Invoke("deleteEmployeeCompetency", new object[] {
                        ec});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void deleteEmployeeCompetencyAsync(EmployeeCompetency ec) {
            this.deleteEmployeeCompetencyAsync(ec, null);
        }
        
        /// <remarks/>
        public void deleteEmployeeCompetencyAsync(EmployeeCompetency ec, object userState) {
            if ((this.deleteEmployeeCompetencyOperationCompleted == null)) {
                this.deleteEmployeeCompetencyOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteEmployeeCompetencyOperationCompleted);
            }
            this.InvokeAsync("deleteEmployeeCompetency", new object[] {
                        ec}, this.deleteEmployeeCompetencyOperationCompleted, userState);
        }
        
        private void OndeleteEmployeeCompetencyOperationCompleted(object arg) {
            if ((this.deleteEmployeeCompetencyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteEmployeeCompetencyCompleted(this, new deleteEmployeeCompetencyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findEmployeeCompetencyReturn")]
        public EmployeeCompetency findEmployeeCompetency(int Id) {
            object[] results = this.Invoke("findEmployeeCompetency", new object[] {
                        Id});
            return ((EmployeeCompetency)(results[0]));
        }
        
        /// <remarks/>
        public void findEmployeeCompetencyAsync(int Id) {
            this.findEmployeeCompetencyAsync(Id, null);
        }
        
        /// <remarks/>
        public void findEmployeeCompetencyAsync(int Id, object userState) {
            if ((this.findEmployeeCompetencyOperationCompleted == null)) {
                this.findEmployeeCompetencyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindEmployeeCompetencyOperationCompleted);
            }
            this.InvokeAsync("findEmployeeCompetency", new object[] {
                        Id}, this.findEmployeeCompetencyOperationCompleted, userState);
        }
        
        private void OnfindEmployeeCompetencyOperationCompleted(object arg) {
            if ((this.findEmployeeCompetencyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findEmployeeCompetencyCompleted(this, new findEmployeeCompetencyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("updateEmployeeCompetencyReturn")]
        public string updateEmployeeCompetency(EmployeeCompetency ec) {
            object[] results = this.Invoke("updateEmployeeCompetency", new object[] {
                        ec});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void updateEmployeeCompetencyAsync(EmployeeCompetency ec) {
            this.updateEmployeeCompetencyAsync(ec, null);
        }
        
        /// <remarks/>
        public void updateEmployeeCompetencyAsync(EmployeeCompetency ec, object userState) {
            if ((this.updateEmployeeCompetencyOperationCompleted == null)) {
                this.updateEmployeeCompetencyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateEmployeeCompetencyOperationCompleted);
            }
            this.InvokeAsync("updateEmployeeCompetency", new object[] {
                        ec}, this.updateEmployeeCompetencyOperationCompleted, userState);
        }
        
        private void OnupdateEmployeeCompetencyOperationCompleted(object arg) {
            if ((this.updateEmployeeCompetencyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateEmployeeCompetencyCompleted(this, new updateEmployeeCompetencyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("findAllEmployeeCompetenciesReturn")]
        public EmployeeCompetency[] findAllEmployeeCompetencies(int Id) {
            object[] results = this.Invoke("findAllEmployeeCompetencies", new object[] {
                        Id});
            return ((EmployeeCompetency[])(results[0]));
        }
        
        /// <remarks/>
        public void findAllEmployeeCompetenciesAsync(int Id) {
            this.findAllEmployeeCompetenciesAsync(Id, null);
        }
        
        /// <remarks/>
        public void findAllEmployeeCompetenciesAsync(int Id, object userState) {
            if ((this.findAllEmployeeCompetenciesOperationCompleted == null)) {
                this.findAllEmployeeCompetenciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindAllEmployeeCompetenciesOperationCompleted);
            }
            this.InvokeAsync("findAllEmployeeCompetencies", new object[] {
                        Id}, this.findAllEmployeeCompetenciesOperationCompleted, userState);
        }
        
        private void OnfindAllEmployeeCompetenciesOperationCompleted(object arg) {
            if ((this.findAllEmployeeCompetenciesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findAllEmployeeCompetenciesCompleted(this, new findAllEmployeeCompetenciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice_layer", ResponseNamespace="http://webservice_layer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAllEmployeeCompetenciesReturn")]
        public EmployeeCompetency[] getAllEmployeeCompetencies() {
            object[] results = this.Invoke("getAllEmployeeCompetencies", new object[0]);
            return ((EmployeeCompetency[])(results[0]));
        }
        
        /// <remarks/>
        public void getAllEmployeeCompetenciesAsync() {
            this.getAllEmployeeCompetenciesAsync(null);
        }
        
        /// <remarks/>
        public void getAllEmployeeCompetenciesAsync(object userState) {
            if ((this.getAllEmployeeCompetenciesOperationCompleted == null)) {
                this.getAllEmployeeCompetenciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllEmployeeCompetenciesOperationCompleted);
            }
            this.InvokeAsync("getAllEmployeeCompetencies", new object[0], this.getAllEmployeeCompetenciesOperationCompleted, userState);
        }
        
        private void OngetAllEmployeeCompetenciesOperationCompleted(object arg) {
            if ((this.getAllEmployeeCompetenciesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllEmployeeCompetenciesCompleted(this, new getAllEmployeeCompetenciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice_layer")]
    public partial class EmployeeCompetency {
        
        private int competencyIdField;
        
        private int employeeIdField;
        
        private int idField;
        
        /// <remarks/>
        public int competencyId {
            get {
                return this.competencyIdField;
            }
            set {
                this.competencyIdField = value;
            }
        }
        
        /// <remarks/>
        public int employeeId {
            get {
                return this.employeeIdField;
            }
            set {
                this.employeeIdField = value;
            }
        }
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void createEmployeeCompetencyCompletedEventHandler(object sender, createEmployeeCompetencyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createEmployeeCompetencyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createEmployeeCompetencyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void deleteEmployeeCompetencyCompletedEventHandler(object sender, deleteEmployeeCompetencyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteEmployeeCompetencyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteEmployeeCompetencyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void findEmployeeCompetencyCompletedEventHandler(object sender, findEmployeeCompetencyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findEmployeeCompetencyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findEmployeeCompetencyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public EmployeeCompetency Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((EmployeeCompetency)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void updateEmployeeCompetencyCompletedEventHandler(object sender, updateEmployeeCompetencyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateEmployeeCompetencyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateEmployeeCompetencyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void findAllEmployeeCompetenciesCompletedEventHandler(object sender, findAllEmployeeCompetenciesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findAllEmployeeCompetenciesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findAllEmployeeCompetenciesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public EmployeeCompetency[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((EmployeeCompetency[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void getAllEmployeeCompetenciesCompletedEventHandler(object sender, getAllEmployeeCompetenciesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllEmployeeCompetenciesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllEmployeeCompetenciesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public EmployeeCompetency[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((EmployeeCompetency[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591