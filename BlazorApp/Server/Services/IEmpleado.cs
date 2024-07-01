using BlazorApp.Shared.Models;

namespace BlazorApp.Server.Services
{
    public interface IEmpleado
    {
        public List<Empleado> ListaEmpleado();

        public void NuevosEmpleados(Empleado u);

        public void ActualizarEmpleado(Empleado u);

        public Empleado DatosEmpleado(int u);

        public void BorrarEmpleado(int u);

    }
}
