using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DBApp;

namespace WcfService
{
    
    public class Service : IService
    {
        public string GetFechaInicioEmpleado(int idDepartamento, int idEmpleado)
        {
            DBControl db = new DBControl();

            bool esFechaInicio = db.VerificarEmpleadoDepart(idDepartamento, idEmpleado);
            string fechaInicio = "";
            if (esFechaInicio)
            {
                fechaInicio = db.obtenerfechaInicio(idDepartamento, idEmpleado);
            }

            return fechaInicio; ;

        }
    }
}
