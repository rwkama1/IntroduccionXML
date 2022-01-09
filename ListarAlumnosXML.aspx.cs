using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class ListarAlumnosXML : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet oConjunto = new DataSet();
        try
        {
            oConjunto.ReadXml(Server.MapPath("AcademiaYAlumnos.xml"));
            //Server.MapPath dado el nombre de un archivo retorna su ruta
           //dentro del sitio web
            //Cargando el documento XML en el DataSet

            grdAlumnos.DataSource = oConjunto;
            grdAlumnos.DataBind();
        }
        catch
        {
            lblMensaje.Text = "No se encuentra el archivo de academia";
        }

    }
}
