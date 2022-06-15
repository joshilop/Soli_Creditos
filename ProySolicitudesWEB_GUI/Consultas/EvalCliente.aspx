<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="EvalCliente.aspx.cs" Inherits="ProySolicitudesWEB_GUI.Consultas.EvalCliente" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 80%;
    }
    .pag-centrado{
        width: 90%;
        margin: 20px auto;
    }
    .titu-cus{
        color: #9f4dbf;
        margin: 10px auto;
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
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pag-centrado">
    <h3 class="encabezados" style="font-size: 25px; font-weight: 700;">Evaluación de clientes</h3>
<table class="auto-style1">
    <tr>
        <td style="color: #092749; font-size: 30px; font-weight:600">Seleccione cliente a evaluar:</td>
        <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="cboCliente" runat="server" Width="343px" CssClass="btn btn-secondary dropdown-toggle">
                </asp:DropDownList>
            </td>
            <td>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="131px" OnClick="btnBuscar_Click" CssClass="btn btn-outline-dark" />
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
        <td>
            &nbsp;</td>
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
        <td style="color: #092749; font-size: 25px;">RUC:</td>
        <td>
            <asp:TextBox ID="txtRUC" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
        <td style="color: #092749; font-size: 25px;">Edad:</td>
        <td>
            <asp:TextBox ID="txtEdad" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="color: #092749; font-size: 25px;">Estado Civil:</td>
        <td>
            <asp:TextBox ID="txtEstCivil" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
        <td style="color: #092749; font-size: 25px;">E-mail:</td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" ReadOnly="True" Width="226px"></asp:TextBox>
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
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="4" class="color: white; font-size: 25px;">
            <asp:Label ID="lblMensaje" runat="server" CssClass="alert-danger"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="color: white; font-size: 25px;">
            <asp:Label ID="lblInfoIngr" runat="server"></asp:Label>
        </td>
        <td class="color: white; font-size: 25px;">&nbsp;</td>
        <td class="color: white; font-size: 25px;">
            <asp:Label ID="lblCantIngr" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="color: white; font-size: 25px;">
            <asp:Label ID="lblReporteIngresos" runat="server"></asp:Label>
        </td>
        <td class="color: white; font-size: 25px;">&nbsp;</td>
        <td class="color: white; font-size: 25px;">
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:GridView ID="grvIngresos" runat="server" Width="915px" AutoGenerateColumns="False" CssClass="table table-dark table-hover">
                <Columns>
                    <asp:BoundField DataField="ID del Cliente" HeaderText="Id cliente" ReadOnly="True" />
                    <asp:BoundField DataField="Ingreso Descripción" HeaderText="Ingreso" ReadOnly="True" />
                    <asp:BoundField DataField="Ingresos" DataFormatString="{0:c}" HeaderText="Monto mensual (S/.)" ReadOnly="True">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Inicio percepción de ingreso" DataFormatString="{0:d}" HeaderText="Inicio percepción" ReadOnly="True">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblInfoGaran" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="lblCantGaran" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblReporteGarantia" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:GridView ID="grvGarantia" runat="server" Width="915px" AutoGenerateColumns="False" CssClass="table table-dark table-hover">
                <Columns>
                    <asp:BoundField DataField="Id_cli" HeaderText="Id cliente" ReadOnly="True" />
                    <asp:BoundField DataField="Tip_Garantia" HeaderText="Tipo" ReadOnly="True" />
                    <asp:BoundField DataField="Des_garantia" HeaderText="Detalle" ReadOnly="True" />
                    <asp:BoundField DataField="Valor_garantia" DataFormatString="{0:c}" HeaderText="Valor" ReadOnly="True">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblInfoSoli" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="lblCantSoli" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblReporteSolicitudes" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:GridView ID="grvSolicitud" runat="server" Width="915px" AutoGenerateColumns="False" CssClass="table table-dark table-hover">
                <Columns>
                    <asp:BoundField DataField="Id_cli" HeaderText="Id cliente" ReadOnly="True" />
                    <asp:BoundField DataField="Id_solicitud" HeaderText="Solicitud" ReadOnly="True" />
                    <asp:BoundField DataField="Nombre analista" HeaderText="Analista" ReadOnly="True" />
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
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/MenuSolicitudes.aspx" BackColor="#092749" CssClass="btn btn-dark" Height="37px" Width="90px">Retornar</asp:HyperLink>
        </td>
    </tr>
</table>
        </div>
    <%--Este es el modal popup que contiene los mensajes --%>        <%--1 Control target (cualquier control)--%>

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
