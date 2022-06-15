<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="MenuSolicitudes.aspx.cs" Inherits="ProySolicitudesWEB_GUI.MenuSolicitudes" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .encabezados{
        text-align: center;
        color: black;
    }
    .principal {
        width: 90%;
        margin: 0 auto;
    }
    /*.tarjetas {
        display:flex;
    }*/
        .auto-style3 {
            width: 80%;
            background-color: white;
            margin: 0 auto;
            border-style:double;
            border-width: 3px;
        }
        .auto-style4 {
            width: 1015px;
        }
    .auto-style5 {
        width: 389px;
    }
        .auto-style6 {
            font-size: 25px;
        }
        .auto-style7 {
            width: 1015px;
            
            height: 208px;
        }
        .auto-style8 {
            width: 389px;
            height: 208px;
        }
        .auto-style9 {
            width: 1015px;
            height: 27px;
        }
        .auto-style10 {
            width: 389px;
            height: 27px;
        }
        .auto-style11 {
            width: 80%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2 class="encabezados" style="color:#092749">
        <strong>
        <asp:Label ID="lblBienvenida" runat="server"></asp:Label>
        </strong>
    </h2>
    <h4 class="principal">
        <h3 style="color:#092749; font-size: 30px">¿Que consulta desea hacer el dia de hoy?</h3>
        <!--<div class="tarjetas">
            <div class="tarjeta">
                <h4>Evaluacion de clientes</h4>
                <p>Conozca mas del estado financiero del cliente para las aprobaciones de sus solicitudes</p>
                <p>Revise los ingresos, garantias y solicitudes previamente realizadas por los clientes</p>
            </div>
            <div class="tarjeta">
                <h4>Reportes de analistas</h4>
                <p>Para un buen control de las solicitudes atendidas o que faltan atender por los colaboradoes a su cargo</p>
                <p>Obtenga una vista de la solicitudes pendientes, aprobadas y rechazadas de cada analista</p>
            </div>
            <div class="tarjeta">
                <h4>Pagos realizados</h4>
                <p>Consulte los pagos que se realizaron a las solicitudes que fueron previamente aprovadas</p>
                <p>Filtre por cliente o id de solicitud para saber si estan pagadas, en mora y en que numero de cuota estan</p>
            </div>
            </div>-->
                <table class="auto-style3" aling="center">
                    <tr>
                        <td class="auto-style7"; style="color: #092749; padding:20px">
                            <h4 style="font-weight:700; font-size:25px">Evaluacion de clientes</h4>
                            <p>Conozca mas del estado financiero del cliente para las aprobaciones de sus solicitudes</p>
                            <p>Revise los ingresos, garantias y solicitudes previamente realizadas por los clientes</p>
                        </td>
                        <td style="text-align:center" class="auto-style8">
                            <asp:Button ID="Button5" runat="server" CssClass="btn btn-dark" PostBackUrl="~/Consultas/EvalCliente.aspx" Text="Ir a Evaluación Cliente" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            </td>
                        <td class="auto-style10">
                            </td>
                    </tr>
                    <tr>
                        <td class="auto-style7"; style="color: #092749; padding:20px">
                            <h4 style="font-weight:700; font-size:25px">
                                Descargue reporte garantias:</h4>
                        </td>
                        <td style="text-align:center" class="auto-style8">
                            <asp:Button ID="btnDescarga" runat="server" CssClass="btn btn-dark" OnClick="btnDescarga_Click" Text="Descargar excel" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            </td>
                        <td class="auto-style10">
                            </td>
                    </tr>
                    <tr>
                        <td class="auto-style4"; style="color: #092749; padding:20px">
                <h4 style="font-weight:700; font-size:25px">Reportes de analistas</h4>
                <p>Para un buen control de las solicitudes atendidas o que faltan atender por los colaboradoes a su cargo</p>
                <p>Obtenga una vista de la solicitudes pendientes, aprobadas y rechazadas de cada analista</p>
                        </td>
                        <td style="text-align:center" class="auto-style5">
            <asp:Button ID="Button7" runat="server" CssClass="btn btn-dark" PostBackUrl="~/Consultas/ReporteAnalista.aspx" Text="Ir a Reporte Analista" />
                        </td>
                    </tr>

                    <tr>
                        <td class="auto-style9">
                            </td>
                        <td class="auto-style10">
                            </td>
                    </tr>
                    <tr>
                        <td class="auto-style4"; style="color: #092749; padding:20px">
                <h4 style="font-weight:700; font-size:25px">Ranking de analistas</h4>
                <p>Para un buen control de las solicitudes atendidas o que faltan atender por los colaboradoes a su cargo</p>
                <p>Obtenga una vista del desempeño de los analistas</p>
                        </td>
                        <td style="text-align:center" class="auto-style5">
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-dark" PostBackUrl="~/Consultas/RankingAnalista.aspx" Text="Ir a Ranking Analista" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" class="color: white; font-size: 25px;">
                            <asp:Label ID="lblMensaje" runat="server" CssClass="alert-danger"></asp:Label>
                        </td>
                    </tr>
                    <%--<tr>
                        <td class="auto-style4">
                            &nbsp;</td>
                        <td class="auto-style5">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"; style="color: #092749; padding:20px">
                <h4 style="font-weight:700; font-size:25px">Pagos realizados</h4>
                <p>Consulte los pagos que se realizaron a las solicitudes que fueron previamente aprobadas</p>
                <p>Filtre por cliente o id de solicitud para saber si estan pagadas, en mora y en que numero de cuota estan</p>
                        </td>
                        <td style="text-align:center" class="auto-style5">
            <asp:Button ID="Button6" runat="server" CssClass="btn btn-dark" PostBackUrl="~/Consultas/Pagos.aspx" Text="Ir a Pagos" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4"; color: #092749; padding:20px">
                            &nbsp;</td>
                        <td style="text-align:center" class="auto-style5">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4" style="color: #092749; padding:20px">
                            <h4 class="auto-style6" style="font-weight: 700; font-size: 25px">Consulta Solicitud por cliente (Paginada)</h4>
                <p>Revise solicitudes filtradas por cliente, analista y su estado(Aprobada, rechazada o en proceso)</p>
                <p>&nbsp;</p>
                            </td>
                        <td style="text-align:center" class="auto-style5">
                            <asp:Button ID="Button1" runat="server" CssClass="btn btn-dark" PostBackUrl="~/Consultas/SolicitudesPaginacion.aspx" Text="Ir a Solicitudes" />

                        </td>
                    </tr>--%>
                </table>
            
        <br />
        <table class="auto-style11">
            <tr>
                <td>&nbsp;</td>
                <td>
            
        <asp:Button ID="Button2" runat="server" Text="Cerrar sesión" CssClass="btn-dark" PostBackUrl="~/WebLogout.aspx" />
        
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
