namespace super_projeto
{
    partial class FrmInicializaMatriz
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
            this.ndX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ndY = new System.Windows.Forms.NumericUpDown();
            this.btnInicializarMatriz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndY)).BeginInit();
            this.SuspendLayout();
            // 
            // ndX
            // 
            this.ndX.Location = new System.Drawing.Point(35, 7);
            this.ndX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ndX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndX.Name = "ndX";
            this.ndX.Size = new System.Drawing.Size(120, 20);
            this.ndX.TabIndex = 0;
            this.ndX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Y:";
            // 
            // ndY
            // 
            this.ndY.Location = new System.Drawing.Point(35, 33);
            this.ndY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ndY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndY.Name = "ndY";
            this.ndY.Size = new System.Drawing.Size(120, 20);
            this.ndY.TabIndex = 3;
            this.ndY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnInicializarMatriz
            // 
            this.btnInicializarMatriz.Location = new System.Drawing.Point(15, 59);
            this.btnInicializarMatriz.Name = "btnInicializarMatriz";
            this.btnInicializarMatriz.Size = new System.Drawing.Size(140, 23);
            this.btnInicializarMatriz.TabIndex = 5;
            this.btnInicializarMatriz.Text = "Inicializar Matriz";
            this.btnInicializarMatriz.UseVisualStyleBackColor = true;
            this.btnInicializarMatriz.Click += new System.EventHandler(this.btnInicializarMatriz_Click);
            // 
            // FrmInicializaMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 92);
            this.Controls.Add(this.btnInicializarMatriz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ndY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ndX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInicializaMatriz";
            this.Text = "Inicializar Matriz";
            ((System.ComponentModel.ISupportInitialize)(this.ndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ndX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ndY;
        private System.Windows.Forms.Button btnInicializarMatriz;
    }
}