using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Acesso_Portaria
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public Usuario()
        {
            Codigo = 0;
            Login = string.Empty;
            Nome = string.Empty;
            Numero = string.Empty;
            Email = string.Empty;
            Sexo = string.Empty;
            Senha = string.Empty;
            Ativo = false;
        }

        DataTable dt = new DataTable();
        AcessoBD acesso = new AcessoBD();
        List<SqlParameter> parametros = new List<SqlParameter>();
        string sql = string.Empty;

        public bool Autenticar()
        {
            try
            {
                //Criando a consulta SQL para retornar
                //o código do usuário autenticado
                sql = "select use_codigo \n";
                sql += "from tblusuario \n";           
                sql += "where login = @login \n";
                sql += "and senha = @senha \n";
                sql += "and ativo = 1 \n";
                //adicionado parâmetros de consulta
                //login e senha
                parametros.Clear();

                parametros.Add(new SqlParameter("@login", Login));
                parametros.Add(new SqlParameter("@senha", Senha));
                //parametros.Add(new SqlParameter("@ativo", Ativo));

                dt = acesso.Consultar(sql, parametros);
                if (dt.Rows.Count > 0)
                {
                    Codigo = Convert.ToInt32(dt.Rows[0]["use_codigo"]);
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
        }
        public DataTable Consultar()
        {
            try
            {
                sql = "select \n";
                sql += "use_codigo, \n";
                sql += "nome, \n";            
                sql += "numero, \n";
                sql += "email, \n";
                sql += "sexo, \n";
                sql += "login, \n";
                sql += "senha, \n";
                sql += "ativo \n";
                sql += "from tblusuario \n";

                parametros.Clear();

                if (Codigo != 0)
                {
                    sql += "where use_codigo = @use_codigo \n";
                    parametros.Add(new SqlParameter("@use_codigo", Codigo));
                }
                else if (Login != string.Empty)
                {
                    sql += "where login = @login \n";
                    parametros.Add(new SqlParameter("@login", Login));
                }

                else if (Nome != string.Empty)
                {
                    sql += "where nome like @nome\n";
                    parametros.Add(new SqlParameter("@nome", "%" + Nome + "%"));
                }
                sql += "order by nome";
                dt = acesso.Consultar(sql, parametros);

                if (Codigo != 0 || (Login != string.Empty && dt.Rows.Count > 0))
                {
                    Codigo = Convert.ToInt32(dt.Rows[0]["use_codigo"]);
                    Nome = dt.Rows[0]["nome"].ToString();
                    Numero = dt.Rows[0]["numero"].ToString();
                    Email = dt.Rows[0]["email"].ToString();
                    Sexo = dt.Rows[0]["sexo"].ToString();
                    Login = dt.Rows[0]["login"].ToString();
                    Senha = dt.Rows[0]["senha"].ToString();
                    Ativo = Convert.ToBoolean(dt.Rows[0]["ativo"]);
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
                    sql = "insert into tblusuario \n";
                    sql += "(nome, numero, email, sexo, login, senha, ativo)\n";
                    sql += "values\n";
                    sql += "(@nome, @numero, @email, @sexo, @login, @senha, @ativo)";
                }
                else
                {
                    sql = "update tblusuario \n";
                    sql += "set \n";
                    sql += "nome = @nome, \n";
                    sql += "numero = @numero, \n";
                    sql += "email = @email, \n";
                    sql += "sexo = @sexo, \n";
                    sql += "login = @login, \n";
                    sql += "senha = @senha, \n";
                    sql += "ativo = @ativo \n";
                    sql += "where use_codigo = @use_codigo";
                    parametros.Add(new SqlParameter("@use_codigo", Codigo));
                }

                parametros.Add(new SqlParameter("@nome", Nome));
                parametros.Add(new SqlParameter("@numero", Numero));
                parametros.Add(new SqlParameter("@email", Email));
                parametros.Add(new SqlParameter("@sexo", Sexo));
                parametros.Add(new SqlParameter("@login", Login));
                parametros.Add(new SqlParameter("@senha", Senha));
                parametros.Add(new SqlParameter("@ativo", Ativo));
                acesso.Executar(sql, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
