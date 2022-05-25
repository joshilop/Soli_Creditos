<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="SolicitudesPaginacion.aspx.cs" Inherits="SitioVentasWEB_GUI.Consultas.WebFacturasPaginacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 206px;
        }
        .auto-style3 {
            width: 388px;
        }
        .auto-style6 {
            height: 22px;
        }
        .encabezados {
            text-align: center;
            color: #092749;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate >
    <h1 class="encabezados" style="font-size: 25px; font-weight: 700;">
        Listado paginado de Solicitudes</h1>
        <table class="auto-style1" align="center" style="max-width:90%">
            <tr>
                <td class="labelContenido" style="color: #092749; font-size: 25px;">Codigo de cliente:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtDNICli" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtDNICli" CssClass="alert-danger" ErrorMessage="*El codigo debe empezar en con C y tener 7 caracteres" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="labelContenido" style="color: #092749; font-size: 25px;">Seleccione vendedor:</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="cboAnalista" runat="server" Width="300px" CssClass="btn btn-secondary dropdown-toggle">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="labelContenido" style="color: #092749; font-size: 25px;">Seleccione estado:</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="cboEstado" runat="server" Width="300px" CssClass="btn btn-secondary dropdown-toggle">
                        <asp:ListItem Selected="True" Value="X">--Todos--</asp:ListItem>
                        <asp:ListItem>Aprobada</asp:ListItem>
                        <asp:ListItem>En proceso</asp:ListItem>
                        <asp:ListItem>Rechazada</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btnFiltrar" runat="server" CssClass="btn btn-outline-dark" Text="Filtrar" Width="100px" OnClick="btnFiltrar_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="3">
                    <asp:Label ID="lblMensaje" runat="server" CssClass="alert-danger"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="3">
                    <asp:GridView ID="grvSolicitudes" runat="server" CellPadding="4" AutoGenerateColumns="False" CssClass="table table-dark table-hover" ShowHeaderWhenEmpty="True">
                        
                        <Columns>
                            <asp:BoundField DataField="Id_solicitud" HeaderText="Id solicitud" ReadOnly="True" />
                            <asp:BoundField DataField="Nombre cliente" HeaderText="Cliente" ReadOnly="True" />
                            <asp:BoundField DataField="Id_cli" HeaderText="Id cliente" ReadOnly="True" />
                            <asp:BoundField DataField="Nombre analista" HeaderText="Analista" ReadOnly="True" />
                            <asp:BoundField DataField="Id_analista" HeaderText="Id analista" ReadOnly="True" />
                            <asp:BoundField DataField="Producto" HeaderText="Producto" ReadOnly="True" />
                            <asp:BoundField DataField="Fec_solicitud" DataFormatString="{0:d}" HeaderText="Solicitado el..." ReadOnly="True">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Monto_solici" DataFormatString="{0:c}" HeaderText="Monto solicitado" ReadOnly="True">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Cuotas" HeaderText="Cuotas" ReadOnly="True">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Estado" HeaderText="Estado" ReadOnly="True" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" />
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#F7F7DE" />
                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                        <SortedAscendingHeaderStyle BackColor="#848384" />
                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                        <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="cboPaginas" runat="server" Width="60px" AutoPostBack="True" OnSelectedIndexChanged="cboPaginas_SelectedIndexChanged" CssClass="btn btn-secondary dropdown-toggle">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink1" runat="server" BackColor="#092749" CssClass="btn btn-dark" Height="37px" NavigateUrl="~/Consultas/MenuSolicitudes.aspx" Width="90px">Retornar</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
            </ContentTemplate>
   </asp:UpdatePanel>
       <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0"  AssociatedUpdatePanelID ="UpdatePanel1">
         <%-- <ProgressTemplate>
              <div class="overlay">
                  <div class="overlayContent ">
                  <h2>Cargando</h2>  
                  <img src="../Images/loading.gif" alt ="Loading" border="0" />              
              </div>
              </div>
          </ProgressTemplate>--%>
    </asp:UpdateProgress>
</asp:Content>
