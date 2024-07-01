using System;
using System.Collections.Generic;



namespace BlazorApp.Shared.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            PuestoTrabajos = new HashSet<PuestoTrabajo>();
        }

        public int Id { get; set; }
        public string? NombreDearamento { get; set; }
        public int? IdEmpresa { get; set; }

        public virtual Empresa? IdEmpresaNavigation { get; set; }
        public virtual ICollection<PuestoTrabajo> PuestoTrabajos { get; set; }
    }
}
