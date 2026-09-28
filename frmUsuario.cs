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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        Usuario usuario = new Usuario();

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregarGridUsuario();
        }
        private void CarregarGridUsuario()
        {
            try
            {
                grdUsuario.DataSource = usuario.Consultar();

                grdUsuario.AllowUserToAddRows = false;
                grdUsuario.AllowUserToDeleteRows = false;
                grdUsuario.AllowUserToOrderColumns = false;
                grdUsuario.AllowUserToResizeColumns = false;
                grdUsuario.AllowUserToResizeRows = false;

                grdUsuario.RowHeadersVisible = false;
                grdUsuario.MultiSelect = false;
                grdUsuario.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                grdUsuario.ReadOnly = true;

                grdUsuario.Columns[0].Visible = false;
               // grdUsuario.Columns[3].Visible = false;
                //grdUsuario.Columns[4].Visible = false;

                grdUsuario.Columns[1].HeaderText = "Nome";
                grdUsuario.Columns[2].HeaderText = "Telefone";
                grdUsuario.Columns[3].HeaderText = "Email";
                grdUsuario.Columns[4].HeaderText = "Sexo";
                grdUsuario.Columns[5].HeaderText = "Usuário";
                grdUsuario.Columns[6].HeaderText = "Senha";

                grdUsuario.Columns[1].Width = 200;
                grdUsuario.Columns[2].Width = 200;
                grdUsuario.Columns[3].Width = 300;
                grdUsuario.Columns[4].Width = 200;
                grdUsuario.Columns[5].Width = 200;
                grdUsuario.Columns[6].Width = 300;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisarUsuario_TextChanged(object sender, EventArgs e)
        {
            VerificarOpcao();
        }
        private void VerificarOpcao()
        {
            usuario = new Usuario();
            if (rdbUsuario.Checked)
            {
                usuario.Login = txtPesquisarUsuario.Text;
            }
            else
            {
                usuario.Nome = txtPesquisarUsuario.Text;
            }
            CarregarGridUsuario();
        }

        private void grdUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdUsuario.Rows.Count == 0)
            {
                return;
            }
            try
            {
                usuario.Codigo = Convert.ToInt32(
                    grdUsuario.SelectedRows[0].Cells[0].Value);
                usuario.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            txtUsuario.Text = usuario.Login;
            txtNome.Text = usuario.Nome;
            txtNumero.Text = usuario.Numero;
            txtEmail.Text = usuario.Email;
            cboSexo.Text = usuario.Sexo;
            txtSenha.Text = usuario.Senha;
            txtConfirmacao.Text = usuario.Senha;
        }
        private void LimparCampos(bool pesquisa = false)
        {
            usuario = new Usuario();
            txtUsuario.Clear();
            txtNome.Clear();
            txtNumero.Clear();
            txtEmail.Clear();
            cboSexo.SelectedIndex = -1;
            txtSenha.Clear();
            txtConfirmacao.Clear();

            if (pesquisa)
            {
                return;
            }
            txtPesquisarUsuario.Clear();
            rdbNome.Checked = true;
            rdbUsuario.Checked = false;

            txtPesquisarUsuario.Focus();
            CarregarGridUsuario();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (usuario.Codigo > 0)
            {
                if (ValidarPesquisa() == DialogResult.No)
                {
                    return;
                }
                LimparCampos(true);
            }
            VerificarOpcao();
        }

        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;
            try
            {
                if (txtUsuario.Text == string.Empty)
                {
                    msgErro = "Campo USUÁRIO em branco.\n";
                }
                else
                {
                    Usuario u = new Usuario();
                    u.Login = txtUsuario.Text;
                    u.Nome = txtNome.Text;
                    u.Numero = txtNumero.Text;
                    u.Email = txtEmail.Text;
                    u.Sexo = cboSexo.Text;
                    u.Senha = txtSenha.Text;
                    u.Senha = txtConfirmacao.Text;
                    u.Consultar();
                    if ((u.Codigo > 0 && usuario.Codigo == 0)
                        || (u.Codigo > 0 && u.Codigo != usuario.Codigo))
                    {
                        msgErro += "USUÁRIO já existe.\n";
                    }
                }

                if (txtNome.Text == string.Empty)
                {
                    msgErro += "Campo NOME em branco.\n";
                }               
                if (txtNumero.Text == string.Empty)
                {
                    msgErro += "Campo TELEFONE em branco.\n";
                }
                if (txtEmail.Text == string.Empty)
                {
                    msgErro += "Campo EMAIL em branco.\n";
                }
                if (cboSexo.Text == string.Empty)
                {
                    msgErro += "Campo SEXO em branco.\n";
                }
                if (txtSenha.Text == string.Empty)
                {
                    msgErro += "Campo SENHA em branco.\n";
                }
                if (txtSenha.Text != txtConfirmacao.Text)
                {
                    msgErro += "CONFIRMAÇÃO da Senha não confere.\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_acesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return msgErro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void txtPesquisarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && usuario.Codigo > 0)
            {
                if (ValidarPesquisa() == DialogResult.No)
                {
                    e.Handled = true;
                    return;
                }
                LimparCampos(true);
            }
        }

        private DialogResult ValidarPesquisa()
        {
            return MessageBox.Show(
                    "Uma nova pesquisa limpará os dados do formulário\n" +
                    "Deseja continuar?", "Controle_Acesso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
        }

        private void PreencherClasse()
        {
            usuario.Login = txtUsuario.Text.ToUpper();
            usuario.Nome = txtNome.Text.ToUpper();
            usuario.Numero = txtNumero.Text;
            usuario.Email = txtEmail.Text.ToUpper();
            usuario.Sexo = cboSexo.Text;
           
            if (usuario.Senha != txtSenha.Text)
            {
                usuario.Senha = Global.CriptografarPassword(txtSenha.Text);
            }
            usuario.Ativo = true;
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
                usuario.Gravar();
                MessageBox.Show("Usuário gravado com sucesso",
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

        private void grdUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarGridUsuario();
        }

        private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Deseja fechar o menu Usuário?", "Controle_Acesso",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}
