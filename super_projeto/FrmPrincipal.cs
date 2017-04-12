using Matriz;
using System;
using System.Windows.Forms;

namespace super_projeto
{
    public partial class FrmPrincipal : Form
    {
        const int MAX_MATRIZES = 20;

        private MatrizEsparsa[] matrizes = new MatrizEsparsa[MAX_MATRIZES];
        private int quantasMatrizes = 0;

        private FrmInicializaMatriz dlgInicializaMatriz = new FrmInicializaMatriz();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Atualiza os ComboBoxes que contêm a lista de matrizes
        /// </summary>
        private void AtualizaComboBox()
        {
            cbxMatrizes.Items.Clear();
            cbxMatriz1.Items.Clear();
            cbxMatriz2.Items.Clear();
            cbxResultado.Items.Clear();

            for (int i=0; i<quantasMatrizes; i++)
            {
                cbxMatriz1.Items.Add(i.ToString());
                cbxMatriz2.Items.Add(i.ToString());
                cbxMatrizes.Items.Add(i.ToString());
                cbxResultado.Items.Add(i.ToString());
            }

            if (quantasMatrizes > 0)
            {
                cbxMatriz1.SelectedIndex = 0;
                cbxMatriz2.SelectedIndex = 0;
                cbxMatrizes.SelectedIndex = 0;
                cbxResultado.SelectedIndex = 0;
            }
        }

        private void btnNovaMatriz_Click(object sender, System.EventArgs e)
        {
            if (quantasMatrizes > matrizes.Length)
            {
                MessageBox.Show("Quantidade máxima de matrizes excedida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dlgInicializaMatriz.ShowDialog() == DialogResult.OK)
            {
                matrizes[quantasMatrizes] = new MatrizEsparsa(dlgInicializaMatriz.X, dlgInicializaMatriz.Y);
                quantasMatrizes++;

                AtualizaComboBox();
            }
        }

        private void btnExcluirMatriz_Click(object sender, EventArgs e)
        {
            if (quantasMatrizes <= 0)
            {
                MessageBox.Show("Lista de matrizes vazia. Não é possível remover uma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            quantasMatrizes--;

            // Exclui a matriz desejada do vetor
            for (int i=cbxMatrizes.SelectedIndex; i<quantasMatrizes; i++)
                matrizes[i] = matrizes[i + 1];

            AtualizaComboBox();
        }

        private void btnEditarMatriz_Click(object sender, EventArgs e)
        {
            if (quantasMatrizes == 0)
                MessageBox.Show("Não há matriz selecioada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FrmMatriz form = new FrmMatriz(matrizes[cbxMatrizes.SelectedIndex]);
            if (form.ShowDialog() == DialogResult.OK)
            {
                matrizes[cbxMatrizes.SelectedIndex] = form.Matriz;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (quantasMatrizes <= 0)
                throw new InvalidOperationException();

            matrizes[cbxResultado.SelectedIndex] = matrizes[cbxMatriz1.SelectedIndex].Somar(matrizes[cbxMatriz2.SelectedIndex]);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (quantasMatrizes <= 0)
                MessageBox.Show("Não há matrizes disponíveis.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            matrizes[cbxResultado.SelectedIndex] = matrizes[cbxMatriz1.SelectedIndex].Multiplicar(matrizes[cbxMatriz2.SelectedIndex]);
        }
    }
}
