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
    public partial class FrmInicializaMatriz : Form
    {
        public FrmInicializaMatriz()
        {
            InitializeComponent();
        }

        private void btnInicializarMatriz_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int X
        {
            get
            {
                return (int)ndX.Value;
            }
        }

        public int Y
        {
            get
            {
                return (int)ndY.Value;
            }
        }
    }
}
