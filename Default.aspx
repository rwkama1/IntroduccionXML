<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <asp:Label ID="lblNombreEmpresa" runat="server" Font-Size="XX-Large"></asp:Label><br />
        <br />
        <a href="AgregarAlumnosXml.aspx">Agregar Alumnos Xml</a><br />
        <a href="ListarAlumnosXML.aspx">Listar Alumnos Xml</a><br />
        </div>
    </form>
</body>
</html>
