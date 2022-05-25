<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="RankingAnalista.aspx.cs" Inherits="ProySolicitudesWEB_GUI.Consultas.RankingAnalista" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
        .auto-style2 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Top Operaciones Analistas</h3>
    <table class="auto-style1">
        <tr>
            <td>Estado de la solicitud:</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="192px">
                    <asp:ListItem Selected="True" Value="3">Aprobadas</asp:ListItem>
                    <asp:ListItem Value="2">En proceso</asp:ListItem>
                    <asp:ListItem Value="1">Rechazadas</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Los&nbsp;
                <asp:TextBox ID="txtTop" runat="server" Width="100px"></asp:TextBox>
&nbsp;analistas con mas solicitudes registradas</td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="rfvVali" runat="server" ControlToValidate="txtTop" CssClass="labelErrores" ErrorMessage="*Necesario"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtTop" CssClass="labelErrores" ErrorMessage="*Min 0 max 10" MaximumValue="10" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="grvTopSolicitud" runat="server" Width="900px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MenuSolicitudes.aspx">Retornar</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <%--Este es el modal popup que contiene los mensajes --%>

        <%--1 Control target (cualquier control)--%>

       <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>

         <%--2 el panel que se mostrara en el popup--%>

       <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="300"> 

          <table border="0" width="300px" style="margin: 0px; padding: 0px; background-color:darkred ; 

            color: #FFFFFF;"> 

            <tr> 

              <td align="center"> 

                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 

              </td> 

              <td width="12%"> 

                <asp:ImageButton ID="btnCerrar" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 

                  ImageAlign="Right" /> 

              </td> 

            </tr> 

             

          </table> 

          <div> 

            <asp:Label ID="Label1" runat="server" Text="" ForeColor ="Black" /> 

          </div> 

          <div> 

            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" /> 

          </div> 

        </asp:Panel> 

     <%--3 el Modal popup que hace referencia al control target (1) y al panel (2)--%>
        <ajaxToolkit:ModalPopupExtender ID="mpeMensaje" runat="server" TargetControlID="lnkMensaje" 

          PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion" OkControlID="btnAceptar" />
</asp:Content>
