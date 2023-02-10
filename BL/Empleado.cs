using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Empleado
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.EIgnacioSDIEntities context= new DL.EIgnacioSDIEntities())
                {
                    var query = context.GetAll().ToList();
                    result.ObjectList = new List<object>();

                    if (query!= null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Empleado empleado = new ML.Empleado();

                            empleado.IdEmpleado = obj.IdEmpleado;
                            empleado.Nombre = obj.Nombre;
                            empleado.ApellidoPaterno = obj.ApellidoPaterno;
                            empleado.ApellidoMaterno = obj.ApellidoMaterno;
                            empleado.Edad = (int)obj.Edad;
                            empleado.Fecha = (DateTime)obj.Fecha;

                            result.ObjectList.Add(empleado);
                        }
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return result;
        }

        public static ML.Result GetById(int IdEmpleado)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.EIgnacioSDIEntities context= new DL.EIgnacioSDIEntities())
                {
                    var query = context.EmpleadoGetById(IdEmpleado).FirstOrDefault();
                    result.ObjectList = new List<object>();

                    if (query!=null)
                    {
                        ML.Empleado empleado = new ML.Empleado();

                        empleado.IdEmpleado = query.IdEmpleado;
                        empleado.Nombre = query.Nombre;
                        empleado.ApellidoPaterno = query.ApellidoPaterno;
                        empleado.ApellidoMaterno = query.ApellidoMaterno;
                        empleado.Edad = (int)query.Edad;
                        empleado.Fecha = (DateTime)query.Fecha;

                        result.Object = empleado;
                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {

                throw;
            }

            return result;
        }

        public static ML.Result Add(ML.Empleado empleado)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.EIgnacioSDIEntities context = new DL.EIgnacioSDIEntities())
                {
                    var query = context.EmpleadoAdd(empleado.Nombre,empleado.ApellidoPaterno,empleado.ApellidoMaterno,empleado.Edad,empleado.Fecha);

                    if (query>0)
                    {
                        result.Mensaje = "Se registraron correctamente los datos";
                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                throw;
            }

            return result;
        }

        public static ML.Result Update(ML.Empleado empleado)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.EIgnacioSDIEntities context= new DL.EIgnacioSDIEntities())
                {
                    var query = context.EmpleadoUpdate(empleado.IdEmpleado,empleado.Nombre,empleado.ApellidoPaterno,empleado.ApellidoMaterno,empleado.Edad,empleado.Fecha);

                    if (query>0)
                    {
                        result.Mensaje = "Se actualizaron los datos correctamnete";
                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {

                throw;
            }

            return result;
        }

        public static ML.Result Delete(int IdEmpleado)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.EIgnacioSDIEntities context= new DL.EIgnacioSDIEntities())
                {
                    var query = context.EmpleadoDelete(IdEmpleado);

                    if (query>0)
                    {
                        result.Mensaje = "Se eliminaron los datos";
                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {

                throw;
            }

            return result;
        }
    }
}
