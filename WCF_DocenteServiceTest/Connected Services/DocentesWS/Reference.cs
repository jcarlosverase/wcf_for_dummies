﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_DocenteServiceTest.DocentesWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Docente", Namespace="http://schemas.datacontract.org/2004/07/WCF_DocenteService.Dominio")]
    [System.SerializableAttribute()]
    public partial class Docente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdDocenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
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
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Dni {
            get {
                return this.DniField;
            }
            set {
                if ((object.ReferenceEquals(this.DniField, value) != true)) {
                    this.DniField = value;
                    this.RaisePropertyChanged("Dni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdDocente {
            get {
                return this.IdDocenteField;
            }
            set {
                if ((this.IdDocenteField.Equals(value) != true)) {
                    this.IdDocenteField = value;
                    this.RaisePropertyChanged("IdDocente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WCF_DocenteService.Errores")]
    [System.SerializableAttribute()]
    public partial class RepetidoException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
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
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DocentesWS.IDocenteService")]
    public interface IDocenteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocenteService/CrearDocente", ReplyAction="http://tempuri.org/IDocenteService/CrearDocenteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCF_DocenteServiceTest.DocentesWS.RepetidoException), Action="http://tempuri.org/IDocenteService/CrearDocenteRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WCF_DocenteService.Errores")]
        WCF_DocenteServiceTest.DocentesWS.Docente CrearDocente(WCF_DocenteServiceTest.DocentesWS.Docente docenteACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocenteService/CrearDocente", ReplyAction="http://tempuri.org/IDocenteService/CrearDocenteResponse")]
        System.Threading.Tasks.Task<WCF_DocenteServiceTest.DocentesWS.Docente> CrearDocenteAsync(WCF_DocenteServiceTest.DocentesWS.Docente docenteACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocenteService/ObtenerDocente", ReplyAction="http://tempuri.org/IDocenteService/ObtenerDocenteResponse")]
        WCF_DocenteServiceTest.DocentesWS.Docente ObtenerDocente(int idDocente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocenteService/ObtenerDocente", ReplyAction="http://tempuri.org/IDocenteService/ObtenerDocenteResponse")]
        System.Threading.Tasks.Task<WCF_DocenteServiceTest.DocentesWS.Docente> ObtenerDocenteAsync(int idDocente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocenteService/ModificarDocente", ReplyAction="http://tempuri.org/IDocenteService/ModificarDocenteResponse")]
        WCF_DocenteServiceTest.DocentesWS.Docente ModificarDocente(WCF_DocenteServiceTest.DocentesWS.Docente docenteAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocenteService/ModificarDocente", ReplyAction="http://tempuri.org/IDocenteService/ModificarDocenteResponse")]
        System.Threading.Tasks.Task<WCF_DocenteServiceTest.DocentesWS.Docente> ModificarDocenteAsync(WCF_DocenteServiceTest.DocentesWS.Docente docenteAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocenteService/EliminarDocente", ReplyAction="http://tempuri.org/IDocenteService/EliminarDocenteResponse")]
        void EliminarDocente(int idDocente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocenteService/EliminarDocente", ReplyAction="http://tempuri.org/IDocenteService/EliminarDocenteResponse")]
        System.Threading.Tasks.Task EliminarDocenteAsync(int idDocente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocenteService/ListarDocentes", ReplyAction="http://tempuri.org/IDocenteService/ListarDocentesResponse")]
        WCF_DocenteServiceTest.DocentesWS.Docente[] ListarDocentes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocenteService/ListarDocentes", ReplyAction="http://tempuri.org/IDocenteService/ListarDocentesResponse")]
        System.Threading.Tasks.Task<WCF_DocenteServiceTest.DocentesWS.Docente[]> ListarDocentesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDocenteServiceChannel : WCF_DocenteServiceTest.DocentesWS.IDocenteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DocenteServiceClient : System.ServiceModel.ClientBase<WCF_DocenteServiceTest.DocentesWS.IDocenteService>, WCF_DocenteServiceTest.DocentesWS.IDocenteService {
        
        public DocenteServiceClient() {
        }
        
        public DocenteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DocenteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocenteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocenteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCF_DocenteServiceTest.DocentesWS.Docente CrearDocente(WCF_DocenteServiceTest.DocentesWS.Docente docenteACrear) {
            return base.Channel.CrearDocente(docenteACrear);
        }
        
        public System.Threading.Tasks.Task<WCF_DocenteServiceTest.DocentesWS.Docente> CrearDocenteAsync(WCF_DocenteServiceTest.DocentesWS.Docente docenteACrear) {
            return base.Channel.CrearDocenteAsync(docenteACrear);
        }
        
        public WCF_DocenteServiceTest.DocentesWS.Docente ObtenerDocente(int idDocente) {
            return base.Channel.ObtenerDocente(idDocente);
        }
        
        public System.Threading.Tasks.Task<WCF_DocenteServiceTest.DocentesWS.Docente> ObtenerDocenteAsync(int idDocente) {
            return base.Channel.ObtenerDocenteAsync(idDocente);
        }
        
        public WCF_DocenteServiceTest.DocentesWS.Docente ModificarDocente(WCF_DocenteServiceTest.DocentesWS.Docente docenteAModificar) {
            return base.Channel.ModificarDocente(docenteAModificar);
        }
        
        public System.Threading.Tasks.Task<WCF_DocenteServiceTest.DocentesWS.Docente> ModificarDocenteAsync(WCF_DocenteServiceTest.DocentesWS.Docente docenteAModificar) {
            return base.Channel.ModificarDocenteAsync(docenteAModificar);
        }
        
        public void EliminarDocente(int idDocente) {
            base.Channel.EliminarDocente(idDocente);
        }
        
        public System.Threading.Tasks.Task EliminarDocenteAsync(int idDocente) {
            return base.Channel.EliminarDocenteAsync(idDocente);
        }
        
        public WCF_DocenteServiceTest.DocentesWS.Docente[] ListarDocentes() {
            return base.Channel.ListarDocentes();
        }
        
        public System.Threading.Tasks.Task<WCF_DocenteServiceTest.DocentesWS.Docente[]> ListarDocentesAsync() {
            return base.Channel.ListarDocentesAsync();
        }
    }
}
