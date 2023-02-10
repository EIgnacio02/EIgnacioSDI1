using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEmpleado" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEmpleado
    {
        [OperationContract]
        [ServiceKnownType(typeof(ML.Empleado))]
        SL_WCF.ResultWCF GetAll();


        [OperationContract]
        [ServiceKnownType(typeof(ML.Empleado))]
        SL_WCF.ResultWCF GetById(int IdEmpleado);

        [OperationContract]
        SL_WCF.ResultWCF Add(ML.Empleado empleado);

        [OperationContract]
        SL_WCF.ResultWCF Update(ML.Empleado empleado);

        [OperationContract]
        SL_WCF.ResultWCF Delete(int IdEmpleado);
    }
}
