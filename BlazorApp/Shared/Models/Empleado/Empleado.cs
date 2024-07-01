using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace BlazorApp.Shared.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* Obligatorio")]
        public string? Nombres { get; set; }
        [Required(ErrorMessage = "* Obligatorio")]
        public string? Apellidos { get; set; }        
        public DateTime? FechaNacimiento { get; set; }
        public string? Direccion { get; set; }
       
        public string? Telefono { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public decimal? Sueldo { get; set; }
        public int? IdPuestoTrabajo { get; set; }

        public virtual PuestoTrabajo? IdPuestoTrabajoNavigation { get; set; }
    }
}
