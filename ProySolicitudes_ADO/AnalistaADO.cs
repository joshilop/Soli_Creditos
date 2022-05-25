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
    public class AnalistaADO
    {
        // Insumos...
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarAnalista()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarAnalista";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Analistas");

                return dts.Tables["Analistas"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public AnalistaBE ConsultarAnalista(String strIdAna)
        {
            AnalistaBE objAnalistaBE = new AnalistaBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarAnalista";
            cmd.Parameters.Clear();
            try
            {
                // Por el Cod

                cmd.Parameters.AddWithValue("@vId_analista", strIdAna);

                // Abrimos la conexion 

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {

                    // Valores

                    dtr.Read();

                    objAnalistaBE.Id_analista = dtr["Id_analista"].ToString();
                    objAnalistaBE.DNI_analista = dtr["DNI_analista"].ToString();
                    objAnalistaBE.Email_analista = dtr["Email_analista"].ToString();
                    objAnalistaBE.Nom_agencia = dtr["Nom_agencia"].ToString();
                    objAnalistaBE.FecIngreso = Convert.ToDateTime(dtr["Fec_ingreso"]);

                }
                dtr.Close();
                return objAnalistaBE;


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

    }
}
