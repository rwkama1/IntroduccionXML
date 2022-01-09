<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgregarAlumnosXml.aspx.cs" Inherits="AgregarAlumnosXml" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body bgcolor="#ccccff">
    <form id="form1" runat="server">
    <div>
        <h1>
            Agregar Alumnos</h1>
        <br />
        <br />
        <table>
            <tr>
                <td>
                </td>
                <td>
                    Nro</td>
                <td>
                    <asp:TextBox ID="txtNro" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    Tipo de Documento</td>
                <td>
                    <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    Nombre</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    Telefono</td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                    <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" /></td>
            </tr>
        </table>
    
    </div>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label><br />
        <a href="Default.aspx">Default</a>
        <br />
        <br />
    </form>
</body>
</html>
