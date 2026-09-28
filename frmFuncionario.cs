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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            funcionario = new Funcionario();
            txtNome.Clear();
            dtpDataNascimento.Value = Convert.ToDateTime("1900/01/01");
            txtNumero.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            cboSexo.SelectedIndex = -1;
            cboDepartamento.SelectedIndex = -1;
        }
       Funcionario funcionario = new Funcionario();

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }  
        private void PreencherClasse()
        {
            funcionario.Nome = txtNome.Text.ToUpper();
            funcionario.DataNascimento = dtpDataNascimento.Value;
            funcionario.Numero = txtNumero.Text;
            funcionario.Email = txtEmail.Text.ToUpper();
            funcionario.CPF = txtCPF.Text;
            funcionario.Sexo = cboSexo.Text;
            funcionario.Departamento = cboDepartamento.Text.ToUpper();
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
                if (txtCPF.Text == string.Empty)
                {
                    msgErro += "Campo CPF em branco.\n";
                }
                else if (txtCPF.Text.Length != 11)
                {
                    msgErro += "Campo CPF incompleto. \n";
                }

                else
                {
                    Funcionario f = new Funcionario();
                    f.CPF = txtCPF.Text;
                    f.Consultar();
                    if ((f.Codigo > 0 && funcionario.Codigo == 0)
                        || (f.Codigo > 0 && f.Codigo != funcionario.Codigo))
                    {
                        msgErro += "CPF já cadastrado. \n";
                    }
                }

                if (txtNumero.Text == string.Empty)
                {
                    msgErro += "Campo TELEFONE em branco. \n";
                }
                if (txtEmail.Text == string.Empty)
                {
                    msgErro += "Campo EMAIL em branco. \n";
                }
                if (cboSexo.Text == string.Empty)
                {
                    msgErro += "Campo SEXO em branco. \n";
                }
                if (dtpDataNascimento.Text == string.Empty)
                {
                    msgErro += "Campo DATA DE NASCIMENTO em branco. \n";
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
                funcionario.Gravar();
                MessageBox.Show("Funcionario gravado com sucesso",
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
        private void frmFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Deseja fechar o menu Funcionario?", "Controle_Acesso",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteDigitos(e.KeyChar);
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteDigitos(e.KeyChar);
        }

       
        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
