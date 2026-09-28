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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        bool ver = true;
        Usuario usuario;
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string mensagemErro = ValidarPreenchimento();
            if (mensagemErro != string.Empty)
            {
                MessageBox.Show(mensagemErro,
                    "Erro de Preenchimento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            PreencherClasse();
            try
            {
                if (usuario.Autenticar())
                {
                    usuario.Consultar();
                    Global.codigo = usuario.Codigo;
                    Global.usuario = usuario.Login;
                    Global.nome = usuario.Nome;

                    string mensagem = string.Format("Bem vindo {0}.\n", usuario.Login);
                    mensagem += "Usuário autenticado com sucesso.";
                    MessageBox.Show(mensagem,
                        "Controle_Acesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha incorretos.",
                        "Controle_Acesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Controle_Acesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;
            if (txtUsuario.Text == string.Empty)
            {
                msgErro = "Preencha o USUÁRIO.\n";
            }
            if (txtSenha.Text == string.Empty)
            {
                msgErro += "Preencha a SENHA.";
            }
            return msgErro;
        }

        private void pctSenha_Click(object sender, EventArgs e)
        {
            pctSenha.Image =
               ver ? /*Pergunta*/
               Properties.Resources.ver : /*Ação se verdadeiro*/
               Properties.Resources.olho; /*Ação se falso&*/
            txtSenha.UseSystemPasswordChar = !ver;
            ver = !ver;
        }
        private void PreencherClasse()
        {
            usuario = new Usuario();
            usuario.Login = txtUsuario.Text;
            usuario.Senha = Global.CriptografarPassword(txtSenha.Text);
        }

    
    }
}
