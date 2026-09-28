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
    public partial class frmCorrespondencia : Form
    {
        public frmCorrespondencia()
        {
            InitializeComponent();
        }
        Entrega entrega = new Entrega();
        private void frmCorrespondencia_Load(object sender, EventArgs e)
        {
            Global.CarregarGridCorrespondencia(grdEntrega, entrega);
        }
        private void PreencherClasse()
        {
            entrega.Nome = txtNome.Text.ToUpper();
            entrega.Tipo = cboTipo.Text;     
        }

        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;
            try
            {
                if (txtNome.Text == string.Empty)
                {
                    msgErro = "Campo NOME em branco.\n";
                }

                if (cboTipo.Text == string.Empty)
                {
                    msgErro += "Campo TIPO em branco.\n";
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return msgErro;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string mensagemErro = ValidarPreenchimento();
            if (mensagemErro != string.Empty)
            {
                MessageBox.Show(mensagemErro,
                      "Controle_Acesso", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                return;
            }
            try
            {
                PreencherClasse();
                entrega.Gravar();
                MessageBox.Show("Correspondência gravada com sucesso",
                          "Controle_Acesso", MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtPesquisa.Clear();
            cboTipo.SelectedIndex = -1;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCorrespondencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Deseja fechar o menu Correspondência?", "Controle_Acesso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void CarregarGridCorrespondencia()
        {
            try
            {
                grdEntrega.DataSource = entrega.Consultar();
                   
                grdEntrega.AllowUserToAddRows = false;
                grdEntrega.AllowUserToDeleteRows = false;
                grdEntrega.AllowUserToOrderColumns = false;
                grdEntrega.AllowUserToResizeColumns = false;
                grdEntrega.AllowUserToResizeRows = false;
                   
                grdEntrega.RowHeadersVisible = false;
                grdEntrega.MultiSelect = false;
                grdEntrega.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                grdEntrega.ReadOnly = true;

                grdEntrega.Columns[0].Visible = false;
                //grdEntrega.Columns[1].Visible = false;
              // grdEntrega.Columns[2].Visible = false;
                   
                grdEntrega.Columns[1].HeaderText = "Tipo";
                grdEntrega.Columns[2].HeaderText = "Recebido";
      
                grdEntrega.Columns[1].Width = 190;
                grdEntrega.Columns[2].Width = 290;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            txtNome.Text = entrega.Nome;
            cboTipo.Text = entrega.Tipo;      
        }
        private void VerificarOpcao()
        {
            entrega = new Entrega();

            if (rdbNome.Checked)
            {
                entrega.Nome = txtPesquisa.Text;
            }
            CarregarGridCorrespondencia();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            VerificarOpcao();
            entrega.Nome = txtPesquisa.Text;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Focus();
            string mensagemErro = ValidarPreenchimentoTextCorrespondencia();
            if (mensagemErro != string.Empty)
            {
                MessageBox.Show(mensagemErro,
                      "Controle_Acesso", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                return;
            }
        }

        private string ValidarPreenchimentoTextCorrespondencia()
        {
            string msgErro = string.Empty;
            try
            {
                if (txtPesquisa.Text == string.Empty)
                {
                    msgErro = "Campo NOME branco.\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return msgErro;
        }
    }
}
