//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bibliotecah
{
    using System;
    using System.Collections.Generic;
    
    public partial class Carreras
    {
        public Carreras()
        {
            this.Archivos = new HashSet<Archivos>();
        }
    
        public int PkID_Carrera { get; set; }
        public int FkID_TipoCarrera { get; set; }
        public string Carrera { get; set; }
    
        public virtual ICollection<Archivos> Archivos { get; set; }
        public virtual TiposCarreras TiposCarreras { get; set; }
    }
}