namespace super_projeto
{
    partial class FrmMatriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatriz));
            this.dgMatriz = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnInicializar = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnInicializarManualmente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInicializarArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.dgHue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMatriz
            // 
            this.dgMatriz.AllowUserToAddRows = false;
            this.dgMatriz.AllowUserToDeleteRows = false;
            this.dgMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatriz.Location = new System.Drawing.Point(13, 28);
            this.dgMatriz.Name = "dgMatriz";
            this.dgMatriz.Size = new System.Drawing.Size(518, 522);
            this.dgMatriz.TabIndex = 0;
            this.dgMatriz.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMatriz_CellEndEdit);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicializar,
            this.btnSalvar});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1104, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnInicializar
            // 
            this.btnInicializar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInicializar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicializarManualmente,
            this.btnInicializarArquivo});
            this.btnInicializar.Image = ((System.Drawing.Image)(resources.GetObject("btnInicializar.Image")));
            this.btnInicializar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(69, 22);
            this.btnInicializar.Text = "Inicializar";
            // 
            // btnInicializarManualmente
            // 
            this.btnInicializarManualmente.Name = "btnInicializarManualmente";
            this.btnInicializarManualmente.Size = new System.Drawing.Size(152, 22);
            this.btnInicializarManualmente.Text = "Manualmente";
            this.btnInicializarManualmente.Click += new System.EventHandler(this.btnInicializarManualmente_Click);
            // 
            // btnInicializarArquivo
            // 
            this.btnInicializarArquivo.Name = "btnInicializarArquivo";
            this.btnInicializarArquivo.Size = new System.Drawing.Size(152, 22);
            this.btnInicializarArquivo.Text = "Arquivo";
            this.btnInicializarArquivo.Click += new System.EventHandler(this.btnInicializarArquivo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(42, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.DefaultExt = "Arquivo Texto | *.txt";
            this.dlgAbrir.Filter = "Arquivo Texto | *.txt";
            // 
            // dlgSalvar
            // 
            this.dlgSalvar.DefaultExt = "Matriz|*.mz";
            this.dlgSalvar.Filter = "Matriz|*.mz";
            // 
            // dgHue
            // 
            this.dgHue.AllowUserToAddRows = false;
            this.dgHue.AllowUserToDeleteRows = false;
            this.dgHue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgHue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHue.Location = new System.Drawing.Point(537, 28);
            this.dgHue.Name = "dgHue";
            this.dgHue.Size = new System.Drawing.Size(555, 522);
            this.dgHue.TabIndex = 2;
            // 
            // FrmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 562);
            this.Controls.Add(this.dgHue);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dgMatriz);
            this.Name = "FrmMatriz";
            this.Text = "Matriz";
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMatriz;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton btnInicializar;
        private System.Windows.Forms.ToolStripMenuItem btnInicializarManualmente;
        private System.Windows.Forms.ToolStripMenuItem btnInicializarArquivo;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.DataGridView dgHue;
    }
}

