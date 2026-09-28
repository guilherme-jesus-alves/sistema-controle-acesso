using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Acesso_Portaria
{
    public class Visitante
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string RG { get; set;}
        public string Sexo { get; set;}
        public string Departamento { get; set; }
       
        public Visitante() 
        {
            Codigo = 0;
            Nome = string.Empty;
            RG = string.Empty;
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
                sql = "select vis_codigo, nome, rg, \n";
                sql += "sexo, departamento\n";
                sql += "from tblvisitante\n";

                parametros.Clear();

                if (Codigo != 0)
                {
                    sql += "where vis_codigo = @vis_codigo \n";
                    parametros.Add(new SqlParameter("@vis_codigo", Codigo));
                }
                else if (RG != string.Empty)
                {
                    sql += "where rg = @rg \n";
                    parametros.Add(new SqlParameter("@rg", RG));
                }
                else if (Nome != string.Empty)
                {
                    sql += "where nome like @nome\n";
                    parametros.Add(new SqlParameter("@nome", "%" + Nome + "%"));
                }
                sql += "order by nome";
                dt = acesso.Consultar(sql, parametros);

                if (Codigo != 0 || (RG != string.Empty && dt.Rows.Count > 0))
                {
                    Codigo = Convert.ToInt32(dt.Rows[0]["vis_codigo"]);
                    Nome = dt.Rows[0]["nome"].ToString();
                    RG = dt.Rows[0]["rg"].ToString();
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
                    sql = "insert into tblvisitante";
                    sql += "(nome, rg, sexo, departamento)\n";
                    sql += "values\n";
                    sql += "(@nome, @rg, @sexo, @departamento);";
             
                }
                else
                {
                    sql = "update tblvisitante \n";
                    sql += "set \n";
                    sql += "nome = @nome, \n";
                    sql += "rg = @rg, \n";
                    sql += "sexo = @sexo \n";
                    sql += "departamento = @departamento \n";
                    sql += "where vis_codigo = @vis_codigo\n";
                    parametros.Add(new SqlParameter("@vis_codigo", Codigo));
                }
                parametros.Add(new SqlParameter("@nome", Nome));
                parametros.Add(new SqlParameter("@rg", RG));
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
