using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        // TODO: Add your service operations here
        [OperationContract]
        string GetFechaInicioEmpleado(int idDepartamento, int idEmpleado);

        [DataContract]
        public class HistorialEmpleado
        {
            int idDepartamento = 0;
            int idEmpleado = 0;
            DateTime fechaInicio = new DateTime(0000, 0, 0, 0, 00, 00);


            [DataMember]
            public int idDepartamentos
            {
                get { return idDepartamento; }
                set { idDepartamento = value; }
            }

            [DataMember]
            public int idEmpleados
            {
                get { return idEmpleado; }
                set { idEmpleado = value; }
            }

            [DataMember]
            public DateTime FechaInicio
            {
                get { return fechaInicio; }
                set { fechaInicio = value; }
            }

        }

    }
}
