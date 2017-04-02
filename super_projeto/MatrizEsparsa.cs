using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizEsparsa
{
    /// <summary>
    /// Classe encapsuladora das listas de células. Representa uma matriz esparsa.
    /// </summary>
    class MatrizEsparsa
    {
        public Celula inicio;
        private int x, y;
        public MatrizEsparsa (int x, int y)
        {
            inicio = new Celula(-1, -1, null, null);

            // Primeiro, define os tamanhos de cada dimensão da matriz
            this.x = x;
            this.y = y;

            // Para nós cabeça horizontais
            Celula atual = inicio;
            for (int i = 0; i < x; i++) 
            {
                atual.Direita = new Celula(i, -1, null, null);
                atual = atual.Direita;
                atual.Abaixo = atual; // Faz com que o nó referencie ele mesmo na direção para baixo.
            }
            atual.Direita = inicio; // Finalmente, faz com que o último referencie o primeiro e transforma a lista em circular.

            // Para nós cabeça verticais
            atual = inicio;
            for (int i = 0; i < y; i++)
            {
                atual.Abaixo = new Celula(-1, i, null, null);
                atual = atual.Abaixo;
                atual.Direita = atual; // Faz com que o nó referencie ele mesmo na direção para a direita.
            }
            atual.Abaixo = inicio; // Finalmente, faz com que o último referencie o primeiro e transforma a lista em circular.
        }
    }
}
