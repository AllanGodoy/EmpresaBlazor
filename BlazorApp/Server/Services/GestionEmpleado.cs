using BlazorApp.Shared.Models;
using BlazorApp.Server.Modelos;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Services
{
    public class GestionEmpleado : IEmpleado
    {
        readonly EmpresaContext dbContext = new();

        public GestionEmpleado(EmpresaContext db)
        {

            dbContext = db;
        }
        public void ActualizarEmpleado(Empleado u)
        {
            try
            {
                dbContext.Entry(u).State =EntityState.Modified;
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void BorrarEmpleado(int Id)
        {
            try {
                Empleado? u = dbContext.Empleados.Find(Id);
                if (u != null) { 
                    dbContext.Empleados.Remove(u);
                    dbContext.SaveChanges();
                }
                else {
                    throw new ArgumentNullException();
                }

            }
            catch (Exception ex) { throw new Exception(ex.ToString()); }
            //throw new NotImplementedException();
        }

        public List<Empleado> ListaEmpleado()
        {
            try { return dbContext.Empleados.ToList(); }

            catch (Exception ex) { throw new Exception(ex.ToString()); }

        }

        public Empleado DatosEmpleado(int Id)
        {
            try {
                Empleado? u = dbContext.Empleados.Find(Id);
                if (u != null) {
                    return u;
                }
                else { throw new ArgumentException(); }             
            
            }

            catch (Exception ex) { throw new Exception(ex.ToString()); }
        }

        public void NuevosEmpleados(Empleado u)
        {
            try { 
                
                u.FechaAlta = DateTime.Now;            
                dbContext.Empleados.Add(u);
                dbContext.SaveChanges();
            }

            catch (Exception ex) { throw new Exception(ex.ToString()); }
        }
    }
}
