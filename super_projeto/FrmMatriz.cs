using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Matriz;
using System.IO;

namespace super_projeto
{
    public partial class FrmMatriz : Form
    {
        /// <summary>
        /// Dialog customizada que serve para inicializar matriz.
        /// </summary>
        private FrmInicializaMatriz dlgInicializaMatriz;

        /// <summary>
        /// Matriz utilizada pelo formulário.
        /// </summary>
        private MatrizEsparsa matriz;

        public FrmMatriz()
        {
            InitializeComponent();
            dlgInicializaMatriz = new FrmInicializaMatriz();
        }

        private void btnInicializarManualmente_Click(object sender, EventArgs e)
        {
            if (dlgInicializaMatriz.ShowDialog() == DialogResult.OK)
            {
                this.matriz = new MatrizEsparsa(dlgInicializaMatriz.X, dlgInicializaMatriz.Y);
                ExibirMatriz();
            }
        }

        /// <summary>
        /// Atualiza o DataGrid completamente, limpando todos os dados anteriores e o reinicializando
        /// </summary>
        private void ExibirMatriz()
        {
            // Limpa dados anteriores do DataGrid
            dgMatriz.Columns.Clear();
            dgMatriz.Rows.Clear();

            // Adiciona as colunas
            for (int i = 0; i < matriz.X; i++)
            {
                string nome = i.ToString();
                dgMatriz.Columns.Add(nome, nome);
            }

            dgMatriz.AutoResizeColumns(); // Ajusta o tamanho das colunas

            // Adiciona as linhas
            dgMatriz.Rows.Add(matriz.Y);

            // Adiciona título às linhas
            for (int i = 0; i < matriz.Y; i++)
                dgMatriz.Rows[i].HeaderCell.Value = i.ToString();
            
            // Adiciona os valores da matriz ao dg
            for (int y = 0; y < matriz.Y; y++)
            {
                for (int x = 0; x < matriz.Y; x++)
                    dgMatriz.Rows[y].Cells[x].Value = matriz.ElementoEm(x, y).ToString();
            }
        }
        
        private void btnInicializarArquivo_Click(object sender, EventArgs e)
        {      
            // Inicializa a matriz a partir de um arquivo texto com seus dados.
            // O arquivo deve estar no seguinte formato:
            // 
            // X Y
            // v y v
            // x y v
            // ...
            // 
            // Onde X e Y são os tamanhos horizontal e vertical da matriz e x, y e v são, respectivamente, as posições x e y na matriz de um valor v.
            if (dlgAbrir.ShowDialog(this) == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(dlgAbrir.FileName); // Inicializa um leitor de arquivo.

                string[] tamanho = stream.ReadLine().Split(' '); // Quebra a string inicial em duas, cada uma representando os tamanhos X e Y.

                if (tamanho.Length != 2)
                    throw new FormatException("Arquivo em formato inválido.");

                // Inicializa os nós cabeças com a dimensão especificada no arquivo
                matriz = new MatrizEsparsa(Convert.ToInt32(tamanho[0]), Convert.ToInt32(tamanho[1]));

                // Lê os valores das células
                string linha = "";
                while ((linha = stream.ReadLine()) != null)
                {
                    string[] celula = linha.Split(' ');

                    if (celula.Length != 3) // Verifica se o arquivo possui o número correto de parâmetros
                        throw new FormatException("Arquivo em formato inválido.");

                    // Insere o elemento na matriz.
                    matriz.Inserir(Convert.ToInt32(celula[0]), Convert.ToInt32(celula[1]), Convert.ToDouble(celula[2]));
                }

                ExibirMatriz();
            }
        }

        private void dgMatriz_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell celuladg = dgMatriz.Rows[e.RowIndex].Cells[e.ColumnIndex];

            string valor = (String)celuladg.Value;
            if (String.IsNullOrEmpty(valor) || valor == "0")
            {
                matriz.Remover(e.RowIndex, e.ColumnIndex);
                celuladg.Value = "0";
            }   
            else
                try
                {
                    matriz.Inserir(e.RowIndex, e.ColumnIndex, Convert.ToDouble(valor));
                }
                catch (FormatException err)
                {
                    MessageBox.Show(this, "Formato inválido.", "Erro de inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    celuladg.Value = "0";
                }
        }
    }
}
