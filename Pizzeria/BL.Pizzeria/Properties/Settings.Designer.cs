﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BL.Pizzeria.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MIBASEDEDATOSL3_6PM_4eeeafa6ad" +
            "3d47b08637f35dc54e3c43;Integrated Security=True;Connect Timeout=30;Encrypt=False" +
            ";TrustServerCertificate=True")]
        public string MIBASEDEDATOSL3_6PM_4eeeafa6ad3d47b08637f35dc54e3c43ConnectionString {
            get {
                return ((string)(this["MIBASEDEDATOSL3_6PM_4eeeafa6ad3d47b08637f35dc54e3c43ConnectionString"]));
            }
        }
    }
}
