using System;
using System.Data;

namespace Matriz
{
    /// <summary>
    /// Classe encapsuladora das listas de células. Representa uma matriz esparsa.
    /// </summary>
    class MatrizEsparsa
    {
        private Celula<double> inicio;

        private int x, y;

        /// <summary>
        /// Accessor para a dimensão X da matriz.
        /// </summary>
        public int X
        {
            get { return x; }
        }

        /// <summary>
        /// Accessor para a dimesão Y da matriz.
        /// </summary>
        public int Y
        {
            get { return y; }
        }

        /// <summary>
        /// Construtor que inicializa a matriz.
        /// </summary>
        /// <param name="x">Tamanho horizontal da matriz.</param>
        /// <param name="y">Tamanho vertical da matriz.</param>
        public MatrizEsparsa(int x, int y)
        {
            inicio = new Celula<double>(-1, -1, null, null);

            if (x < 1 || y < 1)
                throw new ArgumentOutOfRangeException("Tamanho de matriz inválido.");

            // Primeiro, define os tamanhos de cada dimensão da matriz
            this.x = x;
            this.y = y;

            // Para nós cabeça horizontais
            Celula atual = inicio;
            for (int i = 0; i < x; i++)
            {
                atual.Direita = new Celula<double>(i, -1, null, null);
                atual = atual.Direita;
                atual.Abaixo = atual; // Faz com que o nó referencie ele mesmo na direção para baixo.
            }
            atual.Direita = inicio; // Finalmente, faz com que o último referencie o primeiro e transforma a lista em circular.

            // Para nós cabeça verticais
            atual = inicio;
            for (int i = 0; i < y; i++)
            {
                atual.Abaixo = new Celula<double>(-1, i, null, null);
                atual = atual.Abaixo;
                atual.Direita = atual; // Faz com que o nó referencie ele mesmo na direção para a direita.
            }
            atual.Abaixo = inicio; // Finalmente, faz com que o último referencie o primeiro e transforma a lista em circular.
        }

        /// <summary>
        /// Adiciona ou edita uma célula na matriz, na posição passada como parâmetro
        /// </summary>
        /// <param name="x">Posição X na matriz</param>
        /// <param name="y">Posição Y na matriz</param>
        public void Inserir(int x, int y, double valor)
        {
            if (x >= this.x || x < 0)
                throw new ArgumentOutOfRangeException("X fora de intervalo: [0, " + this.x + "[");
            if (y >= this.y || y < 0)
                throw new ArgumentOutOfRangeException("Y fora de intervalo: [0, " + this.y + "[");

            Celula<double> nova = new Celula<double>(x, y, null, null, valor);

            //Chega na posição X nescessária
            Celula atual = inicio;
            while (atual.X < x)
                atual = atual.Direita;

            while (atual.Abaixo.Y != -1 && atual.Abaixo.Y < y)
                atual = atual.Abaixo;

            if (atual.Abaixo.Y == -1)
            {
                nova.Abaixo = atual.Abaixo;
                atual.Abaixo = nova;
            }
            else if (atual.Abaixo.Y == y)
                ((Celula<double>)atual).Info = valor;

            atual = inicio;
            while (atual.Y < y)
                atual = atual.Abaixo;

            while (atual.Direita.X != -1 && atual.Direita.X < x)
                atual = atual.Direita;

            if (atual.Direita.X == -1)
            {
                nova.Direita = atual.Direita;
                atual.Direita = nova;
            }
            else if (atual.Direita.X == x)
                ((Celula<double>)atual).Info = valor;
        }


        /// <summary>
        /// Remove um elemento da posição especificada, caso exista. Caso não exista, não lança exceção (por conveniência).
        /// </summary>
        /// <param name="x">Posição X na matriz</param>
        /// <param name="y">Posição I na matriz</param>
        public void Remover(int x, int y)
        {
            if (x >= this.x || x < 0)
                throw new ArgumentOutOfRangeException("X fora de intervalo: [0, " + this.x + "[");
            if (y >= this.y || y < 0)
                throw new ArgumentOutOfRangeException("Y fora de intervalo: [0, " + this.y + "[");

            
            //Remover ligações no eixo Y
            Celula atual = inicio, anterior = null;
            while (atual.X < x)
                atual    = atual.Direita;

            while (atual.Abaixo.Y != -1 && atual.Y < y)
            {
                anterior = atual;
                atual = atual.Abaixo;
            }

            if (atual.Y == y) //Célula existe
            {
                anterior.Abaixo = atual.Abaixo;

                atual = inicio;
                anterior = null;
                while (atual.Y < y)
                    atual = atual.Abaixo;

                while (atual.Direita.X != -1 && atual.X < x)
                {
                    anterior = atual;
                    atual = atual.Direita;
                }

                //Não é nescessário fazer a checagem do eixo X, pois nesta parte do código temos certeza que a célula existe
                anterior.Direita = atual.Direita;
            }
        }

        /// <summary>
        /// Retorna um elemento que está na posição especificada.
        /// </summary>
        /// <param name="x">Posição X na matriz</param>
        /// <param name="y">Posição Y na matriz</param>
        /// <returns>Elemento na posição especificada.</returns>
        public double ElementoEm(int x, int y)
        {
            if (x >= this.x || x < 0)
                throw new ArgumentOutOfRangeException("X fora de intervalo: [0, " + this.x + "[");
            if (y >= this.y || y < 0)
                throw new ArgumentOutOfRangeException("Y fora de intervalo: [0, " + this.y + "[");

            Celula atual = inicio;
            while (atual.X < x)
                atual = atual.Direita;

            while (atual.Abaixo.Y != -1 && atual.Y < y)
                atual = atual.Abaixo;

            if (atual.X == x && atual.Y == y)
                return ((Celula<double>)atual).Info;

            return 0; //A célula especificada não existe, então assume que o valor é 0
        }

        /// <summary>
        /// Soma uma constante a uma coluna em específico
        /// </summary>
        /// <param name="coluna">Índice da coluna a ser afetada.</param>
        /// <param name="k">Constante a ser somada</param>
        public void Somar(int coluna, double k)
        {
            if (coluna >= this.x || coluna < 0)
                throw new ArgumentOutOfRangeException("Coluna fora de intervalo: [0, " + this.x + "[");

            // Posiciona o ponteiro atual na coluna desejada
            Celula atual = inicio;
            while (atual.X < coluna)
                atual = atual.Direita;

            atual = atual.Abaixo;
            while (atual.Y != -1)
            {
                ((Celula<double>)atual).Info += k;
                atual = atual.Abaixo;
            } 
        }
    }
}
