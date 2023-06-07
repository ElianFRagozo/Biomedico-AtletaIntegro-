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
    
    public partial class EncuestaFamiliar
    {
        public int IdEncuestaFamiliar { get; set; }
        public string TrabajaPersonaVives { get; set; }
        public string CuantoGanaPersona { get; set; }
        public string Problemaspersonasvives { get; set; }
        public string ProblemasMiembroFamilia { get; set; }
        public string FamiliarDiscapacidad { get; set; }
        public string PersonasAgresivas { get; set; }
        public string FamiliaresAncianos { get; set; }
        public string FamiliaresGestacion { get; set; }
        public string FamiliaresDeportistas { get; set; }
        public string TienesDiscapacidad { get; set; }
        public string TienesAyudaTecnica { get; set; }
        public string Bullying { get; set; }
        public string OrientacionSexual { get; set; }
        public string TienesPareja { get; set; }
        public string BullyingOrientacionSexual { get; set; }
        public string HasTenidoDepresion { get; set; }
        public string SalidasFiestas { get; set; }
        public string BebesAlcohol { get; set; }
        public string SustanciasPsicoactivas { get; set; }
        public string FamiliaresPsicoactivas { get; set; }
        public string SufresDepresion { get; set; }
        public string TienesVacunaCovid19 { get; set; }
        public string EpisodiosTrastornales { get; set; }
        public string CualesEpisodios { get; set; }
        public string VaPsicologo { get; set; }
        public string Estudias { get; set; }
        public string CualEstudio { get; set; }
        public string Semestre { get; set; }
        public string Grado { get; set; }
        public string CualGrado { get; set; }
        public string QueEstudias { get; set; }
        public string QueteGustariaEstudiar { get; set; }
        public string ComidasDiarias { get; set; }
        public string DuermesDiario { get; set; }
        public string Verduras { get; set; }
        public string Frutas { get; set; }
        public string Cocina { get; set; }
        public string MejorAmigos { get; set; }
        public string SufresAlergias { get; set; }
        public string SufresEnfermedad { get; set; }
        public string TratamientoEnfermedad { get; set; }
        public string TransporteEntrenos { get; set; }
        public string TiempoSitioEntreno { get; set; }
        public string CuantasVecesMovilizacion { get; set; }
        public string ParquesEntrenar { get; set; }
        public Nullable<int> IdEncuestaDeportista { get; set; }
    
        public virtual EncuestaDeportistas EncuestaDeportistas { get; set; }
    }
}