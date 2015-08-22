using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBApp
{
    public class DBControl
    {



        public bool VerificarEmpleadoDepart(int idDepartamento, int idEmpleado)
        {
            bool esEmpleado = false;
            bool esDepartamento = false;
            bool es = false;

            using (var db = new Laboratorio2Entities())
            {

                if (db.Department.Find(idDepartamento) != null)
                {
                    esDepartamento = true;
                }

                if (db.Employee.Find(idEmpleado) != null)
                {
                    esEmpleado = true;
                }

                if (esEmpleado.Equals(esDepartamento))
                    es = true;
            }
            return es;
        }

        public string obtenerfechaInicio(int idDepartamento, int idEmpleado)
        {
            string fechaInicio = "";

            using (var db = new Laboratorio2Entities())
            {

                if (db.EmployeeDepartmentHistory.Find(idDepartamento).DepartmentID > 0 && db.EmployeeDepartmentHistory.Find(idEmpleado).BusinessEntityID > 0)
                {
                    fechaInicio = db.EmployeeDepartmentHistory.Find(idEmpleado).StartDate.ToString();

                }
            }
            return fechaInicio;
        }


    }
}
