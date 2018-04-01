﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAdmin.AdminService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminService.IAdmin")]
    public interface IAdmin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdmin/GetDetailsUser", ReplyAction="http://tempuri.org/IAdmin/GetDetailsUserResponse")]
        string GetDetailsUser(string wantedUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdmin/GetDetailsUser", ReplyAction="http://tempuri.org/IAdmin/GetDetailsUserResponse")]
        System.Threading.Tasks.Task<string> GetDetailsUserAsync(string wantedUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdmin/GetGeneralMonitoring", ReplyAction="http://tempuri.org/IAdmin/GetGeneralMonitoringResponse")]
        string GetGeneralMonitoring();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdmin/GetGeneralMonitoring", ReplyAction="http://tempuri.org/IAdmin/GetGeneralMonitoringResponse")]
        System.Threading.Tasks.Task<string> GetGeneralMonitoringAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminChannel : ConsoleAdmin.AdminService.IAdmin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminClient : System.ServiceModel.ClientBase<ConsoleAdmin.AdminService.IAdmin>, ConsoleAdmin.AdminService.IAdmin {
        
        public AdminClient() {
        }
        
        public AdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetDetailsUser(string wantedUser) {
            return base.Channel.GetDetailsUser(wantedUser);
        }
        
        public System.Threading.Tasks.Task<string> GetDetailsUserAsync(string wantedUser) {
            return base.Channel.GetDetailsUserAsync(wantedUser);
        }
        
        public string GetGeneralMonitoring() {
            return base.Channel.GetGeneralMonitoring();
        }
        
        public System.Threading.Tasks.Task<string> GetGeneralMonitoringAsync() {
            return base.Channel.GetGeneralMonitoringAsync();
        }
    }
}