namespace Controle_Acesso_Portaria
{
    partial class frmAssociado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssociado));
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.grpPesquisarAssociado = new System.Windows.Forms.GroupBox();
            this.txtPesquisarAssociado = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdAssociado = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grpPesquisarAssociado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssociado)).BeginInit();
            this.grpLista.SuspendLayout();
            this.grpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(8, 31);
            this.lblPesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(229, 25);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisar por Associado";
            // 
            // grpPesquisarAssociado
            // 
            this.grpPesquisarAssociado.Controls.Add(this.txtPesquisarAssociado);
            this.grpPesquisarAssociado.Controls.Add(this.lblPesquisa);
            this.grpPesquisarAssociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisarAssociado.Location = new System.Drawing.Point(35, 28);
            this.grpPesquisarAssociado.Margin = new System.Windows.Forms.Padding(4);
            this.grpPesquisarAssociado.Name = "grpPesquisarAssociado";
            this.grpPesquisarAssociado.Padding = new System.Windows.Forms.Padding(4);
            this.grpPesquisarAssociado.Size = new System.Drawing.Size(756, 75);
            this.grpPesquisarAssociado.TabIndex = 18;
            this.grpPesquisarAssociado.TabStop = false;
            this.grpPesquisarAssociado.Text = "Dados para Pesquisa";
            // 
            // txtPesquisarAssociado
            // 
            this.txtPesquisarAssociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarAssociado.Location = new System.Drawing.Point(261, 25);
            this.txtPesquisarAssociado.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisarAssociado.Name = "txtPesquisarAssociado";
            this.txtPesquisarAssociado.Size = new System.Drawing.Size(479, 34);
            this.txtPesquisarAssociado.TabIndex = 1;
            this.txtPesquisarAssociado.TextChanged += new System.EventHandler(this.txtPesquisarAssociado_TextChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(127, 78);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(187, 34);
            this.txtNumero.TabIndex = 27;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO"});
            this.cboSexo.Location = new System.Drawing.Point(127, 121);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(199, 37);
            this.cboSexo.TabIndex = 26;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(20, 124);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(68, 29);
            this.lblSexo.TabIndex = 25;
            this.lblSexo.Text = "Sexo";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(7, 78);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(110, 29);
            this.lblNumero.TabIndex = 21;
            this.lblNumero.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nome";
            // 
            // grdAssociado
            // 
            this.grdAssociado.AllowUserToAddRows = false;
            this.grdAssociado.AllowUserToDeleteRows = false;
            this.grdAssociado.AllowUserToResizeColumns = false;
            this.grdAssociado.AllowUserToResizeRows = false;
            this.grdAssociado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAssociado.Location = new System.Drawing.Point(-3, 29);
            this.grdAssociado.Margin = new System.Windows.Forms.Padding(4);
            this.grdAssociado.MultiSelect = false;
            this.grdAssociado.Name = "grdAssociado";
            this.grdAssociado.ReadOnly = true;
            this.grdAssociado.RowHeadersVisible = false;
            this.grdAssociado.RowHeadersWidth = 51;
            this.grdAssociado.Size = new System.Drawing.Size(946, 200);
            this.grdAssociado.TabIndex = 0;
            this.grdAssociado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAssociado_CellClick);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(111, 31);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(625, 34);
            this.txtNome.TabIndex = 14;
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.grdAssociado);
            this.grpLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLista.Location = new System.Drawing.Point(16, 111);
            this.grpLista.Margin = new System.Windows.Forms.Padding(4);
            this.grpLista.Name = "grpLista";
            this.grpLista.Padding = new System.Windows.Forms.Padding(4);
            this.grpLista.Size = new System.Drawing.Size(977, 246);
            this.grpLista.TabIndex = 19;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Associados Cadastrados";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.pictureBox1);
            this.grpDados.Controls.Add(this.lblDepartamento);
            this.grpDados.Controls.Add(this.cboDepartamento);
            this.grpDados.Controls.Add(this.txtNumero);
            this.grpDados.Controls.Add(this.cboSexo);
            this.grpDados.Controls.Add(this.lblSexo);
            this.grpDados.Controls.Add(this.lblNumero);
            this.grpDados.Controls.Add(this.label5);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDados.Location = new System.Drawing.Point(23, 364);
            this.grpDados.Margin = new System.Windows.Forms.Padding(4);
            this.grpDados.Name = "grpDados";
            this.grpDados.Padding = new System.Windows.Forms.Padding(4);
            this.grpDados.Size = new System.Drawing.Size(963, 230);
            this.grpDados.TabIndex = 20;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Cadastrar um novo Associado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Controle_Acesso_Portaria.Properties.Resources.ass2;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(771, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(20, 180);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(165, 29);
            this.lblDepartamento.TabIndex = 29;
            this.lblDepartamento.Text = "Departamento";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            "ADMINISTRAÇÃO",
            "RHSOLUCÕES",
            "ESTOQUE",
            "QUALIDADEECONTROLE",
            "GESTÃODEPROJETO",
            "AUDITORIAINTERNA",
            "CONTABILIDADE",
            "RECEPÇÃO",
            "RHINFO",
            "TELEMARKETING"});
            this.cboDepartamento.Location = new System.Drawing.Point(199, 176);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(299, 37);
            this.cboDepartamento.TabIndex = 28;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Controle_Acesso_Portaria.Properties.Resources.delete;
            this.btnCancelar.Location = new System.Drawing.Point(48, 613);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 53);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::Controle_Acesso_Portaria.Properties.Resources.eraser2;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(344, 613);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 53);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Image = global::Controle_Acesso_Portaria.Properties.Resources.floppy_disk2;
            this.btnGravar.Location = new System.Drawing.Point(832, 613);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(153, 53);
            this.btnGravar.TabIndex = 21;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNome.Location = new System.Drawing.Point(832, 53);
            this.rdbNome.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(85, 29);
            this.rdbNome.TabIndex = 19;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::Controle_Acesso_Portaria.Properties.Resources.pesquisa;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(567, 613);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(180, 53);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmAssociado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.rdbNome);
            this.Controls.Add(this.grpPesquisarAssociado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.grpDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAssociado";
            this.Text = "Associado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAssociado_FormClosing);
            this.Load += new System.EventHandler(this.frmAssociado_Load);
            this.grpPesquisarAssociado.ResumeLayout(false);
            this.grpPesquisarAssociado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssociado)).EndInit();
            this.grpLista.ResumeLayout(false);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.GroupBox grpPesquisarAssociado;
        private System.Windows.Forms.TextBox txtPesquisarAssociado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdAssociado;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.Button btnPesquisar;
    }
}