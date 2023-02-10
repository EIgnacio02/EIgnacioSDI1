using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Empleado" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Empleado.svc o Empleado.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Empleado : IEmpleado
    {
        public SL_WCF.ResultWCF GetAll()
        {
            ML.Result result = BL.Empleado.GetAll();
            return new ResultWCF { Correct = result.Correct, Mensaje = result.Mensaje, Ex = result.Ex, ObjectList = result.ObjectList, Object = result.Object };
        }

        public SL_WCF.ResultWCF GetById(int IdEmpleado)
        {
            ML.Result result = BL.Empleado.GetById(IdEmpleado);
            return new ResultWCF { Correct = result.Correct, Mensaje = result.Mensaje, Ex = result.Ex, ObjectList = result.ObjectList, Object = result.Object };
        }

        public SL_WCF.ResultWCF Add(ML.Empleado empleado)
        {
            ML.Result result = BL.Empleado.Add(empleado);
            return new ResultWCF { Correct = result.Correct, Mensaje = result.Mensaje, Ex = result.Ex, ObjectList = result.ObjectList, Object = result.Object };
        }

        public SL_WCF.ResultWCF Update(ML.Empleado empleado)
        {
            ML.Result result = BL.Empleado.Update(empleado);
            return new ResultWCF { Correct = result.Correct, Mensaje = result.Mensaje, Ex = result.Ex, ObjectList = result.ObjectList, Object = result.Object };
        }

        public SL_WCF.ResultWCF Delete(int IdEmpleado)
        {
            ML.Result result = BL.Empleado.Delete(IdEmpleado);
            return new ResultWCF { Correct = result.Correct, Mensaje = result.Mensaje, Ex = result.Ex, ObjectList = result.ObjectList, Object = result.Object };
        }
    }
}
