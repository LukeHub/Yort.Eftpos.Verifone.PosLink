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
    using System.Reflection;
    
    
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
    internal class LogMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LogMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Yort.Eftpos.Verifone.PosLink.LogMessages", typeof(LogMessages).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Display Message ({0}): {1}.
        /// </summary>
        internal static string DisplayMessage {
            get {
                return ResourceManager.GetString("DisplayMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred raising the DisplayMessage event..
        /// </summary>
        internal static string ErrorInDisplayMessageEvent {
            get {
                return ResourceManager.GetString("ErrorInDisplayMessageEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error receiving message:.
        /// </summary>
        internal static string ErrorReceivingMessage {
            get {
                return ResourceManager.GetString("ErrorReceivingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error sending message:.
        /// </summary>
        internal static string ErrorSendingMessage {
            get {
                return ResourceManager.GetString("ErrorSendingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No response from device, will report as busy..
        /// </summary>
        internal static string NoResponseFromDevice {
            get {
                return ResourceManager.GetString("NoResponseFromDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process Request {0}: {1}.
        /// </summary>
        internal static string ProcessRequest {
            get {
                return ResourceManager.GetString("ProcessRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query Operator ({0}): {1}\r\n{2}\r\n{3}\r\n{4}.
        /// </summary>
        internal static string QueryOperator {
            get {
                return ResourceManager.GetString("QueryOperator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query Operator Response ({0}): {1}.
        /// </summary>
        internal static string QueryOperatorResponse {
            get {
                return ResourceManager.GetString("QueryOperatorResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received ACK.
        /// </summary>
        internal static string ReceivedAck {
            get {
                return ResourceManager.GetString("ReceivedAck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received an invalid packet:.
        /// </summary>
        internal static string ReceivedInvalidMessage {
            get {
                return ResourceManager.GetString("ReceivedInvalidMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received NACK.
        /// </summary>
        internal static string ReceivedNack {
            get {
                return ResourceManager.GetString("ReceivedNack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received packet.
        /// </summary>
        internal static string ReceivedPacket {
            get {
                return ResourceManager.GetString("ReceivedPacket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending packet.
        /// </summary>
        internal static string SendingPacket {
            get {
                return ResourceManager.GetString("SendingPacket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending request: {0} {1}.
        /// </summary>
        internal static string SendingRequest {
            get {
                return ResourceManager.GetString("SendingRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown message type of &apos;{0}&apos; received..
        /// </summary>
        internal static string UnknownMessageTypeReceived {
            get {
                return ResourceManager.GetString("UnknownMessageTypeReceived", resourceCulture);
            }
        }
    }
}
