﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaIT.SqlStatements {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SqlStatement {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlStatement() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PruebaIT.SqlStatements.SqlStatement", typeof(SqlStatement).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
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
        ///   Busca una cadena traducida similar a INSERT INTO [test] (&quot;Name&quot;) Values (@Name);.
        /// </summary>
        internal static string CreateTest {
            get {
                return ResourceManager.GetString("CreateTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a INSERT INTO Pacientes ([Name],[Date],[Email],[Gender],[Address],[Phone],[DateA]) VALUES (@Name,@Date,@Email,@Gender,@Address,@Phone,@DateA);.
        /// </summary>
        internal static string CreateUser {
            get {
                return ResourceManager.GetString("CreateUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Update [Test] SET Remove = 1 WHERE [Id] = @Id;.
        /// </summary>
        internal static string DeleteTest {
            get {
                return ResourceManager.GetString("DeleteTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Update Pacientes 
        ///SET [Remove] = 1 
        ///WHERE [Id] =  @id.
        /// </summary>
        internal static string DeleteUser {
            get {
                return ResourceManager.GetString("DeleteUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT * 
        ///FROM test 
        ///WHERE [Remove] = 0;.
        /// </summary>
        internal static string GetTest {
            get {
                return ResourceManager.GetString("GetTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a select * 
        ///from Pacientes
        ///WHERE [Remove] = 0.
        /// </summary>
        internal static string GetUser {
            get {
                return ResourceManager.GetString("GetUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a UPDATE [Test] 
        ///SET [Name] = @Name 
        ///WHERE [Id] = @Id;.
        /// </summary>
        internal static string UpdateTest {
            get {
                return ResourceManager.GetString("UpdateTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Update Pacientes 
        ///SET [Name] = @Name, [Date] = @Date,[Email] = @Email, [Gender] = @Gender, [Address] = @Address,[Phone] = @Phone, [DateA] = @DateA
        ///WHERE [Id] =  @Id;.
        /// </summary>
        internal static string UpdateUser {
            get {
                return ResourceManager.GetString("UpdateUser", resourceCulture);
            }
        }
    }
}
