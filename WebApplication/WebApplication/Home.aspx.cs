using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfService;

namespace WebApplication
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int idDepart = Int32.Parse(txtIdDepartamento.Text);
            int idEmpleado = Int32.Parse(txtIdEmpleado.Text);

            Service wcf = new Service();

            string fechaInicio = wcf.GetFechaInicioEmpleado(idDepart, idEmpleado);

            if (fechaInicio.Equals(""))
                lblFechaInicio.Text = "No se encontro el empleado";
            else
                lblFechaInicio.Text = fechaInicio;
        }
    }
}