using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProySolicitudes_ADO
{
    public class IngresoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarIngreso()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarIngreso";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Ingresos");

                return dts.Tables["Ingresos"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarIngresoXcliente(String strId)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarIngresoXcliente";
            cmd.Parameters.Clear();
            try
            {
                cmd.Parameters.AddWithValue("@vId_cliente", strId);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "IngresosCli");

                return dts.Tables["IngresosCli"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
