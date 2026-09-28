using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Controle_Acesso_Portaria
{
    public class AcessoBD
    {
        SqlConnection connection;

        private SqlCommand Conectar(string query,
            List<SqlParameter> param)
        {
            try
            {
                connection = new SqlConnection(Global.conexao);
                connection.Open();
                SqlCommand sqlCommand =
                    new SqlCommand(query, connection);

                foreach (SqlParameter p in param)
                {
                    sqlCommand.Parameters.Add(p);
                }
                return sqlCommand;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void Desconectar()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Consultar(string query,
            List<SqlParameter> parametros)
        {
            try
            {
                SqlCommand command = Conectar(query, parametros);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public void Executar(string query,
            List<SqlParameter> parametros)
        {
            try
            {
                SqlCommand command = Conectar(query, parametros);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public string Executar(List<SqlParameter> parametros,
            string query)
        {
            try
            {
                SqlCommand command = Conectar(query, parametros);
                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
