﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yort.Eftpos.Verifone.PosLink {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Yort.Eftpos.Verifone.PosLink.ErrorMessages", typeof(ErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cash out is not allowed when using manual PAN..
        /// </summary>
        internal static string CashOutNotAllowedWithManualPan {
            get {
                return ResourceManager.GetString("CashOutNotAllowedWithManualPan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to connect to pinpad..
        /// </summary>
        internal static string ConnectionFailed {
            get {
                return ResourceManager.GetString("ConnectionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An invalid protocol message was received from the network..
        /// </summary>
        internal static string InvalidProtocolMessage {
            get {
                return ResourceManager.GetString("InvalidProtocolMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The response &apos;{0}&apos; is not valid. Valid responses are; {1}.
        /// </summary>
        internal static string InvalidQueryResponse {
            get {
                return ResourceManager.GetString("InvalidQueryResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message does not end with ETX..
        /// </summary>
        internal static string MessageDoesNotEndWithEtx {
            get {
                return ResourceManager.GetString("MessageDoesNotEndWithEtx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message does not start with STX..
        /// </summary>
        internal static string MessageDoesNotStartWithStx {
            get {
                return ResourceManager.GetString("MessageDoesNotStartWithStx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message LRC is incorrect..
        /// </summary>
        internal static string MessageLrcInvalid {
            get {
                return ResourceManager.GetString("MessageLrcInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message type from the protocol does not match the type of message deserialised into..
        /// </summary>
        internal static string MessageTypeDoesNotMatch {
            get {
                return ResourceManager.GetString("MessageTypeDoesNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The device refused to accept the message..
        /// </summary>
        internal static string NackExceptionMessage {
            get {
                return ResourceManager.GetString("NackExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The system wanted to prompt the user for a response but no handlers were connected to the PinpadClient.QueryOperator event..
        /// </summary>
        internal static string NoHandlerForQueryOperatorConnected {
            get {
                return ResourceManager.GetString("NoHandlerForQueryOperatorConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No transaction is in progress..
        /// </summary>
        internal static string NoTransactionInProgress {
            get {
                return ResourceManager.GetString("NoTransactionInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one of PurchaseAmount or CashAmount must be greater than zero..
        /// </summary>
        internal static string PurchaseAmountOrCashAmountMustBeSpecified {
            get {
                return ResourceManager.GetString("PurchaseAmountOrCashAmountMustBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} does not contain a required public constructor (.ctor(IList&lt;string&gt;))..
        /// </summary>
        internal static string ResponseMessageTypeDoesNotContainRequiredConstructor {
            get {
                return ResourceManager.GetString("ResponseMessageTypeDoesNotContainRequiredConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Response property must be either YES or NO.
        /// </summary>
        internal static string ResponseMustBeYesOrNo {
            get {
                return ResourceManager.GetString("ResponseMustBeYesOrNo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream provided must be readable..
        /// </summary>
        internal static string StreamMustBeReadable {
            get {
                return ResourceManager.GetString("StreamMustBeReadable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream provided must be writeable..
        /// </summary>
        internal static string StreamMustBeWriteable {
            get {
                return ResourceManager.GetString("StreamMustBeWriteable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Terminal busy. Please wait....
        /// </summary>
        internal static string TerminalBusy {
            get {
                return ResourceManager.GetString("TerminalBusy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Communication with EFTPOS device has been interrupted. Check terminal for transaction result. EFTPOS APPROVED?.
        /// </summary>
        internal static string TransactionFailure {
            get {
                return ResourceManager.GetString("TransactionFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unexpected response was received from the pin pad. The request and response types and/or id&apos;s do not match..
        /// </summary>
        internal static string UnexpectedResponse {
            get {
                return ResourceManager.GetString("UnexpectedResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown or unsupported message field type..
        /// </summary>
        internal static string UnknownMessageFieldFormat {
            get {
                return ResourceManager.GetString("UnknownMessageFieldFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This value is required..
        /// </summary>
        internal static string ValueIsRequired {
            get {
                return ResourceManager.GetString("ValueIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The formatted value of {0} is too long..
        /// </summary>
        internal static string ValueIsTooLong {
            get {
                return ResourceManager.GetString("ValueIsTooLong", resourceCulture);
            }
        }
    }
}
