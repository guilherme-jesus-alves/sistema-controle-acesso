using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Controle_Acesso_Portaria
{
    public static class Global
    {
        public static int codigo;
        public static string usuario;
        public static string nome;
        public static string conexao;
        public static string servidor;
        public static string banco;
        public static string simboloMonetario =
            NumberFormatInfo.CurrentInfo.CurrencySymbol;
        public static void MontarStringConexao()
        {
            servidor =
           ConfigurationManager.AppSettings["servidor"].ToString();
            banco =
          ConfigurationManager.AppSettings["banco"].ToString();

            conexao =
            string.Format("Data Source={0};Initial Catalog={1};" +
                "Integrated Security=true;",
                servidor, banco);
        }
        public static string CriptografarPassword(string senha)
        {
            Byte[] byteTamanhoOriginal;
            Byte[] byteTamanhoCriptografado;
            MD5 md5;

            // Conver the original password to bytes; then create the hash
            md5 = new MD5CryptoServiceProvider();
            byteTamanhoOriginal =
                ASCIIEncoding.Default.GetBytes(senha);
            byteTamanhoCriptografado =
                md5.ComputeHash(byteTamanhoOriginal);

            // Bytes to string
            return Regex.Replace(BitConverter.ToString(
                byteTamanhoCriptografado), "-", "").ToLower();
        }

        public static void CarregarGridVisitante(DataGridView grid, Visitante v)
        {
            try
            {
                grid.DataSource = v.Consultar();

                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.AllowUserToOrderColumns = false;
                grid.AllowUserToResizeColumns = false;
                grid.AllowUserToResizeRows = false;

                grid.RowHeadersVisible = false;
                grid.MultiSelect = false;
                grid.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                grid.ReadOnly = true;

               grid.Columns[0].Visible = false;
              //  grid.Columns[3].Visible = false;

                grid.Columns[1].HeaderText = "Nome";
                grid.Columns[2].HeaderText = "RG";
                grid.Columns[3].HeaderText = "Sexo";
                grid.Columns[4].HeaderText = "Departamento";

                grid.Columns[1].Width = 150;
                grid.Columns[2].Width = 90;
                grid.Columns[3].Width = 120;
                grid.Columns[4].Width = 325;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CarregarGridFuncionario(DataGridView grid, Funcionario f)
        {
            try
            {
                grid.DataSource = f.Consultar();

                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.AllowUserToOrderColumns = false;
                grid.AllowUserToResizeColumns = false;
                grid.AllowUserToResizeRows = false;

                grid.RowHeadersVisible = false;
                grid.MultiSelect = false;
                grid.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                grid.ReadOnly = true;

                grid.Columns[0].Visible = false;
                //grid.Columns[3].Visible = false;

                grid.Columns[1].HeaderText = "Nome";
                grid.Columns[2].HeaderText = "Data_Nascimento";
                grid.Columns[3].HeaderText = "Telefone";
                grid.Columns[4].HeaderText = "Email";
                grid.Columns[5].HeaderText = "CPF";           
                grid.Columns[6].HeaderText = "Sexo";
                grid.Columns[7].HeaderText = "Departamento";


                grid.Columns[1].Width = 190;
                grid.Columns[2].Width = 190;
                grid.Columns[3].Width = 190;
                grid.Columns[4].Width = 190;
                grid.Columns[5].Width = 190;
                grid.Columns[6].Width = 190;
                grid.Columns[7].Width = 190;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CarregarGridAssociado(DataGridView grid, Associado a)
        {
            try
            {
                grid.DataSource = a.Consultar();

                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.AllowUserToOrderColumns = false;
                grid.AllowUserToResizeColumns = false;
                grid.AllowUserToResizeRows = false;

                grid.RowHeadersVisible = false;
                grid.MultiSelect = false;
                grid.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                grid.ReadOnly = true;

                grid.Columns[0].Visible = false;
                //grid.Columns[3].Visible = false;

                grid.Columns[1].HeaderText = "Nome";
                grid.Columns[2].HeaderText = "Telefone";
                grid.Columns[3].HeaderText = "Sexo";
                grid.Columns[4].HeaderText = "Departamento";

                grid.Columns[1].Width = 190;
                grid.Columns[2].Width = 190;
                grid.Columns[3].Width = 190;
                grid.Columns[4].Width = 190;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CarregarGridCorrespondencia(DataGridView grid, Entrega e)
        {
            try
            {
                grid.DataSource = e.Consultar();

                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.AllowUserToOrderColumns = false;
                grid.AllowUserToResizeColumns = false;
                grid.AllowUserToResizeRows = false;

                grid.RowHeadersVisible = false;
                grid.MultiSelect = false;
                grid.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                grid.ReadOnly = true;

                grid.Columns[0].Visible = false;

                grid.Columns[1].HeaderText = "Tipo";
                grid.Columns[2].HeaderText = "Recebido";
              
                grid.Columns[1].Width = 190;
                grid.Columns[2].Width = 280;       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool SomenteDigitos(char tecla)
        {
            return ((!char.IsControl(tecla)) &&
                (!char.IsDigit(tecla)));

        }

    }
}
