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
    public partial class frmAssociado : Form
    {
        public frmAssociado()
        {
            InitializeComponent();
        }
        Associado associado = new Associado();
        private void frmAssociado_Load(object sender, EventArgs e)
        {
            //CarregarGridAssociado();
            Global.CarregarGridAssociado(grdAssociado, associado);

        }
        private void LimparCampos()
        {
            associado = new Associado();
            txtNome.Clear();
            txtNumero.Clear();
            cboSexo.SelectedIndex = -1;
            cboDepartamento.SelectedIndex = -1;

            txtPesquisarAssociado.Clear();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void CarregarGridAssociado()
        {
            try
            {
                grdAssociado.DataSource = associado.Consultar();

                grdAssociado.AllowUserToAddRows = false;
                grdAssociado.AllowUserToDeleteRows = false;
                grdAssociado.AllowUserToOrderColumns = false;
                grdAssociado.AllowUserToResizeColumns = false;
                grdAssociado.AllowUserToResizeRows = false;

                grdAssociado.RowHeadersVisible = false;
                grdAssociado.MultiSelect = false;
                grdAssociado.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                grdAssociado.ReadOnly = true;
                   
                grdAssociado.Columns[0].Visible = false;
                // grdUsuario.Columns[3].Visible = false;
                //grdUsuario.Columns[4].Visible = false;

                grdAssociado.Columns[1].HeaderText = "Nome";
                grdAssociado.Columns[2].HeaderText = "Telefone";
                grdAssociado.Columns[3].HeaderText = "Sexo";
                grdAssociado.Columns[4].HeaderText = "Departamento";

                grdAssociado.Columns[1].Width = 200;
                grdAssociado.Columns[2].Width = 200;
                grdAssociado.Columns[3].Width = 300;
                grdAssociado.Columns[4].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherClasse()
        {
           associado.Nome = txtNome.Text.ToUpper();
           associado.Numero = txtNumero.Text;
           associado.Sexo = cboSexo.Text;
           associado.Departamento = cboDepartamento.Text;
        }

        private void PreencherFormulario()
        {
            txtNome.Text = associado.Nome;
            txtNumero.Text = associado.Numero;
            cboSexo.Text = associado.Sexo;
            cboDepartamento.Text = associado.Departamento;
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

                if (txtNumero.Text == string.Empty)
                {
                    msgErro += "Campo NÚMERO em branco.\n";
                }
                if (cboSexo.Text == string.Empty)
                {
                    msgErro += "Campo SEXO em branco. \n";
                }
                if (cboDepartamento.Text == string.Empty)
                {
                    msgErro += "Campo DEPARTAMENTO em branco. \n";
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
                associado.Gravar();
                MessageBox.Show("Associado gravado com sucesso",
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAssociado_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Deseja fechar o menu Associado?", "Controle_Acesso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteDigitos(e.KeyChar);
        }

        private void VerificarOpcao()
        {
            associado = new Associado();

            if (rdbNome.Checked)
            {
                associado.Nome = txtPesquisarAssociado.Text;
            }
            CarregarGridAssociado();
        }

        private void txtPesquisarAssociado_TextChanged(object sender, EventArgs e)
        {
            VerificarOpcao();
            associado.Nome = txtPesquisarAssociado.Text;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //VerificarOpcao();
            txtPesquisarAssociado.Focus();
            string mensagemErro = ValidarPreenchimentoTextAssociado();
            if (mensagemErro != string.Empty)
            {
                MessageBox.Show(mensagemErro,
                      "Controle_Acesso", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                return;
            }
        }

        private void grdAssociado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdAssociado.Rows.Count == 0)
            {
                return;
            }
            try
            {
                associado.Codigo = Convert.ToInt32(
                    grdAssociado.SelectedRows[0].Cells[0].Value);
                associado.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidarPreenchimentoTextAssociado()
        {
            string msgErro = string.Empty;
            try
            {
                if (txtPesquisarAssociado.Text == string.Empty)
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
