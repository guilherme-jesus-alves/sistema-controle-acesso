using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Acesso_Portaria
{
    public class Associado
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Sexo { get; set; }
        public string Departamento { get; set; }

        public Associado()
        {
            Codigo = 0;
            Nome = string.Empty;
            Numero = string.Empty;
            Sexo = string.Empty;
           Departamento = string.Empty;
        }
        DataTable dt = new DataTable();
        AcessoBD acesso = new AcessoBD();
        List<SqlParameter> parametros = new List<SqlParameter>();
        string sql = string.Empty;

        public DataTable Consultar()
        {
            try
            {
                sql = "select ass_codigo, nome, numero, \n";
                sql += "sexo, departamento\n";
                sql += "from tblassociado\n";

                parametros.Clear();

                if (Codigo != 0)
                {
                    sql += "where ass_codigo = @ass_codigo \n";
                    parametros.Add(new SqlParameter("@ass_codigo", Codigo));
                }
              
                else if (Nome != string.Empty)
                {
                    sql += "where nome like @nome\n";
                    parametros.Add(new SqlParameter("@nome", "%" + Nome + "%"));
                }
                sql += "order by nome";
                dt = acesso.Consultar(sql, parametros);

                if (Codigo != 0 || (Nome != string.Empty && dt.Rows.Count > 0))
                {
                    Codigo = Convert.ToInt32(dt.Rows[0]["ass_codigo"]);
                    Nome = dt.Rows[0]["nome"].ToString();
                    Numero = dt.Rows[0]["numero"].ToString();
                    Sexo = dt.Rows[0]["sexo"].ToString();
                    Departamento = dt.Rows[0]["departamento"].ToString();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Gravar()
        {
            try
            {
                parametros.Clear();
                if (Codigo == 0)
                {
                    sql = "insert into tblassociado";
                    sql += "(nome, numero, sexo, departamento)\n";
                    sql += "values\n";
                    sql += "(@nome, @numero, @sexo, @departamento);";

                }
                else
                {
                    sql = "update tblassociado \n";
                    sql += "set \n";
                    sql += "nome = @nome, \n";
                    sql += "numero = @numero, \n";
                    sql += "sexo = @sexo, \n";
                    sql += "departamento = @departamento \n";
                    sql += "where ass_codigo = @ass_codigo\n";
                    parametros.Add(new SqlParameter("@ass_codigo", Codigo));
                }
                parametros.Add(new SqlParameter("@nome", Nome));
                parametros.Add(new SqlParameter("@numero", Numero));
                parametros.Add(new SqlParameter("@sexo", Sexo));
                parametros.Add(new SqlParameter("@departamento", Departamento));
                acesso.Executar(sql, parametros);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
