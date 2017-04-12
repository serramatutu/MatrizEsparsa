namespace super_projeto
{
    partial class FrmPrincipal
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
            this.cbxMatrizes = new System.Windows.Forms.ComboBox();
            this.btnNovaMatriz = new System.Windows.Forms.Button();
            this.btnExcluirMatriz = new System.Windows.Forms.Button();
            this.btnEditarMatriz = new System.Windows.Forms.Button();
            this.cbxMatriz1 = new System.Windows.Forms.ComboBox();
            this.cbxMatriz2 = new System.Windows.Forms.ComboBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxResultado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxMatrizes
            // 
            this.cbxMatrizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatrizes.FormattingEnabled = true;
            this.cbxMatrizes.Location = new System.Drawing.Point(15, 4);
            this.cbxMatrizes.Name = "cbxMatrizes";
            this.cbxMatrizes.Size = new System.Drawing.Size(59, 21);
            this.cbxMatrizes.TabIndex = 0;
            // 
            // btnNovaMatriz
            // 
            this.btnNovaMatriz.Location = new System.Drawing.Point(15, 31);
            this.btnNovaMatriz.Name = "btnNovaMatriz";
            this.btnNovaMatriz.Size = new System.Drawing.Size(59, 23);
            this.btnNovaMatriz.TabIndex = 1;
            this.btnNovaMatriz.Text = "Nova";
            this.btnNovaMatriz.UseVisualStyleBackColor = true;
            this.btnNovaMatriz.Click += new System.EventHandler(this.btnNovaMatriz_Click);
            // 
            // btnExcluirMatriz
            // 
            this.btnExcluirMatriz.Location = new System.Drawing.Point(80, 31);
            this.btnExcluirMatriz.Name = "btnExcluirMatriz";
            this.btnExcluirMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirMatriz.TabIndex = 3;
            this.btnExcluirMatriz.Text = "Excluir";
            this.btnExcluirMatriz.UseVisualStyleBackColor = true;
            this.btnExcluirMatriz.Click += new System.EventHandler(this.btnExcluirMatriz_Click);
            // 
            // btnEditarMatriz
            // 
            this.btnEditarMatriz.Location = new System.Drawing.Point(80, 2);
            this.btnEditarMatriz.Name = "btnEditarMatriz";
            this.btnEditarMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnEditarMatriz.TabIndex = 4;
            this.btnEditarMatriz.Text = "Editar";
            this.btnEditarMatriz.UseVisualStyleBackColor = true;
            this.btnEditarMatriz.Click += new System.EventHandler(this.btnEditarMatriz_Click);
            // 
            // cbxMatriz1
            // 
            this.cbxMatriz1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatriz1.FormattingEnabled = true;
            this.cbxMatriz1.Location = new System.Drawing.Point(67, 99);
            this.cbxMatriz1.Name = "cbxMatriz1";
            this.cbxMatriz1.Size = new System.Drawing.Size(59, 21);
            this.cbxMatriz1.TabIndex = 5;
            // 
            // cbxMatriz2
            // 
            this.cbxMatriz2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatriz2.FormattingEnabled = true;
            this.cbxMatriz2.Location = new System.Drawing.Point(67, 126);
            this.cbxMatriz2.Name = "cbxMatriz2";
            this.cbxMatriz2.Size = new System.Drawing.Size(59, 21);
            this.cbxMatriz2.TabIndex = 6;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(132, 97);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(59, 23);
            this.btnSomar.TabIndex = 7;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(132, 126);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(59, 23);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Matriz 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Matriz 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Resultado:";
            // 
            // cbxResultado
            // 
            this.cbxResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResultado.FormattingEnabled = true;
            this.cbxResultado.Location = new System.Drawing.Point(67, 153);
            this.cbxResultado.Name = "cbxResultado";
            this.cbxResultado.Size = new System.Drawing.Size(59, 21);
            this.cbxResultado.TabIndex = 12;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 187);
            this.Controls.Add(this.cbxResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.cbxMatriz2);
            this.Controls.Add(this.cbxMatriz1);
            this.Controls.Add(this.btnEditarMatriz);
            this.Controls.Add(this.btnExcluirMatriz);
            this.Controls.Add(this.btnNovaMatriz);
            this.Controls.Add(this.cbxMatrizes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.Text = "Matrizes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMatrizes;
        private System.Windows.Forms.Button btnNovaMatriz;
        private System.Windows.Forms.Button btnExcluirMatriz;
        private System.Windows.Forms.Button btnEditarMatriz;
        private System.Windows.Forms.ComboBox cbxMatriz1;
        private System.Windows.Forms.ComboBox cbxMatriz2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxResultado;
    }
}