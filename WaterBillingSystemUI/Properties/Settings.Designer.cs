﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WaterBillingSystemUI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MPDC\\SQLEXPRESS;Initial Catalog=WaterBillingSystem;Integrated Securit" +
            "y=True")]
        public string WaterBillingSystemConnectionString {
            get {
                return ((string)(this["WaterBillingSystemConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=CHIANTINE-PC\\SQLEXPRESS;Initial Catalog=WaterBillingSystem;Integrated" +
            " Security=True")]
        public string WaterBillingSystemConnectionString1 {
            get {
                return ((string)(this["WaterBillingSystemConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ENGINEERING\\SQLEXPRESS;Initial Catalog=WaterBillingSystem;Integrated " +
            "Security=True")]
        public string WaterBillingSystemConnectionString2 {
            get {
                return ((string)(this["WaterBillingSystemConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=CHIANTINE-PC\\XCHANMOLX;Initial Catalog=WaterBillingSystem;Integrated " +
            "Security=True")]
        public string WaterBillingSystemConnectionString3 {
            get {
                return ((string)(this["WaterBillingSystemConnectionString3"]));
            }
        }
    }
}
