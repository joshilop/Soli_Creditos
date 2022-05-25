<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Pagos.aspx.cs" Inherits="ProySolicitudesWEB_GUI.Consultas.Pagos" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        /*.auto-style2 {
            width: 123px;
        }*/
         .encabezados{
        text-align: center;
        color: #092749;
    }
    .principal {
        width: 90%;
        margin: 0 auto;
    }
    .pag-centrado{
        max-width: 90%;
        margin: 20px auto;
    }
        /*.auto-style6 {
            width: 268434768px;
        }*/
        th{
            width: 100px;
            word-wrap: break-word;
        }
        .auto-style6 {
            width: 80%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="encabezados" style="font-size: 25px; font-weight: 700;">Consulta de pagos</h3>
    <table class="auto-style6" align="center">
        <tr>
            <td style="color: #092749; font-size: 25px;">Codigo de solicitud a consultar:</td>
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
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" Width="134px" CssClass="btn btn-outline-dark" />
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtId" CssClass="alert-danger" ErrorMessage="*El codigo debe empezar por S y tener 6 caracteres" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="color: #092749; font-size: 20px;">Nombre:</td>
            <td>
                <asp:TextBox ID="txtNom" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="color: #092749; font-size: 20px;">Apellido:</td>
            <td>
                <asp:TextBox ID="txtApell" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: #092749; font-size: 20px;">Codigo cliente:</td>
            <td>
                <asp:TextBox ID="txtCod" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="color: #092749; font-size: 20px;">DNI:</td>
            <td>
                <asp:TextBox ID="txtxDNI" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: #092749; font-size: 20px;">RUC:</td>
            <td>
                <asp:TextBox ID="txtRUC" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="color: #092749; font-size: 20px;">Correo:</td>
            <td>
                <asp:TextBox ID="txtCorreo" runat="server" ReadOnly="True" Width="237px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: #092749; font-size: 20px;">Estado civil:</td>
            <td>
                <asp:TextBox ID="txtEstCiv" runat="server" ReadOnly="True"></asp:TextBox>
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
            <td style="color: #092749">
                <asp:Label ID="lblInfoCant" runat="server"></asp:Label>
            </td>
            <td style="color: #092749">
                <asp:Label ID="lblNumCant" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMensaje" runat="server" CssClass="alert-danger"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="color: #092749">
                <asp:Label ID="lblReporte" runat="server"></asp:Label>
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
            <td colspan="4">
                <asp:GridView ID="grvPagos" runat="server" AutoGenerateColumns="False" Width="1323px" CssClass="table table-dark table-hover" ShowHeaderWhenEmpty="True">
                    <Columns>
                        <asp:BoundField DataField="Id_cli" HeaderText="Cliente" ReadOnly="True" />
                        <asp:BoundField DataField="Boleta" HeaderText="Boleta" ReadOnly="True" />
                        <asp:BoundField DataField="Id_solicitud" HeaderText="Solicitud" ReadOnly="True" />
                        <asp:BoundField DataField="Cuotas" HeaderText="Cuotas totales" ReadOnly="True">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Cuota_numero" HeaderText="N. Cuota pagada" ReadOnly="True">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Monto_cancelado" DataFormatString="{0:c}" HeaderText="Monto pagado" ReadOnly="True">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Fec_pago" DataFormatString="{0:d}" HeaderText="Fecha vencimiento" ReadOnly="True">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Fec_cancelacion" DataFormatString="{0:d}" HeaderText="Fecha cancelacion " ReadOnly="True">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="RetrasoPago" HeaderText="Dias retraso" ReadOnly="True">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                    </Columns>
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
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/MenuSolicitudes.aspx" BackColor="#092749" CssClass="btn btn-dark" Height="32px" Width="97px">Retornar</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
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
