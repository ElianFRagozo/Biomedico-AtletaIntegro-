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
    
    public partial class AgendarCitas
    {
        public int IdAgendarCitas { get; set; }
        public string CedEspecialistaCitas { get; set; }
        public string NombrEspecilistaCitas { get; set; }
        public string NotificacionCampoCitas { get; set; }
        public Nullable<System.DateTime> HoraIniciocitas { get; set; }
        public Nullable<System.DateTime> HoraFinCitas { get; set; }
        public Nullable<System.DateTime> FechaCitas { get; set; }
        public string ObservacionesCitasMedicas { get; set; }
    }
}
