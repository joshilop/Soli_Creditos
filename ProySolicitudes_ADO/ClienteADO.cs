using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProySolicitudes_BE;

namespace ProySolicitudes_ADO
{
    public class ClienteADO
    {
        // Insumos...
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        // Metodos de mantenimiento..

        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarCliente";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vnomb", objClienteBE.Nom_cli);
                cmd.Parameters.AddWithValue("@vApelli", objClienteBE.Ape_cli);
                cmd.Parameters.AddWithValue("@vdniCli", objClienteBE.Dni_cli);
                cmd.Parameters.AddWithValue("@vruc", objClienteBE.Ruc_cli);
                cmd.Parameters.AddWithValue("@vsexo", objClienteBE.Sexo);
                cmd.Parameters.AddWithValue("@vfecNac", objClienteBE.Fec_nacimiento);
                cmd.Parameters.AddWithValue("@vEduc", objClienteBE.Nivel_educacion);
                cmd.Parameters.AddWithValue("@vEst_Civil", objClienteBE.Estado_civil);
                cmd.Parameters.AddWithValue("@vEmail", objClienteBE.Email);
                cmd.Parameters.AddWithValue("@vIdubi", objClienteBE.Id_ubigeo);
                cmd.Parameters.AddWithValue("@vEst_Cli", objClienteBE.Est_cli);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objClienteBE.Usu_registro);

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

        public Boolean ActualizarCliente(ClienteBE objClienteBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarCliente";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vcod", objClienteBE.Id_cli);
                cmd.Parameters.AddWithValue("@vnomb", objClienteBE.Nom_cli);
                cmd.Parameters.AddWithValue("@vApelli", objClienteBE.Ape_cli);
                cmd.Parameters.AddWithValue("@vdniCli", objClienteBE.Dni_cli);
                cmd.Parameters.AddWithValue("@vruc", objClienteBE.Ruc_cli);
                cmd.Parameters.AddWithValue("@vsexo", objClienteBE.Sexo);
                cmd.Parameters.AddWithValue("@vfecNac", objClienteBE.Fec_nacimiento);
                cmd.Parameters.AddWithValue("@vEduc", objClienteBE.Nivel_educacion);
                cmd.Parameters.AddWithValue("@vEst_Civil", objClienteBE.Estado_civil);
                cmd.Parameters.AddWithValue("@vEmail", objClienteBE.Email);
                cmd.Parameters.AddWithValue("@vIdubi", objClienteBE.Id_ubigeo);
                cmd.Parameters.AddWithValue("@vEst_Cli", objClienteBE.Est_cli);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objClienteBE.Usu_ult_mod);

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

        public Boolean EliminarCliente(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_BajaCliente";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@idCliente", strcod);

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

        public ClienteBE ConsultarCliente(String strCod)
        {
            ClienteBE objClienteBE = new ClienteBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarCliente";
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
                    objClienteBE.Id_cli = dtr["Id_cli"].ToString();
                    objClienteBE.Nom_cli = dtr["Nom_cli"].ToString();
                    objClienteBE.Ape_cli = dtr["Ape_cli"].ToString();
                    objClienteBE.Dni_cli = dtr["Dni_cli"].ToString();
                    objClienteBE.Ruc_cli = dtr["Ruc_cli"].ToString();
                    objClienteBE.Sexo = dtr["Sexo"].ToString();
                    objClienteBE.Fec_nacimiento = Convert.ToDateTime(dtr["Fec_nacimiento"]);
                    objClienteBE.Nivel_educacion = dtr["Nivel_educacion"].ToString();

                    objClienteBE.Estado_civil = Convert.ToInt16(dtr["Estado_civil"]);
                    objClienteBE.Est_Civ = dtr["EstadoCivil"].ToString();
                    
                    objClienteBE.Email = dtr["Email"].ToString();
                    objClienteBE.Id_ubigeo = dtr["Id_ubigeo"].ToString();
                    objClienteBE.Est_cli = Convert.ToInt16(dtr["Est_cli"]);
                    objClienteBE.Estado_Cliente = dtr["Estado cliente"].ToString();

                    objClienteBE.Edad = Convert.ToInt16(dtr["Edad"]);

                }
                dtr.Close();
                return objClienteBE;


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

        public DataTable ListarCliente()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarCliente";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Clientes");

                return dts.Tables["Clientes"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

}
}
