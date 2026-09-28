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
    public partial class frmVisitante : Form
    {
       // Visitante visitante = new Visitante();
        public frmVisitante()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            visitante = new Visitante();
            txtNome.Clear();
            txtRG.Clear();
            cboSexo.SelectedIndex = -1;
            cboDepartamento.SelectedIndex = -1;      
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        Visitante visitante = new Visitante();

        private void frmVisitante_Load(object sender, EventArgs e)
        {
            
        }
        private void PreencherClasse()
        {
            visitante.Nome = txtNome.Text.ToUpper();
            visitante.RG = txtRG.Text;
            visitante.Sexo = cboSexo.Text;
            visitante.Departamento = cboDepartamento.Text;
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

                if (txtRG.Text == string.Empty)
                {
                    msgErro += "Campo RG em branco.\n";
                }
                else if (txtRG.Text.Length != 9)
                {
                    msgErro += "Campo RG incompleto. \n";
                }

                else
                {
                    Visitante v = new Visitante();
                    v.RG = txtRG.Text;
                    v.Consultar();
                    if ((v.Codigo > 0 && visitante.Codigo == 0)
                        || (v.Codigo > 0 && v.Codigo != visitante.Codigo))
                    {
                        msgErro += "RG já cadastrado. \n";
                    }
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
                visitante.Gravar();
                MessageBox.Show("Visitante gravado com sucesso",
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

        private void frmVisitante_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Deseja fechar o menu Visitante?", "Controle_Acesso",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteDigitos(e.KeyChar);

        }
    }
    
}
