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
    
    public partial class Fisioterapia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fisioterapia()
        {
            this.AntecedentesFisioterapia = new HashSet<AntecedentesFisioterapia>();
            this.EvaluacionFisioterapia = new HashSet<EvaluacionFisioterapia>();
            this.Evolucionfisioterapia = new HashSet<Evolucionfisioterapia>();
            this.HistoriaClinicaFisioterapia = new HashSet<HistoriaClinicaFisioterapia>();
        }
    
        public int IdFisioterapia { get; set; }
        public Nullable<System.DateTime> FechaFisioter { get; set; }
        public string CodFisioterapi { get; set; }
        public string ReportaLesion { get; set; }
        public string CualLesion { get; set; }
        public string LesionActual { get; set; }
        public string AntecedentesLesion { get; set; }
        public string NumeroReLesiones { get; set; }
        public string TratamientoLesion { get; set; }
        public string HuesoLesion { get; set; }
        public string LigamentoLesion { get; set; }
        public string TendonLesion { get; set; }
        public string MusculoLesion { get; set; }
        public string CabezaLesion { get; set; }
        public string ColumnaLesion { get; set; }
        public string HombroLesion { get; set; }
        public string CodoLesion { get; set; }
        public string MuñecamanoLesion { get; set; }
        public string CaderaLesion { get; set; }
        public string RodillaLesion { get; set; }
        public string CuelloPieLesion { get; set; }
        public string AnexosFisioterapia { get; set; }
        public Nullable<long> NumIdentificacion { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public Nullable<int> IdCitaMedica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AntecedentesFisioterapia> AntecedentesFisioterapia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvaluacionFisioterapia> EvaluacionFisioterapia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evolucionfisioterapia> Evolucionfisioterapia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoriaClinicaFisioterapia> HistoriaClinicaFisioterapia { get; set; }
    }
}
