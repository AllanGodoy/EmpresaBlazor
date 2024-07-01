using BlazorApp.Shared.Models;
using BlazorApp.Server.Services;
using BlazorApp.Server.Modelos;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorApp.Client.Pages;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleado iEmpleado;

        public EmpleadoController(IEmpleado emp)
        {
            iEmpleado = emp;
        }

        [HttpGet]
        public async Task<List<Empleado>> ListaEmpleado()
        {
            return await Task.FromResult(iEmpleado.ListaEmpleado());
        }

        [HttpPost]
        public void post(Empleado empleado) {
            iEmpleado.NuevosEmpleados(empleado);
        
        }


        [HttpGet("{Id}")]
        public IActionResult GetEmpleado(int Id) {
            Empleado u = iEmpleado.DatosEmpleado(Id);
            if (u != null) {
                 return Ok(u);
              }
              return NotFound();
        }

        [HttpPut]
        public void Modificar(Empleado empleado) {

            iEmpleado.ActualizarEmpleado(empleado);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id) {
            iEmpleado.BorrarEmpleado(Id);
            return Ok();
        }

    }


}
