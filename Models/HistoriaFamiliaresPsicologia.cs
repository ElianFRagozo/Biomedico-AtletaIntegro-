//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BIOMEDICO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoriaFamiliaresPsicologia
    {
        public int IdHistoriaPsicologia { get; set; }
        public string NombrePadre { get; set; }
        public string EdadPadre { get; set; }
        public string RelacionPadre { get; set; }
        public string NombreMAdre { get; set; }
        public string EdadMadre { get; set; }
        public string RelacionMadre { get; set; }
        public string RelacionHermanos { get; set; }
        public Nullable<int> IdDatosDemograficos { get; set; }
    
        public virtual DemograficoPsicologia DemograficoPsicologia { get; set; } = new DemograficoPsicologia();
    }
}
