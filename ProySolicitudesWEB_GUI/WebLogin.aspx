<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebLogin.aspx.cs" Inherits="SitioVentasWEB_GUI.WebLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/bootstrap.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 44%;
        }
        .auto-style2 {
            width: 233px;
        }
        .auto-style3 {
            height: 17px;
        }
        .auto-style4 {
            color: #FF0000;
        }
        .auto-style7 {
            color: #092749;
            text-align: left;
            font-family: Verdana;
            font-size: 12pt;
            font-weight: bold;
        }
    </style>
</head>
<body style="background:#f3f4ee;">
    <form id="form1" runat="server">
    <div>
        <table class="auto-style1" align="center" style="border-style:solid; border-width:3px; background-color:white; margin-top: 50px">
            <tr>
                <td class="auto-style2" rowspan="8" style="padding:5px">
                    <asp:Image ID="Image1" runat="server" Height="235px" Width="231px" ImageUrl="~/Images/InicioSesion.jpg" />
                </td>
                <td class="auto-style7" colspan="2">
                    Inicio de Sesión Caja Crédito Perú</td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="labelContenido" style="color: #092749">Ingrese Usuario</td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server" Height="23px" Width="156px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="labelContenido" style="color: #092749">Ingrese Password</td>
                <td>
                    <asp:TextBox ID="txtPass" runat="server" Height="23px" Width="156px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnIniciar" runat="server" Height="30px" Text="Iniciar Sesión" Width="166px" CssClass="btn btn-dark" OnClick="btnRegistrar_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="10pt" CssClass="alert-danger"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
