<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebLogout.aspx.cs" Inherits="SitioVentasWEB_GUI.WebLogout" %>

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
        .auto-style7 {
            color: #FF0000;
            text-align: center;
        }
    </style>
</head>
<body style="background:#f3f4ee;">
    <form id="form1" runat="server">
    <div>
        <table class="auto-style1" align="center" style="border-style:solid; border-width:3px; background-color:white; margin-top: 50px">
            <tr>
                <td class="auto-style2" rowspan="3">
                    <asp:Image ID="Image1" runat="server" Height="235px" Width="231px" ImageUrl="~/Images/Logout.jpg" />
                </td>
                <td class="auto-style7" colspan="2">
    <span style="text-align: left; color: #092749;" class="tituloForm">GRACIAS...VUELVA PRONTO</span></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="center">
                    <asp:Button ID="btnFinSesion" runat="server" Height="30px" Text="Fin de sesion" Width="166px" CssClass="btn btn-dark" OnClick="btnFinSesion_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Red" CssClass="alert-warning"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

