﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplikacja_na_projekt.ServiceReference5 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfDouble", Namespace="http://tempuri.org/", ItemName="double")]
    [System.SerializableAttribute()]
    public class ArrayOfDouble : System.Collections.Generic.List<double> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference5.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name arr from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/srednia", ReplyAction="*")]
        Aplikacja_na_projekt.ServiceReference5.sredniaResponse srednia(Aplikacja_na_projekt.ServiceReference5.sredniaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/srednia", ReplyAction="*")]
        System.Threading.Tasks.Task<Aplikacja_na_projekt.ServiceReference5.sredniaResponse> sredniaAsync(Aplikacja_na_projekt.ServiceReference5.sredniaRequest request);
        
        // CODEGEN: Generating message contract since element name arr from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mediana", ReplyAction="*")]
        Aplikacja_na_projekt.ServiceReference5.medianaResponse mediana(Aplikacja_na_projekt.ServiceReference5.medianaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mediana", ReplyAction="*")]
        System.Threading.Tasks.Task<Aplikacja_na_projekt.ServiceReference5.medianaResponse> medianaAsync(Aplikacja_na_projekt.ServiceReference5.medianaRequest request);
        
        // CODEGEN: Generating message contract since element name arr from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/wariancja", ReplyAction="*")]
        Aplikacja_na_projekt.ServiceReference5.wariancjaResponse wariancja(Aplikacja_na_projekt.ServiceReference5.wariancjaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/wariancja", ReplyAction="*")]
        System.Threading.Tasks.Task<Aplikacja_na_projekt.ServiceReference5.wariancjaResponse> wariancjaAsync(Aplikacja_na_projekt.ServiceReference5.wariancjaRequest request);
        
        // CODEGEN: Generating message contract since element name arr from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/std_odchylenie", ReplyAction="*")]
        Aplikacja_na_projekt.ServiceReference5.std_odchylenieResponse std_odchylenie(Aplikacja_na_projekt.ServiceReference5.std_odchylenieRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/std_odchylenie", ReplyAction="*")]
        System.Threading.Tasks.Task<Aplikacja_na_projekt.ServiceReference5.std_odchylenieResponse> std_odchylenieAsync(Aplikacja_na_projekt.ServiceReference5.std_odchylenieRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sredniaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="srednia", Namespace="http://tempuri.org/", Order=0)]
        public Aplikacja_na_projekt.ServiceReference5.sredniaRequestBody Body;
        
        public sredniaRequest() {
        }
        
        public sredniaRequest(Aplikacja_na_projekt.ServiceReference5.sredniaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class sredniaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr;
        
        public sredniaRequestBody() {
        }
        
        public sredniaRequestBody(Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr) {
            this.arr = arr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sredniaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sredniaResponse", Namespace="http://tempuri.org/", Order=0)]
        public Aplikacja_na_projekt.ServiceReference5.sredniaResponseBody Body;
        
        public sredniaResponse() {
        }
        
        public sredniaResponse(Aplikacja_na_projekt.ServiceReference5.sredniaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class sredniaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double sredniaResult;
        
        public sredniaResponseBody() {
        }
        
        public sredniaResponseBody(double sredniaResult) {
            this.sredniaResult = sredniaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class medianaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="mediana", Namespace="http://tempuri.org/", Order=0)]
        public Aplikacja_na_projekt.ServiceReference5.medianaRequestBody Body;
        
        public medianaRequest() {
        }
        
        public medianaRequest(Aplikacja_na_projekt.ServiceReference5.medianaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class medianaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr;
        
        public medianaRequestBody() {
        }
        
        public medianaRequestBody(Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr) {
            this.arr = arr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class medianaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="medianaResponse", Namespace="http://tempuri.org/", Order=0)]
        public Aplikacja_na_projekt.ServiceReference5.medianaResponseBody Body;
        
        public medianaResponse() {
        }
        
        public medianaResponse(Aplikacja_na_projekt.ServiceReference5.medianaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class medianaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double medianaResult;
        
        public medianaResponseBody() {
        }
        
        public medianaResponseBody(double medianaResult) {
            this.medianaResult = medianaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class wariancjaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="wariancja", Namespace="http://tempuri.org/", Order=0)]
        public Aplikacja_na_projekt.ServiceReference5.wariancjaRequestBody Body;
        
        public wariancjaRequest() {
        }
        
        public wariancjaRequest(Aplikacja_na_projekt.ServiceReference5.wariancjaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class wariancjaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr;
        
        public wariancjaRequestBody() {
        }
        
        public wariancjaRequestBody(Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr) {
            this.arr = arr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class wariancjaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="wariancjaResponse", Namespace="http://tempuri.org/", Order=0)]
        public Aplikacja_na_projekt.ServiceReference5.wariancjaResponseBody Body;
        
        public wariancjaResponse() {
        }
        
        public wariancjaResponse(Aplikacja_na_projekt.ServiceReference5.wariancjaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class wariancjaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double wariancjaResult;
        
        public wariancjaResponseBody() {
        }
        
        public wariancjaResponseBody(double wariancjaResult) {
            this.wariancjaResult = wariancjaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class std_odchylenieRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="std_odchylenie", Namespace="http://tempuri.org/", Order=0)]
        public Aplikacja_na_projekt.ServiceReference5.std_odchylenieRequestBody Body;
        
        public std_odchylenieRequest() {
        }
        
        public std_odchylenieRequest(Aplikacja_na_projekt.ServiceReference5.std_odchylenieRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class std_odchylenieRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr;
        
        public std_odchylenieRequestBody() {
        }
        
        public std_odchylenieRequestBody(Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr) {
            this.arr = arr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class std_odchylenieResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="std_odchylenieResponse", Namespace="http://tempuri.org/", Order=0)]
        public Aplikacja_na_projekt.ServiceReference5.std_odchylenieResponseBody Body;
        
        public std_odchylenieResponse() {
        }
        
        public std_odchylenieResponse(Aplikacja_na_projekt.ServiceReference5.std_odchylenieResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class std_odchylenieResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double std_odchylenieResult;
        
        public std_odchylenieResponseBody() {
        }
        
        public std_odchylenieResponseBody(double std_odchylenieResult) {
            this.std_odchylenieResult = std_odchylenieResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Aplikacja_na_projekt.ServiceReference5.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Aplikacja_na_projekt.ServiceReference5.WebService1Soap>, Aplikacja_na_projekt.ServiceReference5.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Aplikacja_na_projekt.ServiceReference5.sredniaResponse Aplikacja_na_projekt.ServiceReference5.WebService1Soap.srednia(Aplikacja_na_projekt.ServiceReference5.sredniaRequest request) {
            return base.Channel.srednia(request);
        }
        
        public double srednia(Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr) {
            Aplikacja_na_projekt.ServiceReference5.sredniaRequest inValue = new Aplikacja_na_projekt.ServiceReference5.sredniaRequest();
            inValue.Body = new Aplikacja_na_projekt.ServiceReference5.sredniaRequestBody();
            inValue.Body.arr = arr;
            Aplikacja_na_projekt.ServiceReference5.sredniaResponse retVal = ((Aplikacja_na_projekt.ServiceReference5.WebService1Soap)(this)).srednia(inValue);
            return retVal.Body.sredniaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Aplikacja_na_projekt.ServiceReference5.sredniaResponse> Aplikacja_na_projekt.ServiceReference5.WebService1Soap.sredniaAsync(Aplikacja_na_projekt.ServiceReference5.sredniaRequest request) {
            return base.Channel.sredniaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Aplikacja_na_projekt.ServiceReference5.sredniaResponse> sredniaAsync(Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr) {
            Aplikacja_na_projekt.ServiceReference5.sredniaRequest inValue = new Aplikacja_na_projekt.ServiceReference5.sredniaRequest();
            inValue.Body = new Aplikacja_na_projekt.ServiceReference5.sredniaRequestBody();
            inValue.Body.arr = arr;
            return ((Aplikacja_na_projekt.ServiceReference5.WebService1Soap)(this)).sredniaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Aplikacja_na_projekt.ServiceReference5.medianaResponse Aplikacja_na_projekt.ServiceReference5.WebService1Soap.mediana(Aplikacja_na_projekt.ServiceReference5.medianaRequest request) {
            return base.Channel.mediana(request);
        }
        
        public double mediana(Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr) {
            Aplikacja_na_projekt.ServiceReference5.medianaRequest inValue = new Aplikacja_na_projekt.ServiceReference5.medianaRequest();
            inValue.Body = new Aplikacja_na_projekt.ServiceReference5.medianaRequestBody();
            inValue.Body.arr = arr;
            Aplikacja_na_projekt.ServiceReference5.medianaResponse retVal = ((Aplikacja_na_projekt.ServiceReference5.WebService1Soap)(this)).mediana(inValue);
            return retVal.Body.medianaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Aplikacja_na_projekt.ServiceReference5.medianaResponse> Aplikacja_na_projekt.ServiceReference5.WebService1Soap.medianaAsync(Aplikacja_na_projekt.ServiceReference5.medianaRequest request) {
            return base.Channel.medianaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Aplikacja_na_projekt.ServiceReference5.medianaResponse> medianaAsync(Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr) {
            Aplikacja_na_projekt.ServiceReference5.medianaRequest inValue = new Aplikacja_na_projekt.ServiceReference5.medianaRequest();
            inValue.Body = new Aplikacja_na_projekt.ServiceReference5.medianaRequestBody();
            inValue.Body.arr = arr;
            return ((Aplikacja_na_projekt.ServiceReference5.WebService1Soap)(this)).medianaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Aplikacja_na_projekt.ServiceReference5.wariancjaResponse Aplikacja_na_projekt.ServiceReference5.WebService1Soap.wariancja(Aplikacja_na_projekt.ServiceReference5.wariancjaRequest request) {
            return base.Channel.wariancja(request);
        }
        
        public double wariancja(Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr) {
            Aplikacja_na_projekt.ServiceReference5.wariancjaRequest inValue = new Aplikacja_na_projekt.ServiceReference5.wariancjaRequest();
            inValue.Body = new Aplikacja_na_projekt.ServiceReference5.wariancjaRequestBody();
            inValue.Body.arr = arr;
            Aplikacja_na_projekt.ServiceReference5.wariancjaResponse retVal = ((Aplikacja_na_projekt.ServiceReference5.WebService1Soap)(this)).wariancja(inValue);
            return retVal.Body.wariancjaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Aplikacja_na_projekt.ServiceReference5.wariancjaResponse> Aplikacja_na_projekt.ServiceReference5.WebService1Soap.wariancjaAsync(Aplikacja_na_projekt.ServiceReference5.wariancjaRequest request) {
            return base.Channel.wariancjaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Aplikacja_na_projekt.ServiceReference5.wariancjaResponse> wariancjaAsync(Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr) {
            Aplikacja_na_projekt.ServiceReference5.wariancjaRequest inValue = new Aplikacja_na_projekt.ServiceReference5.wariancjaRequest();
            inValue.Body = new Aplikacja_na_projekt.ServiceReference5.wariancjaRequestBody();
            inValue.Body.arr = arr;
            return ((Aplikacja_na_projekt.ServiceReference5.WebService1Soap)(this)).wariancjaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Aplikacja_na_projekt.ServiceReference5.std_odchylenieResponse Aplikacja_na_projekt.ServiceReference5.WebService1Soap.std_odchylenie(Aplikacja_na_projekt.ServiceReference5.std_odchylenieRequest request) {
            return base.Channel.std_odchylenie(request);
        }
        
        public double std_odchylenie(Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr) {
            Aplikacja_na_projekt.ServiceReference5.std_odchylenieRequest inValue = new Aplikacja_na_projekt.ServiceReference5.std_odchylenieRequest();
            inValue.Body = new Aplikacja_na_projekt.ServiceReference5.std_odchylenieRequestBody();
            inValue.Body.arr = arr;
            Aplikacja_na_projekt.ServiceReference5.std_odchylenieResponse retVal = ((Aplikacja_na_projekt.ServiceReference5.WebService1Soap)(this)).std_odchylenie(inValue);
            return retVal.Body.std_odchylenieResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Aplikacja_na_projekt.ServiceReference5.std_odchylenieResponse> Aplikacja_na_projekt.ServiceReference5.WebService1Soap.std_odchylenieAsync(Aplikacja_na_projekt.ServiceReference5.std_odchylenieRequest request) {
            return base.Channel.std_odchylenieAsync(request);
        }
        
        public System.Threading.Tasks.Task<Aplikacja_na_projekt.ServiceReference5.std_odchylenieResponse> std_odchylenieAsync(Aplikacja_na_projekt.ServiceReference5.ArrayOfDouble arr) {
            Aplikacja_na_projekt.ServiceReference5.std_odchylenieRequest inValue = new Aplikacja_na_projekt.ServiceReference5.std_odchylenieRequest();
            inValue.Body = new Aplikacja_na_projekt.ServiceReference5.std_odchylenieRequestBody();
            inValue.Body.arr = arr;
            return ((Aplikacja_na_projekt.ServiceReference5.WebService1Soap)(this)).std_odchylenieAsync(inValue);
        }
    }
}
