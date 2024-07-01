using System;
using System.Collections.Generic;



namespace BlazorApp.Shared.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            Departamentos = new HashSet<Departamento>();
        }

        public int Id { get; set; }
        public string? NombreEmpresa { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Rtn { get; set; }
        public string? Observacion { get; set; }

        public virtual ICollection<Departamento> Departamentos { get; set; }
    }
}
