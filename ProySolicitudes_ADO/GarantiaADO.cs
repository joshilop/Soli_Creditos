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
    public class GarantiaADO
    {

        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public Boolean InsertarGarantia(GarantiaBE objGarantiaBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarGarantia";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@Tip_garantia", objGarantiaBE.Tip_garantia);
                cmd.Parameters.AddWithValue("@Des_garantia", objGarantiaBE.Des_garantia);
                cmd.Parameters.AddWithValue("@Valor_garantia", objGarantiaBE.Valor_garantia);
                cmd.Parameters.AddWithValue("@Id_cli", objGarantiaBE.Id_cli);
                cmd.Parameters.AddWithValue("@Est_garantia", objGarantiaBE.Est_garantia);
                cmd.Parameters.AddWithValue("@Usu_registro", objGarantiaBE.Usu_registro);


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

        public Boolean ActualizarGarantia(GarantiaBE objGarantiaBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarGarantia";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@id_garantia", objGarantiaBE.Id_garantia);
                cmd.Parameters.AddWithValue("@tip_garantia", objGarantiaBE.Tip_garantia);
                cmd.Parameters.AddWithValue("@des_garantia", objGarantiaBE.Des_garantia);
                cmd.Parameters.AddWithValue("@valor_garantia", objGarantiaBE.Valor_garantia);
                cmd.Parameters.AddWithValue("@id_cli", objGarantiaBE.Id_cli);
                cmd.Parameters.AddWithValue("@est_garania", objGarantiaBE.Est_garantia);
                cmd.Parameters.AddWithValue("@usu_ult_mod", objGarantiaBE.Usu_ult_mod);

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

        public Boolean EliminarGarantia(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarGarantia";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@id_garantia", strcod);

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

        public GarantiaBE ConsultarGarantia(String strCod)
        {
            GarantiaBE objGarantiaBE = new GarantiaBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarGarantia";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@id_garantia", strCod);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objGarantiaBE.Id_garantia = Convert.ToInt16(dtr["Id_garantia"]);
                    objGarantiaBE.Nom_cli = dtr["Nom_cli"].ToString();
                    objGarantiaBE.Ape_cli = dtr["Ape_cli"].ToString();
                    objGarantiaBE.Id_cli = dtr["Id_cli"].ToString();
                    objGarantiaBE.Tip_garantia = dtr["Tip_garantia"].ToString();
                    objGarantiaBE.Des_garantia = dtr["Des_garantia"].ToString();
                    objGarantiaBE.Valor_garantia = Convert.ToSingle(dtr["Valor_garantia"]);
                    objGarantiaBE.Est_garantia = Convert.ToInt16(dtr["Est_garantia"]);
                   

                }
                dtr.Close();
                return objGarantiaBE;


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

        public DataTable ListarGarantia()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarGarantia";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Garantia");

                return dts.Tables["Garantia"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarGarantiaXcliente(String strId)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarGarantiaXcliente";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@vId_cliente", strId);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "GarantiaCli");

                return dts.Tables["GarantiaCli"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
