namespace Controle_Acesso_Portaria
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.txtConsultarVisitante = new System.Windows.Forms.TextBox();
            this.lblVisitante = new System.Windows.Forms.Label();
            this.grpConsultarVisitante = new System.Windows.Forms.GroupBox();
            this.grdVisitante = new System.Windows.Forms.DataGridView();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.grpConsultarFuncionario = new System.Windows.Forms.GroupBox();
            this.grdFuncionario = new System.Windows.Forms.DataGridView();
            this.txtConsultarFuncionario = new System.Windows.Forms.TextBox();
            this.rdbNomeVisitante = new System.Windows.Forms.RadioButton();
            this.rdbRG = new System.Windows.Forms.RadioButton();
            this.rdbNomeFuncionario = new System.Windows.Forms.RadioButton();
            this.rdbCPF = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCpfCnpj = new System.Windows.Forms.RadioButton();
            this.btnConsultarVisitante = new System.Windows.Forms.Button();
            this.btnLimparVis = new System.Windows.Forms.Button();
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            this.btnLimparFun = new System.Windows.Forms.Button();
            this.btnCancelarVis = new System.Windows.Forms.Button();
            this.btnCancelarFun = new System.Windows.Forms.Button();
            this.grpConsultarVisitante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVisitante)).BeginInit();
            this.grpConsultarFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsultarVisitante
            // 
            this.txtConsultarVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarVisitante.Location = new System.Drawing.Point(265, 21);
            this.txtConsultarVisitante.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultarVisitante.Name = "txtConsultarVisitante";
            this.txtConsultarVisitante.Size = new System.Drawing.Size(424, 30);
            this.txtConsultarVisitante.TabIndex = 4;
            this.txtConsultarVisitante.TextChanged += new System.EventHandler(this.txtConsultarVisitante_TextChanged);
            // 
            // lblVisitante
            // 
            this.lblVisitante.AutoSize = true;
            this.lblVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitante.Location = new System.Drawing.Point(24, 21);
            this.lblVisitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisitante.Name = "lblVisitante";
            this.lblVisitante.Size = new System.Drawing.Size(212, 25);
            this.lblVisitante.TabIndex = 5;
            this.lblVisitante.Text = "Pesquisar por Visitante";
            // 
            // grpConsultarVisitante
            // 
            this.grpConsultarVisitante.Controls.Add(this.grdVisitante);
            this.grpConsultarVisitante.Location = new System.Drawing.Point(21, 60);
            this.grpConsultarVisitante.Margin = new System.Windows.Forms.Padding(4);
            this.grpConsultarVisitante.Name = "grpConsultarVisitante";
            this.grpConsultarVisitante.Padding = new System.Windows.Forms.Padding(4);
            this.grpConsultarVisitante.Size = new System.Drawing.Size(928, 239);
            this.grpConsultarVisitante.TabIndex = 6;
            this.grpConsultarVisitante.TabStop = false;
            this.grpConsultarVisitante.Text = "Visitante Cadastrado";
            // 
            // grdVisitante
            // 
            this.grdVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVisitante.Location = new System.Drawing.Point(8, 23);
            this.grdVisitante.Margin = new System.Windows.Forms.Padding(4);
            this.grdVisitante.Name = "grdVisitante";
            this.grdVisitante.RowHeadersWidth = 51;
            this.grdVisitante.Size = new System.Drawing.Size(912, 208);
            this.grdVisitante.TabIndex = 0;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(24, 398);
            this.lblFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(239, 25);
            this.lblFuncionario.TabIndex = 16;
            this.lblFuncionario.Text = "Pesquisar por Funcionario";
            // 
            // grpConsultarFuncionario
            // 
            this.grpConsultarFuncionario.Controls.Add(this.grdFuncionario);
            this.grpConsultarFuncionario.Location = new System.Drawing.Point(21, 436);
            this.grpConsultarFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.grpConsultarFuncionario.Name = "grpConsultarFuncionario";
            this.grpConsultarFuncionario.Padding = new System.Windows.Forms.Padding(4);
            this.grpConsultarFuncionario.Size = new System.Drawing.Size(928, 239);
            this.grpConsultarFuncionario.TabIndex = 15;
            this.grpConsultarFuncionario.TabStop = false;
            this.grpConsultarFuncionario.Text = "Funcionario Cadastrado";
            // 
            // grdFuncionario
            // 
            this.grdFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFuncionario.Location = new System.Drawing.Point(8, 23);
            this.grdFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.grdFuncionario.Name = "grdFuncionario";
            this.grdFuncionario.RowHeadersWidth = 51;
            this.grdFuncionario.Size = new System.Drawing.Size(912, 208);
            this.grdFuncionario.TabIndex = 1;
            // 
            // txtConsultarFuncionario
            // 
            this.txtConsultarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarFuncionario.Location = new System.Drawing.Point(283, 399);
            this.txtConsultarFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultarFuncionario.Name = "txtConsultarFuncionario";
            this.txtConsultarFuncionario.Size = new System.Drawing.Size(424, 30);
            this.txtConsultarFuncionario.TabIndex = 14;
            this.txtConsultarFuncionario.TextChanged += new System.EventHandler(this.txtConsultarFuncionario_TextChanged);
            // 
            // rdbNomeVisitante
            // 
            this.rdbNomeVisitante.AutoSize = true;
            this.rdbNomeVisitante.Location = new System.Drawing.Point(748, 28);
            this.rdbNomeVisitante.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNomeVisitante.Name = "rdbNomeVisitante";
            this.rdbNomeVisitante.Size = new System.Drawing.Size(65, 20);
            this.rdbNomeVisitante.TabIndex = 18;
            this.rdbNomeVisitante.TabStop = true;
            this.rdbNomeVisitante.Text = "Nome";
            this.rdbNomeVisitante.UseVisualStyleBackColor = true;
            // 
            // rdbRG
            // 
            this.rdbRG.AutoSize = true;
            this.rdbRG.Checked = true;
            this.rdbRG.Location = new System.Drawing.Point(839, 28);
            this.rdbRG.Margin = new System.Windows.Forms.Padding(4);
            this.rdbRG.Name = "rdbRG";
            this.rdbRG.Size = new System.Drawing.Size(48, 20);
            this.rdbRG.TabIndex = 17;
            this.rdbRG.TabStop = true;
            this.rdbRG.Text = "RG";
            this.rdbRG.UseVisualStyleBackColor = true;
            // 
            // rdbNomeFuncionario
            // 
            this.rdbNomeFuncionario.AutoSize = true;
            this.rdbNomeFuncionario.Location = new System.Drawing.Point(748, 399);
            this.rdbNomeFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNomeFuncionario.Name = "rdbNomeFuncionario";
            this.rdbNomeFuncionario.Size = new System.Drawing.Size(65, 20);
            this.rdbNomeFuncionario.TabIndex = 20;
            this.rdbNomeFuncionario.TabStop = true;
            this.rdbNomeFuncionario.Text = "Nome";
            this.rdbNomeFuncionario.UseVisualStyleBackColor = true;
            // 
            // rdbCPF
            // 
            this.rdbCPF.AutoSize = true;
            this.rdbCPF.Checked = true;
            this.rdbCPF.Location = new System.Drawing.Point(839, 399);
            this.rdbCPF.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCPF.Name = "rdbCPF";
            this.rdbCPF.Size = new System.Drawing.Size(54, 20);
            this.rdbCPF.TabIndex = 19;
            this.rdbCPF.TabStop = true;
            this.rdbCPF.Text = "CPF";
            this.rdbCPF.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(293, -354);
            this.rdbNome.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(65, 20);
            this.rdbNome.TabIndex = 22;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // rdbCpfCnpj
            // 
            this.rdbCpfCnpj.AutoSize = true;
            this.rdbCpfCnpj.Checked = true;
            this.rdbCpfCnpj.Location = new System.Drawing.Point(183, -353);
            this.rdbCpfCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCpfCnpj.Name = "rdbCpfCnpj";
            this.rdbCpfCnpj.Size = new System.Drawing.Size(93, 20);
            this.rdbCpfCnpj.TabIndex = 21;
            this.rdbCpfCnpj.TabStop = true;
            this.rdbCpfCnpj.Text = "CPF/CNPJ";
            this.rdbCpfCnpj.UseVisualStyleBackColor = true;
            // 
            // btnConsultarVisitante
            // 
            this.btnConsultarVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVisitante.Image = global::Controle_Acesso_Portaria.Properties.Resources.find;
            this.btnConsultarVisitante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarVisitante.Location = new System.Drawing.Point(615, 311);
            this.btnConsultarVisitante.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarVisitante.Name = "btnConsultarVisitante";
            this.btnConsultarVisitante.Size = new System.Drawing.Size(157, 62);
            this.btnConsultarVisitante.TabIndex = 25;
            this.btnConsultarVisitante.Text = "&Consultar";
            this.btnConsultarVisitante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarVisitante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarVisitante.UseVisualStyleBackColor = true;
            this.btnConsultarVisitante.Click += new System.EventHandler(this.btnConsultarVisitante_Click);
            // 
            // btnLimparVis
            // 
            this.btnLimparVis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparVis.Image = global::Controle_Acesso_Portaria.Properties.Resources.eraser2;
            this.btnLimparVis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparVis.Location = new System.Drawing.Point(397, 307);
            this.btnLimparVis.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparVis.Name = "btnLimparVis";
            this.btnLimparVis.Size = new System.Drawing.Size(139, 62);
            this.btnLimparVis.TabIndex = 24;
            this.btnLimparVis.Text = "&Limpar";
            this.btnLimparVis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparVis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparVis.UseVisualStyleBackColor = true;
            this.btnLimparVis.Click += new System.EventHandler(this.btnLimparVis_Click);
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFuncionario.Image = global::Controle_Acesso_Portaria.Properties.Resources.find;
            this.btnConsultarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(615, 706);
            this.btnConsultarFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(157, 62);
            this.btnConsultarFuncionario.TabIndex = 28;
            this.btnConsultarFuncionario.Text = "&Consultar";
            this.btnConsultarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarFuncionario.UseVisualStyleBackColor = true;
            this.btnConsultarFuncionario.Click += new System.EventHandler(this.btnConsultarFuncionario_Click);
            // 
            // btnLimparFun
            // 
            this.btnLimparFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFun.Image = global::Controle_Acesso_Portaria.Properties.Resources.eraser2;
            this.btnLimparFun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparFun.Location = new System.Drawing.Point(397, 706);
            this.btnLimparFun.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparFun.Name = "btnLimparFun";
            this.btnLimparFun.Size = new System.Drawing.Size(139, 62);
            this.btnLimparFun.TabIndex = 27;
            this.btnLimparFun.Text = "&Limpar";
            this.btnLimparFun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparFun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparFun.UseVisualStyleBackColor = true;
            this.btnLimparFun.Click += new System.EventHandler(this.btnLimparFun_Click);
            // 
            // btnCancelarVis
            // 
            this.btnCancelarVis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarVis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVis.Image = global::Controle_Acesso_Portaria.Properties.Resources.delete;
            this.btnCancelarVis.Location = new System.Drawing.Point(87, 307);
            this.btnCancelarVis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarVis.Name = "btnCancelarVis";
            this.btnCancelarVis.Size = new System.Drawing.Size(149, 62);
            this.btnCancelarVis.TabIndex = 29;
            this.btnCancelarVis.Text = "Cancelar";
            this.btnCancelarVis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarVis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarVis.UseVisualStyleBackColor = true;
            this.btnCancelarVis.Click += new System.EventHandler(this.btnCancelarVis_Click);
            // 
            // btnCancelarFun
            // 
            this.btnCancelarFun.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFun.Image = global::Controle_Acesso_Portaria.Properties.Resources.delete;
            this.btnCancelarFun.Location = new System.Drawing.Point(87, 706);
            this.btnCancelarFun.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarFun.Name = "btnCancelarFun";
            this.btnCancelarFun.Size = new System.Drawing.Size(149, 62);
            this.btnCancelarFun.TabIndex = 30;
            this.btnCancelarFun.Text = "Cancelar";
            this.btnCancelarFun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarFun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarFun.UseVisualStyleBackColor = true;
            this.btnCancelarFun.Click += new System.EventHandler(this.btnCancelarFun_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 782);
            this.Controls.Add(this.btnCancelarFun);
            this.Controls.Add(this.btnCancelarVis);
            this.Controls.Add(this.btnConsultarFuncionario);
            this.Controls.Add(this.btnLimparFun);
            this.Controls.Add(this.rdbNome);
            this.Controls.Add(this.rdbCpfCnpj);
            this.Controls.Add(this.btnConsultarVisitante);
            this.Controls.Add(this.btnLimparVis);
            this.Controls.Add(this.rdbNomeFuncionario);
            this.Controls.Add(this.rdbCPF);
            this.Controls.Add(this.rdbNomeVisitante);
            this.Controls.Add(this.rdbRG);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.grpConsultarFuncionario);
            this.Controls.Add(this.txtConsultarFuncionario);
            this.Controls.Add(this.grpConsultarVisitante);
            this.Controls.Add(this.lblVisitante);
            this.Controls.Add(this.txtConsultarVisitante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsulta_FormClosing);
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.grpConsultarVisitante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVisitante)).EndInit();
            this.grpConsultarFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsultarVisitante;
        private System.Windows.Forms.Label lblVisitante;
        private System.Windows.Forms.GroupBox grpConsultarVisitante;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.GroupBox grpConsultarFuncionario;
        private System.Windows.Forms.TextBox txtConsultarFuncionario;
        private System.Windows.Forms.DataGridView grdVisitante;
        private System.Windows.Forms.DataGridView grdFuncionario;
        private System.Windows.Forms.RadioButton rdbNomeVisitante;
        private System.Windows.Forms.RadioButton rdbRG;
        private System.Windows.Forms.RadioButton rdbNomeFuncionario;
        private System.Windows.Forms.RadioButton rdbCPF;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCpfCnpj;
        private System.Windows.Forms.Button btnConsultarVisitante;
        private System.Windows.Forms.Button btnLimparVis;
        private System.Windows.Forms.Button btnConsultarFuncionario;
        private System.Windows.Forms.Button btnLimparFun;
        private System.Windows.Forms.Button btnCancelarVis;
        private System.Windows.Forms.Button btnCancelarFun;
    }
}