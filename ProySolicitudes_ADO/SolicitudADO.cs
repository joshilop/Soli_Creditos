using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProySolicitudes_BE;

namespace ProySolicitudes_ADO
{
    public class SolicitudADO
    {
        // Insumos...
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public Boolean InsertarSolicitud(SolicitudBE objSolicitudBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarSolicitud";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vId_cli", objSolicitudBE.Id_cli);
                cmd.Parameters.AddWithValue("@vId_ana", objSolicitudBE.Id_analista);
                cmd.Parameters.AddWithValue("@vtipoProd", objSolicitudBE.Tipo_producto);
                cmd.Parameters.AddWithValue("@vmontoSoli", objSolicitudBE.Monto_solici);
                cmd.Parameters.AddWithValue("@vnum_Cuen", objSolicitudBE.Num_cuenta);
                cmd.Parameters.AddWithValue("@vEst_Soli", objSolicitudBE.Est_solicitud);
                cmd.Parameters.AddWithValue("@vfec_apro", objSolicitudBE.Fec_aprobacion);
                cmd.Parameters.AddWithValue("@vfec_rechazo", objSolicitudBE.Fec_rechazo);
                cmd.Parameters.AddWithValue("@vmotivo_recha", objSolicitudBE.Motivo_rechazo);
                cmd.Parameters.AddWithValue("@vEst_desem", objSolicitudBE.Est_desembolso);
                cmd.Parameters.AddWithValue("@vUsu_reg", objSolicitudBE.Usu_registro);
                cmd.Parameters.AddWithValue("@vCuotas", objSolicitudBE.Cuotas);


                // Abro la conexion y ejecutamos
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;


            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean ActualizarSolicitud(SolicitudBE objSolicitudBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarSolicitud";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vcod", objSolicitudBE.Id_solicitud);
                cmd.Parameters.AddWithValue("@vId_cli", objSolicitudBE.Id_cli);
                cmd.Parameters.AddWithValue("@vId_ana", objSolicitudBE.Id_analista);
                cmd.Parameters.AddWithValue("@vtipoProd", objSolicitudBE.Tipo_producto);
                cmd.Parameters.AddWithValue("@vmontoSoli", objSolicitudBE.Monto_solici);
                cmd.Parameters.AddWithValue("@vnum_Cuen", objSolicitudBE.Num_cuenta);
                cmd.Parameters.AddWithValue("@vEst_Soli", objSolicitudBE.Est_solicitud);
                cmd.Parameters.AddWithValue("@vfec_apro", objSolicitudBE.Fec_aprobacion);
                cmd.Parameters.AddWithValue("@vfec_rechazo", objSolicitudBE.Fec_rechazo);
                cmd.Parameters.AddWithValue("@vmotivo_recha", objSolicitudBE.Motivo_rechazo);
                cmd.Parameters.AddWithValue("@vEst_desem", objSolicitudBE.Est_desembolso);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objSolicitudBE.Usu_ult_mod);
                cmd.Parameters.AddWithValue("@vCuota", objSolicitudBE.Cuotas);

                // Abro la conexion y ejecutamos
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }

        public Boolean EliminarSolicitud(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarSolicitud";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vcod", strcod);

                //Abro la conexion y ejecuto...
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }

        public SolicitudBE ConsultarSolicitud(String strCod)
        {
            SolicitudBE objSolicitudBE = new SolicitudBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarSolicitud";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vcos", strCod);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objSolicitudBE.Id_solicitud = dtr["Id_solicitud"].ToString();
                    objSolicitudBE.Id_cli = dtr["Id_cli"].ToString();
                    objSolicitudBE.Id_analista = dtr["Id_analista"].ToString();
                    objSolicitudBE.Tipo_producto = Convert.ToInt16(dtr["Tipo_producto"]);
                    objSolicitudBE.Producto = dtr["PRODUCTO"].ToString();
                    objSolicitudBE.Fec_solicitud = Convert.ToDateTime(dtr["Fec_solicitud"]);
                    objSolicitudBE.Monto_solici = Convert.ToSingle(dtr["Monto_solici"]);
                    objSolicitudBE.Num_cuenta = dtr["Num_cuenta"].ToString();
                    objSolicitudBE.Est_solicitud = Convert.ToInt16(dtr["Est_solicitud"]);
                    /*if (dtr["Fec_aprobacion"] == null)
                    {
                        //objSolicitudBE.Fec_aprobacion = Convert.ToDateTime(dtr["Fec_aprobacion"]);
                        objSolicitudBE.Fec_aprobacion = Convert.ToDateTime("20200210");
                    }
                    else
                    {
                        objSolicitudBE.Fec_aprobacion = Convert.ToDateTime(dtr["Fec_aprobacion"]);
                    }*/
                    //objSolicitudBE.Fec_aprobacion = Convert.ToDateTime(dtr["Fec_aprobacion"]);
                    //objSolicitudBE.Fec_rechazo = Convert.ToDateTime(dtr["Fec_rechazo"]);
                    objSolicitudBE.Motivo_rechazo = dtr["Motivo_rechazo"].ToString();
                    objSolicitudBE.Estado_Desembolso = dtr["Estado desembolso"].ToString();
                    objSolicitudBE.Est_desembolso = Convert.ToInt16(dtr["Est_desembolso"]);
                    //objSolicitudBE.Fec_desembolso = Convert.ToDateTime(dtr["Fec_desembolso"]);
                    objSolicitudBE.Fec_pago = Convert.ToDateTime(dtr["Fec_pago"]);
                    objSolicitudBE.Cuotas = Convert.ToInt16(dtr["Cuotas"]);
                    

                }
                dtr.Close();
                return objSolicitudBE;


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }

        public DataTable ListarSolicitud()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarSolicitud";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Solicitudes");

                return dts.Tables["Solicitudes"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarSolicitudXcliente(String strId)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarSolicitudXcliente";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@vId_cliente", strId);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "SolicitudesCli");

                return dts.Tables["SolicitudesCli"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarSolicitudEstAna(String strId, String strEstado)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarSolicitudEstAna";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@vId_analista", strId);
                cmd.Parameters.AddWithValue("@vEstado", strEstado);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "SolicitudesEstAna");

                return dts.Tables["SolicitudesEstAna"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarPago()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarPago";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Pagos");

                return dts.Tables["Pagos"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarPagoCliente(String strId)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarPagoCliente";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@vId_cli", strId);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "PagosCli");

                return dts.Tables["PagosCli"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarPagoSolicitud(String strIdSoli)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarPagoSolicitud";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@vId_solicitud", strIdSoli);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "PagosSoli");

                return dts.Tables["PagosSoli"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarSolicitudEstado(Int16 numEst)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarSolicitudEstado";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@vEstado", numEst);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "SolicitudesEstado");

                return dts.Tables["SolicitudesEstado"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable RankingAnalistas(Int16 numTop, Int16 numEst)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_RankingAnalistas";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@vTop", numTop);
                cmd.Parameters.AddWithValue("@vEst_soli", numEst);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "TopSolicitudesEstado");

                return dts.Tables["TopSolicitudesEstado"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarSolicitudes_Paginacion(String strIdCli, String strIdAna, String strEstado, Int16 intNumPag)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarSolicitudes_Paginacion";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@Id_cli", strIdCli);
                cmd.Parameters.AddWithValue("@Id_analista", strIdAna);
                cmd.Parameters.AddWithValue("@Estado", strEstado);
                cmd.Parameters.AddWithValue("@NumPag", intNumPag);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "SolicitudesPag");

                return dts.Tables["SolicitudesPag"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Int16 NumPag_ListarSolicitudes_Paginacion(String strIdCli, String strIdAna, String strEstado)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_NumPag_ListarSolicitudes_Paginacion";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Id_cli", strIdCli);
                cmd.Parameters.AddWithValue("@Id_analista", strIdAna);
                cmd.Parameters.AddWithValue("@Estado", strEstado);

                cmd.Parameters.Add("@NumReg", SqlDbType.Int);
                cmd.Parameters["@NumReg"].Direction = ParameterDirection.Output;

                cnx.Open();
                cmd.ExecuteScalar();
                Int16 numreg = Convert.ToInt16(cmd.Parameters["@NumReg"].Value);

                return numreg;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
