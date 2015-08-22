<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="WebApplication.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <title>Laboratorio 2</title>
    <link rel="stylesheet" type="text/css" href="Styles\Style.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <header>
            <strong>Laboratorio 2</strong>
    </header>

        <div style="height: 369px">



            <asp:Label ID="lblDepartamento" runat="server" Text="ID Departamento:"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtIdDepartamento" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEmpleado" runat="server" Text="ID Empleado:"></asp:Label>



        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtIdEmpleado" runat="server"></asp:TextBox>



            <br />
            <br />

            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Fecha de inicio en el departamento:"></asp:Label>
&nbsp;<asp:Label ID="lblFechaInicio" runat="server"></asp:Label>



        </div>




    </form>
</body>
</html>

