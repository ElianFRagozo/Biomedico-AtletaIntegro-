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
    
    public partial class SeguimientoNutricion
    {
        public int IdSeguimientoNutricion { get; set; }
        public string HumeroNutri { get; set; }
        public string MuñecaHumeroNutri { get; set; }
        public string FermorHumeroNutri { get; set; }
        public string ImcNutri { get; set; }
        public string GrasaNutri { get; set; }
        public string MusculosNutri { get; set; }
        public string HuesosNutri { get; set; }
        public string ResidualesNutri { get; set; }
        public string PesosGrasosNutri { get; set; }
        public string PesosMusculosNutri { get; set; }
        public string PesoResiducalesNutri { get; set; }
        public string DiagnosticoNutri { get; set; }
        public string TratamientoNutri { get; set; }
        public string ObservacionesNutricion { get; set; }
        public Nullable<System.DateTime> ProximaCitaNutri { get; set; }
        public string FirmaDoctorNutri { get; set; }
        public Nullable<int> IdNutricion { get; set; }
        public Nullable<int> IdMedicina { get; set; }
    
        public virtual Nutricion Nutricion { get; set; } = new Nutricion();
    }
}