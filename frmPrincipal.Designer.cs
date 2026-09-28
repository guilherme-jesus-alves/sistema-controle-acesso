namespace Controle_Acesso_Portaria
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.associadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correspondênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBanco = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuario,
            this.mnuVisitante,
            this.mnuFuncionario,
            this.mnuConsulta,
            this.associadoToolStripMenuItem,
            this.correspondênciaToolStripMenuItem,
            this.mnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(907, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuUsuario
            // 
            this.mnuUsuario.Image = global::Controle_Acesso_Portaria.Properties.Resources.businessman;
            this.mnuUsuario.Name = "mnuUsuario";
            this.mnuUsuario.Size = new System.Drawing.Size(93, 24);
            this.mnuUsuario.Text = "Usuário";
            this.mnuUsuario.Click += new System.EventHandler(this.mnuUsuario_Click);
            // 
            // mnuVisitante
            // 
            this.mnuVisitante.Image = global::Controle_Acesso_Portaria.Properties.Resources.visitante;
            this.mnuVisitante.Name = "mnuVisitante";
            this.mnuVisitante.Size = new System.Drawing.Size(100, 24);
            this.mnuVisitante.Text = "Visitante";
            this.mnuVisitante.Click += new System.EventHandler(this.mnuVisitante_Click);
            // 
            // mnuFuncionario
            // 
            this.mnuFuncionario.Image = global::Controle_Acesso_Portaria.Properties.Resources.funcionario;
            this.mnuFuncionario.Name = "mnuFuncionario";
            this.mnuFuncionario.Size = new System.Drawing.Size(120, 24);
            this.mnuFuncionario.Text = "Funcionario";
            this.mnuFuncionario.Click += new System.EventHandler(this.mnuFuncionario_Click);
            // 
            // mnuConsulta
            // 
            this.mnuConsulta.Image = global::Controle_Acesso_Portaria.Properties.Resources.note;
            this.mnuConsulta.Name = "mnuConsulta";
            this.mnuConsulta.Size = new System.Drawing.Size(105, 24);
            this.mnuConsulta.Text = "Consultar";
            this.mnuConsulta.Click += new System.EventHandler(this.mnuConsulta_Click);
            // 
            // associadoToolStripMenuItem
            // 
            this.associadoToolStripMenuItem.Image = global::Controle_Acesso_Portaria.Properties.Resources.businessman3;
            this.associadoToolStripMenuItem.Name = "associadoToolStripMenuItem";
            this.associadoToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.associadoToolStripMenuItem.Text = "Associado";
            this.associadoToolStripMenuItem.Click += new System.EventHandler(this.associadoToolStripMenuItem_Click);
            // 
            // correspondênciaToolStripMenuItem
            // 
            this.correspondênciaToolStripMenuItem.Image = global::Controle_Acesso_Portaria.Properties.Resources.carta2;
            this.correspondênciaToolStripMenuItem.Name = "correspondênciaToolStripMenuItem";
            this.correspondênciaToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.correspondênciaToolStripMenuItem.Text = "Correspondência";
            this.correspondênciaToolStripMenuItem.Click += new System.EventHandler(this.correspondênciaToolStripMenuItem_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Image = global::Controle_Acesso_Portaria.Properties.Resources.sair;
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(68, 24);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // tmrTempo
            // 
            this.tmrTempo.Enabled = true;
            this.tmrTempo.Interval = 1000;
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(410, 24);
            this.lblUsuario.Spring = true;
            this.lblUsuario.Text = "Usuário:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBanco
            // 
            this.lblBanco.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(410, 24);
            this.lblBanco.Spring = true;
            this.lblBanco.Text = "Banco de Dados:";
            this.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTempo
            // 
            this.lblTempo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(67, 24);
            this.lblTempo.Text = "00:00:00";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblBanco,
            this.lblTempo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(907, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Controle_Acesso_Portaria.Properties.Resources.img1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(907, 506);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuVisitante;
        private System.Windows.Forms.ToolStripMenuItem mnuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuConsulta;
        private System.Windows.Forms.Timer tmrTempo;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblBanco;
        private System.Windows.Forms.ToolStripStatusLabel lblTempo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem associadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correspondênciaToolStripMenuItem;
    }
}