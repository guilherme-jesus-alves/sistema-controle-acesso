using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Acesso_Portaria
{
    public class Entrega
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        
        public Entrega() 
        {
            Codigo = 0;
            Nome = string.Empty;
            Tipo = string.Empty;
        }
        DataTable dt = new DataTable();
        AcessoBD acesso = new AcessoBD();
        List<SqlParameter> parametros = new List<SqlParameter>();
        string sql = string.Empty;


        public DataTable Consultar()
        {
            try
            {
                sql = "select ent_codigo, tipo, recebido \n";
                sql += "from tblentrega\n";

                parametros.Clear();

                if (Codigo != 0)
                {
                    sql += "where ent_codigo = @ent_codigo \n";
                    parametros.Add(new SqlParameter("@ent_codigo", Codigo));
                }
                else if (Nome != string.Empty)
                {
                    sql += "where recebido like @recebido\n";
                    parametros.Add(new SqlParameter("@recebido", "%" + Nome + "%"));
                }
                sql += "order by recebido";
                dt = acesso.Consultar(sql, parametros);

                if (Codigo != 0 || (Nome != string.Empty && dt.Rows.Count > 0))
                {
                    Codigo = Convert.ToInt32(dt.Rows[0]["ent_codigo"]);
                    Tipo = dt.Rows[0]["tipo"].ToString();
                    Nome = dt.Rows[0]["recebido"].ToString();              
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
                    sql = "insert into tblentrega";
                    sql += "(tipo, recebido)\n";
                    sql += "values\n";
                    sql += "(@tipo, @recebido);";
                }
                else
                {
                    sql = "update tblentrega \n";
                    sql += "set \n";
                    sql += "tipo = @tipo, \n";
                    sql += "recebido = @recebido \n";                  
                    sql += "where ent_codigo = @ent_codigo\n";
                    parametros.Add(new SqlParameter("@ent_codigo", Codigo));
                }
                parametros.Add(new SqlParameter("@tipo", Tipo));
                parametros.Add(new SqlParameter("@recebido", Nome));
                acesso.Executar(sql, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
