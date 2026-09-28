using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Acesso_Portaria
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; } 
        public string Numero { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public string Departamento { get; set; }

        public Funcionario() 
        {
            Codigo = 0;
            Nome = string.Empty;
            DataNascimento = DateTime.Now;
            Numero = string.Empty;
            Email = string.Empty;
            CPF = string.Empty;
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
                sql = "select fun_codigo, nome, data_nascimento, numero, email, \n";
                sql += "cpf, sexo, departamento\n";
                sql += "from tblfuncionario\n";

                parametros.Clear();

                if (Codigo != 0)
                {
                    sql += "where fun_codigo = @fun_codigo \n";
                    parametros.Add(new SqlParameter("@fun_codigo", Codigo));
                }
                else if (CPF != string.Empty)
                {
                    sql += "where cpf = @cpf \n";
                    parametros.Add(new SqlParameter("@cpf", CPF));
                }
                else if (Nome != string.Empty)
                {
                    sql += "where nome like @nome\n";
                    parametros.Add(new SqlParameter("@nome", "%" + Nome + "%"));
                }
                sql += "order by nome";
                dt = acesso.Consultar(sql, parametros);

                if (Codigo != 0 || (CPF != string.Empty && dt.Rows.Count > 0))
                {
                    Codigo = Convert.ToInt32(dt.Rows[0]["fun_codigo"]);
                    Nome = dt.Rows[0]["nome"].ToString();
                    DataNascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                    Numero = dt.Rows[0]["numero"].ToString();
                    Email = dt.Rows[0]["email"].ToString();
                    CPF = dt.Rows[0]["cpf"].ToString();
                    Sexo = dt.Rows[0]["sexo"].ToString();
                    Sexo = dt.Rows[0]["departamento"].ToString();

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
                    sql = "insert into tblfuncionario";
                    sql += "(nome, data_nascimento, numero, email, cpf, sexo, departamento)\n";
                    sql += "values\n";
                    sql += "(@nome, @data_nascimento, @numero, @email, @cpf, @sexo, @departamento);";
                }
                else
                {
                    sql = "update tblfuncionario \n";
                    sql += "set \n";
                    sql += "nome = @nome, \n";
                    sql += "data_nascimento = @data_nascimento, \n";
                    sql += "numero = @numero, \n";
                    sql += "email = @email, \n";
                    sql += "cpf = @cpf, \n";
                    sql += "sexo = @sexo \n";
                    sql += "departamento = @departamento \n";
                    sql += "where fun_codigo = @fun_codigo\n";
                    parametros.Add(new SqlParameter("@fun_codigo", Codigo));
                }
                parametros.Add(new SqlParameter("@nome", Nome));
                parametros.Add(new SqlParameter("@data_nascimento", DataNascimento));
                parametros.Add(new SqlParameter("@numero", Numero));
                parametros.Add(new SqlParameter("@email", Email));
                parametros.Add(new SqlParameter("@cpf", CPF));
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
