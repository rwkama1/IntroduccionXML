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

using System.Xml;

public partial class AgregarAlumnosXml : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        try
        {

            XmlDocument oDocumento = new XmlDocument();
            oDocumento.Load(Server.MapPath("AcademiaYAlumnos.xml"));
            //carga en memoria RAM todo el documento XML
            //Server.MapPath dado el nombre de un archivo retorna la 
            //ubicacion completa del archivo

            XmlNode oRaiz = oDocumento.DocumentElement;
            //obetener el nodo raiz donde se va a agrgar el nuevo "alumno"

            //Crea Cargar y Agregar al padre cada elemento secundario o atributo
            XmlElement oAlumno = oDocumento.CreateElement("alumno");
            //genera un atributo dentro del elemento alumno
            //dentro del objeto de la clase XmlElement
            XmlAttribute oNro = oDocumento.CreateAttribute("nro");
            oNro.Value = txtNro.Text;
            oAlumno.Attributes.Append(oNro);

            XmlAttribute oTipo = oDocumento.CreateAttribute("tipo");
            oTipo.Value = txtTipo.Text;
            oAlumno.Attributes.Append(oTipo);



            XmlElement oNombre = oDocumento.CreateElement("nombre");
            oNombre.InnerText = txtNombre.Text;
            oAlumno.AppendChild(oNombre);

            XmlElement oTel = oDocumento.CreateElement("tel");
            oTel.InnerText = txtTelefono.Text;
            oAlumno.AppendChild(oTel); 


            oRaiz.AppendChild(oAlumno);


            oDocumento.Save(Server.MapPath("AcademiaYAlumnos.xml"));

        }
        catch
        {
            lblMensaje.Text = "No se puede agregar el alumno, intente más tarde";
        }
    }
}
