﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetMvcLocalizedApp.Resources {
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
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AspNetMvcLocalizedApp.Resources.Strings", typeof(Strings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Localization Sample.
        /// </summary>
        public static string Common_AppName {
            get {
                return ResourceManager.GetString("Common_AppName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose language.
        /// </summary>
        public static string Common_ChooseLanguage {
            get {
                return ResourceManager.GetString("Common_ChooseLanguage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Submit.
        /// </summary>
        public static string Common_Submit {
            get {
                return ResourceManager.GetString("Common_Submit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Today is.
        /// </summary>
        public static string Common_TodayIs {
            get {
                return ResourceManager.GetString("Common_TodayIs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Age.
        /// </summary>
        public static string Person_Age {
            get {
                return ResourceManager.GetString("Person_Age", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First Name.
        /// </summary>
        public static string Person_FirstName {
            get {
                return ResourceManager.GetString("Person_FirstName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Last Name.
        /// </summary>
        public static string Person_LastName {
            get {
                return ResourceManager.GetString("Person_LastName", resourceCulture);
            }
        }
    }
}