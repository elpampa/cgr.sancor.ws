﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuentaCorriente.ARTServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ObtenerCtaCteContratosRequest", Namespace="http://schemas.datacontract.org/2004/07/ART.Accounting.Contract")]
    [System.SerializableAttribute()]
    public partial class ObtenerCtaCteContratosRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ContratoField;
        
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
        public int Contrato {
            get {
                return this.ContratoField;
            }
            set {
                if ((this.ContratoField.Equals(value) != true)) {
                    this.ContratoField = value;
                    this.RaisePropertyChanged("Contrato");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ObtenerCtaCteContratosResponse", Namespace="http://schemas.datacontract.org/2004/07/ART.Accounting.Contract")]
    [System.SerializableAttribute()]
    public partial class ObtenerCtaCteContratosResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CuentaCorriente.ARTServices.ResumenCtaCteContrato CtaCteContratosField;
        
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
        public CuentaCorriente.ARTServices.ResumenCtaCteContrato CtaCteContratos {
            get {
                return this.CtaCteContratosField;
            }
            set {
                if ((object.ReferenceEquals(this.CtaCteContratosField, value) != true)) {
                    this.CtaCteContratosField = value;
                    this.RaisePropertyChanged("CtaCteContratos");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ResumenCtaCteContrato", Namespace="http://schemas.datacontract.org/2004/07/ART.Accounting.Contract.Entities")]
    [System.SerializableAttribute()]
    public partial class ResumenCtaCteContrato : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ADVERTENCIAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ALTAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BAJAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CONTRField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CUITField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CuentaCorriente.ARTServices.ResumenCtaCteContrato.Detalle[] DETALLEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FECHAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FECHALTAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FECHBAJAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MAILField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RAZSOCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal SALDOFField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TELEFField;
        
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
        public string ADVERTENCIA {
            get {
                return this.ADVERTENCIAField;
            }
            set {
                if ((object.ReferenceEquals(this.ADVERTENCIAField, value) != true)) {
                    this.ADVERTENCIAField = value;
                    this.RaisePropertyChanged("ADVERTENCIA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ALTA {
            get {
                return this.ALTAField;
            }
            set {
                if ((object.ReferenceEquals(this.ALTAField, value) != true)) {
                    this.ALTAField = value;
                    this.RaisePropertyChanged("ALTA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BAJA {
            get {
                return this.BAJAField;
            }
            set {
                if ((object.ReferenceEquals(this.BAJAField, value) != true)) {
                    this.BAJAField = value;
                    this.RaisePropertyChanged("BAJA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CONTR {
            get {
                return this.CONTRField;
            }
            set {
                if ((object.ReferenceEquals(this.CONTRField, value) != true)) {
                    this.CONTRField = value;
                    this.RaisePropertyChanged("CONTR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CUIT {
            get {
                return this.CUITField;
            }
            set {
                if ((object.ReferenceEquals(this.CUITField, value) != true)) {
                    this.CUITField = value;
                    this.RaisePropertyChanged("CUIT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CuentaCorriente.ARTServices.ResumenCtaCteContrato.Detalle[] DETALLE {
            get {
                return this.DETALLEField;
            }
            set {
                if ((object.ReferenceEquals(this.DETALLEField, value) != true)) {
                    this.DETALLEField = value;
                    this.RaisePropertyChanged("DETALLE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FECHA {
            get {
                return this.FECHAField;
            }
            set {
                if ((this.FECHAField.Equals(value) != true)) {
                    this.FECHAField = value;
                    this.RaisePropertyChanged("FECHA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FECHALTA {
            get {
                return this.FECHALTAField;
            }
            set {
                if ((this.FECHALTAField.Equals(value) != true)) {
                    this.FECHALTAField = value;
                    this.RaisePropertyChanged("FECHALTA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FECHBAJA {
            get {
                return this.FECHBAJAField;
            }
            set {
                if ((this.FECHBAJAField.Equals(value) != true)) {
                    this.FECHBAJAField = value;
                    this.RaisePropertyChanged("FECHBAJA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MAIL {
            get {
                return this.MAILField;
            }
            set {
                if ((object.ReferenceEquals(this.MAILField, value) != true)) {
                    this.MAILField = value;
                    this.RaisePropertyChanged("MAIL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RAZSOC {
            get {
                return this.RAZSOCField;
            }
            set {
                if ((object.ReferenceEquals(this.RAZSOCField, value) != true)) {
                    this.RAZSOCField = value;
                    this.RaisePropertyChanged("RAZSOC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal SALDOF {
            get {
                return this.SALDOFField;
            }
            set {
                if ((this.SALDOFField.Equals(value) != true)) {
                    this.SALDOFField = value;
                    this.RaisePropertyChanged("SALDOF");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TELEF {
            get {
                return this.TELEFField;
            }
            set {
                if ((object.ReferenceEquals(this.TELEFField, value) != true)) {
                    this.TELEFField = value;
                    this.RaisePropertyChanged("TELEF");
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
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="ResumenCtaCteContrato.Detalle", Namespace="http://schemas.datacontract.org/2004/07/ART.Accounting.Contract.Entities")]
        [System.SerializableAttribute()]
        public partial class Detalle : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
            
            [System.NonSerializedAttribute()]
            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private decimal ALIDECLField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private decimal ALIEMITField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private decimal CUOTAField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private int EMPLField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private decimal FFEField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private decimal FIJODECLField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private decimal FUOEMITField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private decimal INTFINCOField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private decimal INTMORAField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private decimal MASAField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string MESField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string MESDGIField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private decimal PAGOCUOTAField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private decimal PAGOFFEField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private decimal SALDOMESField;
            
            public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
                get {
                    return this.extensionDataField;
                }
                set {
                    this.extensionDataField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal ALIDECL {
                get {
                    return this.ALIDECLField;
                }
                set {
                    if ((this.ALIDECLField.Equals(value) != true)) {
                        this.ALIDECLField = value;
                        this.RaisePropertyChanged("ALIDECL");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal ALIEMIT {
                get {
                    return this.ALIEMITField;
                }
                set {
                    if ((this.ALIEMITField.Equals(value) != true)) {
                        this.ALIEMITField = value;
                        this.RaisePropertyChanged("ALIEMIT");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal CUOTA {
                get {
                    return this.CUOTAField;
                }
                set {
                    if ((this.CUOTAField.Equals(value) != true)) {
                        this.CUOTAField = value;
                        this.RaisePropertyChanged("CUOTA");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public int EMPL {
                get {
                    return this.EMPLField;
                }
                set {
                    if ((this.EMPLField.Equals(value) != true)) {
                        this.EMPLField = value;
                        this.RaisePropertyChanged("EMPL");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal FFE {
                get {
                    return this.FFEField;
                }
                set {
                    if ((this.FFEField.Equals(value) != true)) {
                        this.FFEField = value;
                        this.RaisePropertyChanged("FFE");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal FIJODECL {
                get {
                    return this.FIJODECLField;
                }
                set {
                    if ((this.FIJODECLField.Equals(value) != true)) {
                        this.FIJODECLField = value;
                        this.RaisePropertyChanged("FIJODECL");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal FUOEMIT {
                get {
                    return this.FUOEMITField;
                }
                set {
                    if ((this.FUOEMITField.Equals(value) != true)) {
                        this.FUOEMITField = value;
                        this.RaisePropertyChanged("FUOEMIT");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal INTFINCO {
                get {
                    return this.INTFINCOField;
                }
                set {
                    if ((this.INTFINCOField.Equals(value) != true)) {
                        this.INTFINCOField = value;
                        this.RaisePropertyChanged("INTFINCO");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal INTMORA {
                get {
                    return this.INTMORAField;
                }
                set {
                    if ((this.INTMORAField.Equals(value) != true)) {
                        this.INTMORAField = value;
                        this.RaisePropertyChanged("INTMORA");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal MASA {
                get {
                    return this.MASAField;
                }
                set {
                    if ((this.MASAField.Equals(value) != true)) {
                        this.MASAField = value;
                        this.RaisePropertyChanged("MASA");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string MES {
                get {
                    return this.MESField;
                }
                set {
                    if ((object.ReferenceEquals(this.MESField, value) != true)) {
                        this.MESField = value;
                        this.RaisePropertyChanged("MES");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string MESDGI {
                get {
                    return this.MESDGIField;
                }
                set {
                    if ((object.ReferenceEquals(this.MESDGIField, value) != true)) {
                        this.MESDGIField = value;
                        this.RaisePropertyChanged("MESDGI");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal PAGOCUOTA {
                get {
                    return this.PAGOCUOTAField;
                }
                set {
                    if ((this.PAGOCUOTAField.Equals(value) != true)) {
                        this.PAGOCUOTAField = value;
                        this.RaisePropertyChanged("PAGOCUOTA");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal PAGOFFE {
                get {
                    return this.PAGOFFEField;
                }
                set {
                    if ((this.PAGOFFEField.Equals(value) != true)) {
                        this.PAGOFFEField = value;
                        this.RaisePropertyChanged("PAGOFFE");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public decimal SALDOMES {
                get {
                    return this.SALDOMESField;
                }
                set {
                    if ((this.SALDOMESField.Equals(value) != true)) {
                        this.SALDOMESField = value;
                        this.RaisePropertyChanged("SALDOMES");
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ValidationFault", Namespace="urn:SancorSeguros/Services/Validation/2012/11")]
    [System.SerializableAttribute()]
    public partial class ValidationFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CuentaCorriente.ARTServices.ValidationDetail[] DetailsField;
        
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
        public CuentaCorriente.ARTServices.ValidationDetail[] Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ValidationDetail", Namespace="urn:SancorSeguros/Services/Validation/2012/11")]
    [System.SerializableAttribute()]
    public partial class ValidationDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ParameterNameField;
        
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
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ParameterName {
            get {
                return this.ParameterNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ParameterNameField, value) != true)) {
                    this.ParameterNameField = value;
                    this.RaisePropertyChanged("ParameterName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ARTServices.IARTServices")]
    public interface IARTServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IARTServices/ObtenerCteCteContratos", ReplyAction="http://tempuri.org/IARTServices/ObtenerCteCteContratosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(CuentaCorriente.ARTServices.ValidationFault), Action="urn:SancorSeguros/Services/Validation/2012/11/ValidationFault", Name="ValidationFault", Namespace="")]
        CuentaCorriente.ARTServices.ObtenerCtaCteContratosResponse ObtenerCteCteContratos(CuentaCorriente.ARTServices.ObtenerCtaCteContratosRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IARTServicesChannel : CuentaCorriente.ARTServices.IARTServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ARTServicesClient : System.ServiceModel.ClientBase<CuentaCorriente.ARTServices.IARTServices>, CuentaCorriente.ARTServices.IARTServices {
        
        public ARTServicesClient() {
        }
        
        public ARTServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ARTServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ARTServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ARTServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CuentaCorriente.ARTServices.ObtenerCtaCteContratosResponse ObtenerCteCteContratos(CuentaCorriente.ARTServices.ObtenerCtaCteContratosRequest request) {
            return base.Channel.ObtenerCteCteContratos(request);
        }
    }
}