﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientReservasi_093.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CekLokasi", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class CekLokasi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeskripsiSingkatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDLokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaLokasiField;
        
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
        public string DeskripsiSingkat {
            get {
                return this.DeskripsiSingkatField;
            }
            set {
                if ((object.ReferenceEquals(this.DeskripsiSingkatField, value) != true)) {
                    this.DeskripsiSingkatField = value;
                    this.RaisePropertyChanged("DeskripsiSingkat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDLokasi {
            get {
                return this.IDLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.IDLokasiField, value) != true)) {
                    this.IDLokasiField = value;
                    this.RaisePropertyChanged("IDLokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaLokasi {
            get {
                return this.NamaLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaLokasiField, value) != true)) {
                    this.NamaLokasiField = value;
                    this.RaisePropertyChanged("NamaLokasi");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DetailLokasi", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class DetailLokasi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeskripsiFullField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDLokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KoutaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaLokasiField;
        
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
        public string DeskripsiFull {
            get {
                return this.DeskripsiFullField;
            }
            set {
                if ((object.ReferenceEquals(this.DeskripsiFullField, value) != true)) {
                    this.DeskripsiFullField = value;
                    this.RaisePropertyChanged("DeskripsiFull");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDLokasi {
            get {
                return this.IDLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.IDLokasiField, value) != true)) {
                    this.IDLokasiField = value;
                    this.RaisePropertyChanged("IDLokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Kouta {
            get {
                return this.KoutaField;
            }
            set {
                if ((this.KoutaField.Equals(value) != true)) {
                    this.KoutaField = value;
                    this.RaisePropertyChanged("Kouta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaLokasi {
            get {
                return this.NamaLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaLokasiField, value) != true)) {
                    this.NamaLokasiField = value;
                    this.RaisePropertyChanged("NamaLokasi");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Pemesanan", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class Pemesanan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDPemesananField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int JumlahPemesananField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaCustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoTeleponField;
        
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
        public string IDPemesanan {
            get {
                return this.IDPemesananField;
            }
            set {
                if ((object.ReferenceEquals(this.IDPemesananField, value) != true)) {
                    this.IDPemesananField = value;
                    this.RaisePropertyChanged("IDPemesanan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int JumlahPemesanan {
            get {
                return this.JumlahPemesananField;
            }
            set {
                if ((this.JumlahPemesananField.Equals(value) != true)) {
                    this.JumlahPemesananField = value;
                    this.RaisePropertyChanged("JumlahPemesanan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lokasi {
            get {
                return this.LokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.LokasiField, value) != true)) {
                    this.LokasiField = value;
                    this.RaisePropertyChanged("Lokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaCustomer {
            get {
                return this.NamaCustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaCustomerField, value) != true)) {
                    this.NamaCustomerField = value;
                    this.RaisePropertyChanged("NamaCustomer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoTelepon {
            get {
                return this.NoTeleponField;
            }
            set {
                if ((object.ReferenceEquals(this.NoTeleponField, value) != true)) {
                    this.NoTeleponField = value;
                    this.RaisePropertyChanged("NoTelepon");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelepon, int JumlahPemesanan, string IDLokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        System.Threading.Tasks.Task<string> pemesananAsync(string IDPemesanan, string NamaCustomer, string NoTelepon, int JumlahPemesanan, string IDLokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        string editPemesanan(string IDPemesanan, string NamaCustomer, string No_telpon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        System.Threading.Tasks.Task<string> editPemesananAsync(string IDPemesanan, string NamaCustomer, string No_telpon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        string deletePemesanan(string IDPemesanan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        System.Threading.Tasks.Task<string> deletePemesananAsync(string IDPemesanan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        ClientReservasi_093.ServiceReference1.CekLokasi[] ReviewLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        System.Threading.Tasks.Task<ClientReservasi_093.ServiceReference1.CekLokasi[]> ReviewLokasiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        ClientReservasi_093.ServiceReference1.DetailLokasi[] DetailLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        System.Threading.Tasks.Task<ClientReservasi_093.ServiceReference1.DetailLokasi[]> DetailLokasiAsync();
        
        // CODEGEN: Generating message contract since the wrapper name (Pemesanan) of message PemesananRequest does not match the default value (Pemesanan1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        ClientReservasi_093.ServiceReference1.PemesananResponse Pemesanan1(ClientReservasi_093.ServiceReference1.PemesananRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        System.Threading.Tasks.Task<ClientReservasi_093.ServiceReference1.PemesananResponse> Pemesanan1Async(ClientReservasi_093.ServiceReference1.PemesananRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Pemesanan", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananRequest {
        
        public PemesananRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PemesananResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ClientReservasi_093.ServiceReference1.Pemesanan[] PemesananResult;
        
        public PemesananResponse() {
        }
        
        public PemesananResponse(ClientReservasi_093.ServiceReference1.Pemesanan[] PemesananResult) {
            this.PemesananResult = PemesananResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientReservasi_093.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientReservasi_093.ServiceReference1.IService1>, ClientReservasi_093.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelepon, int JumlahPemesanan, string IDLokasi) {
            return base.Channel.pemesanan(IDPemesanan, NamaCustomer, NoTelepon, JumlahPemesanan, IDLokasi);
        }
        
        public System.Threading.Tasks.Task<string> pemesananAsync(string IDPemesanan, string NamaCustomer, string NoTelepon, int JumlahPemesanan, string IDLokasi) {
            return base.Channel.pemesananAsync(IDPemesanan, NamaCustomer, NoTelepon, JumlahPemesanan, IDLokasi);
        }
        
        public string editPemesanan(string IDPemesanan, string NamaCustomer, string No_telpon) {
            return base.Channel.editPemesanan(IDPemesanan, NamaCustomer, No_telpon);
        }
        
        public System.Threading.Tasks.Task<string> editPemesananAsync(string IDPemesanan, string NamaCustomer, string No_telpon) {
            return base.Channel.editPemesananAsync(IDPemesanan, NamaCustomer, No_telpon);
        }
        
        public string deletePemesanan(string IDPemesanan) {
            return base.Channel.deletePemesanan(IDPemesanan);
        }
        
        public System.Threading.Tasks.Task<string> deletePemesananAsync(string IDPemesanan) {
            return base.Channel.deletePemesananAsync(IDPemesanan);
        }
        
        public ClientReservasi_093.ServiceReference1.CekLokasi[] ReviewLokasi() {
            return base.Channel.ReviewLokasi();
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_093.ServiceReference1.CekLokasi[]> ReviewLokasiAsync() {
            return base.Channel.ReviewLokasiAsync();
        }
        
        public ClientReservasi_093.ServiceReference1.DetailLokasi[] DetailLokasi() {
            return base.Channel.DetailLokasi();
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_093.ServiceReference1.DetailLokasi[]> DetailLokasiAsync() {
            return base.Channel.DetailLokasiAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientReservasi_093.ServiceReference1.PemesananResponse ClientReservasi_093.ServiceReference1.IService1.Pemesanan1(ClientReservasi_093.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1(request);
        }
        
        public ClientReservasi_093.ServiceReference1.Pemesanan[] Pemesanan1() {
            ClientReservasi_093.ServiceReference1.PemesananRequest inValue = new ClientReservasi_093.ServiceReference1.PemesananRequest();
            ClientReservasi_093.ServiceReference1.PemesananResponse retVal = ((ClientReservasi_093.ServiceReference1.IService1)(this)).Pemesanan1(inValue);
            return retVal.PemesananResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientReservasi_093.ServiceReference1.PemesananResponse> ClientReservasi_093.ServiceReference1.IService1.Pemesanan1Async(ClientReservasi_093.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1Async(request);
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_093.ServiceReference1.PemesananResponse> Pemesanan1Async() {
            ClientReservasi_093.ServiceReference1.PemesananRequest inValue = new ClientReservasi_093.ServiceReference1.PemesananRequest();
            return ((ClientReservasi_093.ServiceReference1.IService1)(this)).Pemesanan1Async(inValue);
        }
    }
}
