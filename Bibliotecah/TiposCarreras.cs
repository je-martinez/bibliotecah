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
    
    public partial class TiposCarreras
    {
        public TiposCarreras()
        {
            this.Carreras = new HashSet<Carreras>();
        }
    
        public int PkID_TipoCarrera { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Carreras> Carreras { get; set; }
    }
}
