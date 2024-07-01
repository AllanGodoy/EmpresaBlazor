using System;
using System.Collections.Generic;



namespace BlazorApp.Shared.Models
{
    public partial class PuestoTrabajo
    {
        public PuestoTrabajo()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        public string? NombrePuesto { get; set; }
        public int? IdDepartamento { get; set; }

        public virtual Departamento? IdDepartamentoNavigation { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
