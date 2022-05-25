<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="ReporteAnalista.aspx.cs" Inherits="ProySolicitudesWEB_GUI.Consultas.ReporteAnalista" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
        .auto-style2 {
            height: 29px;
        }
        .encabezados{
        text-align: center;
        color: #092749;
    }
    .principal {
        width: 90%;
        margin: 0 auto;
    }
    .auto-style2 {
        font-size: 25px;
        color: #092749;
    }
    .pag-centrado{
        width: 90%;
        margin: 20px auto;
    }
        .auto-style3 {
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pag-centrado">
    <h3 class="encabezados" style="font-size: 25px; font-weight: 700;">Reporte solicitudes atendidas por analista</h3>
    <table class="auto-style1">
        <tr>
            <td style="color: #092749; font-size: 30px; font-weight: 600">Seleccione analista a evaluar:</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="cboAnalista" runat="server" Width="343px" CssClass="btn btn-secondary dropdown-toggle">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="color: #092749">Filtro por estado de solicitud</td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="cboEstado" runat="server" Width="219px" CssClass="btn btn-secondary dropdown-toggle">
                    <asp:ListItem Selected="True" Value="1">Aprobada</asp:ListItem>
                    <asp:ListItem Value="2">En proceso</asp:ListItem>
                    <asp:ListItem Value="3">Rechazada</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" CssClass="btn btn-outline-dark" OnClick="btnBuscar_Click" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="color: #092749; font-size: 25px;">Codigo:</td>
            <td>
                <asp:TextBox ID="txtCod" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="color: #092749; font-size: 25px;">DNI:</td>
            <td>
                <asp:TextBox ID="txtDNI" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: #092749; font-size: 25px;">E-mail:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="color: #092749; font-size: 25px;">Fecha ingreso:</td>
            <td>
                <asp:TextBox ID="txtFecIng" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="color: #092749; font-size: 25px;">Agencia:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtAgencia" runat="server" ReadOnly="True" Height="24px"></asp:TextBox>
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td style="color: white; font-size: 30px; font-weight: 600">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="color: #092749">
                <asp:Label ID="lblInforme" runat="server"></asp:Label>
            </td>
            <td style="color: #092749">
                <asp:Label ID="lblCantReg" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblMensaje" runat="server" CssClass="alert-danger"></asp:Label>
            </td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
            <asp:GridView ID="grvSolicitud" runat="server" Width="1103px" AutoGenerateColumns="False" CssClass="table table-dark table-hover">
                <Columns>
                    <asp:BoundField DataField="Id_solicitud" HeaderText="Solicitud" ReadOnly="True" />
                    <asp:BoundField DataField="Nombre cliente" HeaderText="Cliente" ReadOnly="True" />
                    <asp:BoundField DataField="PRODUCTO" HeaderText="Producto" ReadOnly="True" />
                    <asp:BoundField DataField="Fec_solicitud" DataFormatString="{0:d}" HeaderText="Solicitado el..." ReadOnly="True">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Monto_solici" DataFormatString="{0:c}" HeaderText="Monto solicitado" ReadOnly="True">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Estado" HeaderText="Estado" ReadOnly="True" />
                    <asp:BoundField DataField="Cuotas" HeaderText="Cuotas" ReadOnly="True">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/MenuSolicitudes.aspx" BackColor="#092749" CssClass="btn btn-dark" Height="37px" Width="88px">Retornar</asp:HyperLink>
            </td>
        </tr>
    </table>
        </div>
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
