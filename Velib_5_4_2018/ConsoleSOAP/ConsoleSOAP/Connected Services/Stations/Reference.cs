﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleSOAP.Stations {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/ServerSOAPToREST")]
    [System.SerializableAttribute()]
    public partial class Station : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Available_bike_standsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Available_bikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BankingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Bike_standsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BonusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Contract_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long Last_updateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleSOAP.Stations.Point PositionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Available_bike_stands {
            get {
                return this.Available_bike_standsField;
            }
            set {
                if ((this.Available_bike_standsField.Equals(value) != true)) {
                    this.Available_bike_standsField = value;
                    this.RaisePropertyChanged("Available_bike_stands");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Available_bikes {
            get {
                return this.Available_bikesField;
            }
            set {
                if ((this.Available_bikesField.Equals(value) != true)) {
                    this.Available_bikesField = value;
                    this.RaisePropertyChanged("Available_bikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Banking {
            get {
                return this.BankingField;
            }
            set {
                if ((this.BankingField.Equals(value) != true)) {
                    this.BankingField = value;
                    this.RaisePropertyChanged("Banking");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Bike_stands {
            get {
                return this.Bike_standsField;
            }
            set {
                if ((this.Bike_standsField.Equals(value) != true)) {
                    this.Bike_standsField = value;
                    this.RaisePropertyChanged("Bike_stands");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Bonus {
            get {
                return this.BonusField;
            }
            set {
                if ((this.BonusField.Equals(value) != true)) {
                    this.BonusField = value;
                    this.RaisePropertyChanged("Bonus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contract_name {
            get {
                return this.Contract_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Contract_nameField, value) != true)) {
                    this.Contract_nameField = value;
                    this.RaisePropertyChanged("Contract_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Last_update {
            get {
                return this.Last_updateField;
            }
            set {
                if ((this.Last_updateField.Equals(value) != true)) {
                    this.Last_updateField = value;
                    this.RaisePropertyChanged("Last_update");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number {
            get {
                return this.NumberField;
            }
            set {
                if ((this.NumberField.Equals(value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleSOAP.Stations.Point Position {
            get {
                return this.PositionField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionField, value) != true)) {
                    this.PositionField = value;
                    this.RaisePropertyChanged("Position");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Point", Namespace="http://schemas.datacontract.org/2004/07/ServerSOAPToREST")]
    [System.SerializableAttribute()]
    public partial class Point : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float latField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float lngField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float lat {
            get {
                return this.latField;
            }
            set {
                if ((this.latField.Equals(value) != true)) {
                    this.latField = value;
                    this.RaisePropertyChanged("lat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float lng {
            get {
                return this.lngField;
            }
            set {
                if ((this.lngField.Equals(value) != true)) {
                    this.lngField = value;
                    this.RaisePropertyChanged("lng");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Stations.IVelib", CallbackContract=typeof(ConsoleSOAP.Stations.IVelibCallback))]
    public interface IVelib {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelib/GetStationsByCity", ReplyAction="http://tempuri.org/IVelib/GetStationsByCityResponse")]
        ConsoleSOAP.Stations.Station[] GetStationsByCity(string cityName, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelib/GetStationsByCity", ReplyAction="http://tempuri.org/IVelib/GetStationsByCityResponse")]
        System.Threading.Tasks.Task<ConsoleSOAP.Stations.Station[]> GetStationsByCityAsync(string cityName, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelib/GetStationDetails", ReplyAction="http://tempuri.org/IVelib/GetStationDetailsResponse")]
        string GetStationDetails(string cityName, string stationName, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelib/GetStationDetails", ReplyAction="http://tempuri.org/IVelib/GetStationDetailsResponse")]
        System.Threading.Tasks.Task<string> GetStationDetailsAsync(string cityName, string stationName, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelib/ChangeCacheSettingsSlide", ReplyAction="http://tempuri.org/IVelib/ChangeCacheSettingsSlideResponse")]
        void ChangeCacheSettingsSlide(int slideTime, string unit, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelib/ChangeCacheSettingsSlide", ReplyAction="http://tempuri.org/IVelib/ChangeCacheSettingsSlideResponse")]
        System.Threading.Tasks.Task ChangeCacheSettingsSlideAsync(int slideTime, string unit, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelib/SubscribeDetails", ReplyAction="http://tempuri.org/IVelib/SubscribeDetailsResponse")]
        void SubscribeDetails(string cityName, string stationName, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelib/SubscribeDetails", ReplyAction="http://tempuri.org/IVelib/SubscribeDetailsResponse")]
        System.Threading.Tasks.Task SubscribeDetailsAsync(string cityName, string stationName, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelib/UnsubscribeDetails", ReplyAction="http://tempuri.org/IVelib/UnsubscribeDetailsResponse")]
        void UnsubscribeDetails(string cityName, string stationName, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelib/UnsubscribeDetails", ReplyAction="http://tempuri.org/IVelib/UnsubscribeDetailsResponse")]
        System.Threading.Tasks.Task UnsubscribeDetailsAsync(string cityName, string stationName, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelib/ChangeSubscribeSettings", ReplyAction="http://tempuri.org/IVelib/ChangeSubscribeSettingsResponse")]
        void ChangeSubscribeSettings(int slideTime, string unit, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelib/ChangeSubscribeSettings", ReplyAction="http://tempuri.org/IVelib/ChangeSubscribeSettingsResponse")]
        System.Threading.Tasks.Task ChangeSubscribeSettingsAsync(int slideTime, string unit, string login);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVelibCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IVelib/SubscriptionRefreshed")]
        void SubscriptionRefreshed(string toPrint);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVelibChannel : ConsoleSOAP.Stations.IVelib, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VelibClient : System.ServiceModel.DuplexClientBase<ConsoleSOAP.Stations.IVelib>, ConsoleSOAP.Stations.IVelib {
        
        public VelibClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public VelibClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public VelibClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public VelibClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public VelibClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public ConsoleSOAP.Stations.Station[] GetStationsByCity(string cityName, string login) {
            return base.Channel.GetStationsByCity(cityName, login);
        }
        
        public System.Threading.Tasks.Task<ConsoleSOAP.Stations.Station[]> GetStationsByCityAsync(string cityName, string login) {
            return base.Channel.GetStationsByCityAsync(cityName, login);
        }
        
        public string GetStationDetails(string cityName, string stationName, string login) {
            return base.Channel.GetStationDetails(cityName, stationName, login);
        }
        
        public System.Threading.Tasks.Task<string> GetStationDetailsAsync(string cityName, string stationName, string login) {
            return base.Channel.GetStationDetailsAsync(cityName, stationName, login);
        }
        
        public void ChangeCacheSettingsSlide(int slideTime, string unit, string login) {
            base.Channel.ChangeCacheSettingsSlide(slideTime, unit, login);
        }
        
        public System.Threading.Tasks.Task ChangeCacheSettingsSlideAsync(int slideTime, string unit, string login) {
            return base.Channel.ChangeCacheSettingsSlideAsync(slideTime, unit, login);
        }
        
        public void SubscribeDetails(string cityName, string stationName, string login) {
            base.Channel.SubscribeDetails(cityName, stationName, login);
        }
        
        public System.Threading.Tasks.Task SubscribeDetailsAsync(string cityName, string stationName, string login) {
            return base.Channel.SubscribeDetailsAsync(cityName, stationName, login);
        }
        
        public void UnsubscribeDetails(string cityName, string stationName, string login) {
            base.Channel.UnsubscribeDetails(cityName, stationName, login);
        }
        
        public System.Threading.Tasks.Task UnsubscribeDetailsAsync(string cityName, string stationName, string login) {
            return base.Channel.UnsubscribeDetailsAsync(cityName, stationName, login);
        }
        
        public void ChangeSubscribeSettings(int slideTime, string unit, string login) {
            base.Channel.ChangeSubscribeSettings(slideTime, unit, login);
        }
        
        public System.Threading.Tasks.Task ChangeSubscribeSettingsAsync(int slideTime, string unit, string login) {
            return base.Channel.ChangeSubscribeSettingsAsync(slideTime, unit, login);
        }
    }
}
