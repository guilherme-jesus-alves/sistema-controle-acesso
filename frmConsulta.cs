using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Acesso_Portaria
{
    public partial class frmConsulta : Form
    {
        Visitante visitante = new Visitante();
        Funcionario funcionario = new Funcionario();
        public frmConsulta()
        {
            InitializeComponent();
        }
        private void LimparCamposVis()
        {
            txtConsultarVisitante.Clear();
        }

        private void LimparCamposFun()
        {
            txtConsultarFuncionario.Clear();

        }
        private void btnLimparVis_Click(object sender, EventArgs e)
        {
            LimparCamposVis();
        }
        private void btnLimparFun_Click(object sender, EventArgs e)
        {
            LimparCamposFun();
        }
        private void frmConsulta_Load(object sender, EventArgs e)
        {
            Global.CarregarGridFuncionario(grdFuncionario, funcionario);
            Global.CarregarGridVisitante(grdVisitante, visitante);
          
        }
        private void CarregarGridVisitante()
        {
            try
            {
                grdVisitante.DataSource = visitante.Consultar();

                grdVisitante.AllowUserToAddRows = false;
                grdVisitante.AllowUserToDeleteRows = false;
                grdVisitante.AllowUserToOrderColumns = false;
                grdVisitante.AllowUserToResizeColumns = false;
                grdVisitante.AllowUserToResizeRows = false;

                grdVisitante.RowHeadersVisible = false;
                grdVisitante.MultiSelect = false;
                grdVisitante.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                grdVisitante.ReadOnly = true;

                grdVisitante.Columns[0].Visible = false;
               // grdVisitante.Columns[3].Visible = false;
                //grdVisitante.Columns[4].Visible = false;

                grdVisitante.Columns[1].HeaderText = "Nome";
                grdVisitante.Columns[2].HeaderText = "RG";
                grdVisitante.Columns[3].HeaderText = "Sexo";
                grdVisitante.Columns[4].HeaderText = "Departamento";


                grdVisitante.Columns[1].Width = 200;
                grdVisitante.Columns[2].Width = 148;
                grdVisitante.Columns[3].Width = 148;
                grdVisitante.Columns[4].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CarregarGridFuncionario()
        {
            try
            {
                grdFuncionario.DataSource = funcionario.Consultar();

                 grdFuncionario.AllowUserToAddRows = false;
                 grdFuncionario.AllowUserToDeleteRows = false;
                 grdFuncionario.AllowUserToOrderColumns = false;
                 grdFuncionario.AllowUserToResizeColumns = false;
                 grdFuncionario.AllowUserToResizeRows = false;
                 
                 grdFuncionario.RowHeadersVisible = false;
                 grdFuncionario.MultiSelect = false;
                 grdFuncionario.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                grdFuncionario.ReadOnly = true;
                
                grdFuncionario.Columns[0].Visible = false;
                grdFuncionario.Columns[3].Visible = false;
                grdFuncionario.Columns[4].Visible = false;
                
               grdFuncionario.Columns[1].HeaderText = "Nome";
               grdFuncionario.Columns[2].HeaderText = "Data_Nascimento";
               grdFuncionario.Columns[3].HeaderText = "Numero";
               grdFuncionario.Columns[4].HeaderText = "Email";
               grdFuncionario.Columns[5].HeaderText = "CPF";
               grdFuncionario.Columns[6].HeaderText = "Sexo";
               grdFuncionario.Columns[7].HeaderText = "Departamento";


                grdFuncionario.Columns[1].Width = 200;
                grdFuncionario.Columns[2].Width = 148;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtConsultarVisitante_TextChanged(object sender, EventArgs e)
        {
            VerificarOpcaoVis();
            visitante.Nome = txtConsultarVisitante.Text;
            visitante.RG = txtConsultarVisitante.Text;

        }
      

        private void txtConsultarFuncionario_TextChanged(object sender, EventArgs e)
        {
            VerificarOpcaoFun();
            funcionario.Nome = txtConsultarFuncionario.Text;
            funcionario.CPF = txtConsultarFuncionario.Text;
        }

        //(VerificarOpcaoVis) serve para filtrar entre NOME do Visitante ou RG do Visitante.
        private void VerificarOpcaoVis()
        {
            visitante = new Visitante();

            if (rdbNomeVisitante.Checked)
            {
                visitante.Nome = txtConsultarVisitante.Text;
            }
            else
            {
                visitante.RG = txtConsultarVisitante.Text;
            }
            CarregarGridVisitante();
        }    
        //(VerificarOpcaoFun) serve para filtrar entre NOME do Funcionario ou CPF do Funcionario.
        private void VerificarOpcaoFun()
        {
            funcionario = new Funcionario();

            if (rdbNomeFuncionario.Checked)
            {
                funcionario.Nome = txtConsultarFuncionario.Text;
            }
            else
            {
                funcionario.CPF = txtConsultarFuncionario.Text;
            }
            CarregarGridFuncionario();
        }

        private void btnCancelarVis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarFun_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarVisitante_Click(object sender, EventArgs e)
        {
           txtConsultarVisitante.Focus();

            string mensagemErro = ValidarPreenchimentoTextVis();
            if (mensagemErro != string.Empty)
            {
                MessageBox.Show(mensagemErro,
                      "Controle_Acesso", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                return;
            }
        }
        private string ValidarPreenchimentoTextVis()
        {
            string msgErro = string.Empty;
            try
            {
                if (txtConsultarVisitante.Text == string.Empty)
                {
                    msgErro = "Campo NOME e/ou RG em branco.\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);         
            }
            return msgErro;
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            txtConsultarFuncionario.Focus();

            string mensagemErro = ValidarPreenchimentoTextFun();
            if (mensagemErro != string.Empty)
            {
                MessageBox.Show(mensagemErro,
               "Controle_Acesso", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
        }

        private string ValidarPreenchimentoTextFun()
        {
            string msgErro = string.Empty;
            try
            {
                if (txtConsultarFuncionario.Text == string.Empty)
                {
                    msgErro = "Campo NOME e/ou CPF em branco.\n";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return msgErro;
        }

        private void frmConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Deseja fechar o menu Consultar?", "Controle_Acesso",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
