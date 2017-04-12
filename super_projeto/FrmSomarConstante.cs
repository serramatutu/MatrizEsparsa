using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace super_projeto
{
    public partial class FrmSomarConstante : Form
    {
        double constante = 0;

        public FrmSomarConstante(int qtdColunas)
        {
            InitializeComponent();
            ndColuna.Maximum = qtdColunas - 1;
        }

        public double Constante
        {
            get
            {
                return constante;
            }
        }

        public int Coluna
        {
            get
            {
                return (int)ndColuna.Value;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                constante = Convert.ToDouble(txtConstante.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException err)
            {
                MessageBox.Show("Formato inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
