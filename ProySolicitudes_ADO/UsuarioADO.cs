using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProySolicitudes_BE;
using System.Data;
using System.Data.SqlClient;

namespace ProySolicitudes_ADO
{
    public class UsuarioADO
    {

        // Insumos
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            UsuarioBE objUsuarioBE = new UsuarioBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarUsuario";
            cmd.Parameters.Clear();

            try
            {
                cmd.Parameters.AddWithValue("@Login_Usuario", strLogin);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if(dtr.HasRows == true)
                {
                    dtr.Read();
                    objUsuarioBE.Login_Usuario = dtr["Login_Usuario"].ToString();
                    objUsuarioBE.Password_Usuario = dtr["Pass_Usuario"].ToString();
                    objUsuarioBE.Nivel_Usuario = Convert.ToInt16(dtr["Niv_Usuario"]);
                    objUsuarioBE.Estado_Usuario = Convert.ToInt16(dtr["Est_Usuario"]);
                    objUsuarioBE.Fec_Registro = Convert.ToDateTime(dtr["Fec_Registro"]);
                    objUsuarioBE.Usu_Registro = dtr["Usu_Registro"].ToString();
                }

                dtr.Close();
                return objUsuarioBE;

            }
            catch (Exception ex)
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

        public bool Confirmarlogin(string usuario, string contraseña)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select * from tb_Usuario where 
                                Login_Usuario = @usuario and CONVERT (nvarchar(max),DECRYPTBYPASSPHRASE('password',Pass_Usuario)) = @contraseña";
            cmd.Parameters.Clear();

            try
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if(dtr.HasRows == true)
                {
                    dtr.Read();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
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
