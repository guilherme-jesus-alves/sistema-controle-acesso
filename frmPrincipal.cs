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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        DateTime dataInicial;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dataInicial = DateTime.Now;
            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            lblUsuario.Text = string.Format("Usuário: {0} ({1})",
                Global.nome, Global.usuario);
            lblBanco.Text = string.Format("Banco de dados: {0}",
                Global.banco);
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - dataInicial;
            lblTempo.Text = string.Format("Tempo Login - {0}:{1}:{2}",
                ts.Hours.ToString("00"),
                ts.Minutes.ToString("00"),
                ts.Seconds.ToString("00"));
        }
        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Deseja encerrar a aplicação?", "Controle_Acesso",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
       private void AbrirFormulario(Form form)
        {
            bool existe = false;
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.Name == form.Name)
                {
                    existe = true;
                    filho.BringToFront();
                    break;
                }
            }
            if (!existe)
            {
                this.IsMdiContainer = true;
                form.MdiParent = this;
                form.Show();
            }
        }

        private void mnuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmUsuario());
        }
        private void mnuVisitante_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmVisitante());
        }

        private void mnuFuncionario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmFuncionario());
        }

        private void mnuConsulta_Click(object sender, EventArgs e)
        {
                AbrirFormulario(new frmConsulta());
        }

        private void associadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAssociado());
        }

        private void correspondênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCorrespondencia());
        }
    }
}
