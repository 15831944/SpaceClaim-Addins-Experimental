﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpaceClaim.AddIn.Tracker.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SpaceClaim.AddIn.Tracker.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Draw the calibration points and camera locations..
        /// </summary>
        internal static string GetEnvironmentCommandHint {
            get {
                return ResourceManager.GetString("GetEnvironmentCommandHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Environment.
        /// </summary>
        internal static string GetEnvironmentCommandText {
            get {
                return ResourceManager.GetString("GetEnvironmentCommandText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Draw ray from the last sampled blob..
        /// </summary>
        internal static string GetRayCommandHint {
            get {
                return ResourceManager.GetString("GetRayCommandHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sample Ray.
        /// </summary>
        internal static string GetRayCommandText {
            get {
                return ResourceManager.GetString("GetRayCommandText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Launch the point tracker..
        /// </summary>
        internal static string LaunchCommandHint {
            get {
                return ResourceManager.GetString("LaunchCommandHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Launch.
        /// </summary>
        internal static string LaunchCommandText {
            get {
                return ResourceManager.GetString("LaunchCommandText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tracker.
        /// </summary>
        internal static string TrackerGroupText {
            get {
                return ResourceManager.GetString("TrackerGroupText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tracker.
        /// </summary>
        internal static string TrackerText {
            get {
                return ResourceManager.GetString("TrackerText", resourceCulture);
            }
        }
    }
}
