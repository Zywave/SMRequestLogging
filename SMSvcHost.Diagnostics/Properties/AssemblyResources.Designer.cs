﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMSvcHost.Diagnostics.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AssemblyResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AssemblyResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SMSvcHost.Diagnostics.Properties.AssemblyResources", typeof(AssemblyResources).Assembly);
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
        ///   Looks up a localized string similar to Callstack={0}.
        /// </summary>
        internal static string CallstackTraceToken {
            get {
                return ResourceManager.GetString("CallstackTraceToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DateTime={0:o}.
        /// </summary>
        internal static string DateTimeTraceToken {
            get {
                return ResourceManager.GetString("DateTimeTraceToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid file path..
        /// </summary>
        internal static string InvalidTraceListenerFilePath {
            get {
                return ResourceManager.GetString("InvalidTraceListenerFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid trace format..
        /// </summary>
        internal static string InvalidTraceListenerTraceFormat {
            get {
                return ResourceManager.GetString("InvalidTraceListenerTraceFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LogicalOperationStack={0}.
        /// </summary>
        internal static string LogicalOperationStackTraceToken {
            get {
                return ResourceManager.GetString("LogicalOperationStackTraceToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ProcessId={0}.
        /// </summary>
        internal static string ProcessIdTraceToken {
            get {
                return ResourceManager.GetString("ProcessIdTraceToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ThreadId={0}.
        /// </summary>
        internal static string ThreadIdTraceToken {
            get {
                return ResourceManager.GetString("ThreadIdTraceToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timestamp={0}.
        /// </summary>
        internal static string TimestampTraceToken {
            get {
                return ResourceManager.GetString("TimestampTraceToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trace Listener Fail:.
        /// </summary>
        internal static string TraceListenerFailed {
            get {
                return ResourceManager.GetString("TraceListenerFailed", resourceCulture);
            }
        }
    }
}
