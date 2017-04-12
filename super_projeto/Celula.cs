using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    /// <summary>
    /// Classe utilizada como célula da matriz esparsa. Não é tipada pois não contém um dado. 
    /// Por isso, pode ser utilizada como nó cabeça.
    /// </summary>
    class Celula
    {
        /// <summary>
        /// Armazena informações sobre a posição da célula na matriz esparsa
        /// </summary>
        int x, y;

        /// <summary>
        /// Propriedade do atributo Y.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Lança exceção caso Y seja menor do que -1.
        /// </exception>
        public int Y
        {
            get { return y; }

            set
            {
                if (value < -1)
                    throw new ArgumentOutOfRangeException("Y deve ser maior que 0.");
                y = value;
            }
        }

        /// <summary>
        /// Propriedade do atributo X.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Lança exceção caso X seja menor do que -1.
        /// </exception>
        public int X
        {
            get { return x; }

            set
            {
                if (value < -1)
                    throw new ArgumentOutOfRangeException("X deve ser maior que 0.");
                x = value;
            }
        }

        /// <summary>
        /// Atributos que contém ponteiros para as células imediatamente abaixo ou à direita.
        /// </summary>
        Celula abaixo, direita;

        /// <summary>
        /// Propriedade para os ponteiro de célula abaixo.
        /// <seealso cref="abaixo"/>
        /// </summary>
        internal Celula Abaixo
        {
            get
            {
                return abaixo;
            }

            set
            {
                abaixo = value;
            }
        }

        /// <summary>
        /// Propriedade para os ponteiro de célula direita.
        /// <seealso cref="direita"/>
        /// </summary>
        internal Celula Direita
        {
            get
            {
                return direita;
            }

            set
            {
                direita = value;
            }
        }

        /// <summary>
        /// Construtor de célula
        /// </summary>
        /// <param name="x">Define a posição X da célula na matriz.</param>
        /// <param name="y">Define a posição Y da célula na matriz.</param>
        /// <param name="abaixo">Define o nó imediatamente abaixo da célula na matriz.</param>
        /// <param name="direita">Define o nó imediatamente à direita da célula na matriz.</param>
        public Celula(int x, int y,Celula abaixo, Celula direita)
        {
            this.X = x;
            this.Y = y;
            this.abaixo = abaixo;
            this.direita = direita;
        }

        public override string ToString()
        {
            string ret = "";
            ret += "x: " + this.x + " ";
            ret += "y: " + this.y + " ";

            return ret;
        }
    }

    /// <summary>
    /// Classe utilizada como Celula da matriz esparsa. É tipada e, por isso, pode armazenar informação.
    /// Utilizada como campo preenchível da matriz.
    /// </summary>
    /// <typeparam name="Dado">Tipo de dado a ser armazenado na célula.</typeparam>
    /// <seealso cref="Celula"/>
    class Celula<Dado> : Celula
    {
        /// <summary>
        /// Campo que define a informação do tipo Dado a ser armazenada na célula
        /// </summary>
        Dado info;

        /// <summary>
        /// Propriedade para alteração da informação armazenada na célula
        /// </summary>
        public Dado Info
        {
            get { return info; }

            set
            {
                info = value;
            }
        }

        /// <summary>
        /// Construtor de célula
        /// </summary>
        /// <param name="x">Define a posição X da célula na matriz.</param>
        /// <param name="y">Define a posição Y da célula na matriz.</param>
        /// <param name="abaixo">Define o nó imediatamente abaixo da célula na matriz.</param>
        /// <param name="direita">Define o nó imediatamente à direita da célula na matriz.</param>
        /// <param name="info">Informação do tipo Dado a ser armazenada na célula</param>
        public Celula(int x, int y, Celula abaixo, Celula direita, Dado info) : base(x, y, abaixo, direita)
        {
            this.info = info;
        }

        /// <summary>
        /// Construtor de célula com dado padrão
        /// </summary>
        public Celula(int x, int y, Celula abaixo, Celula direita) : base(x, y, abaixo, direita)
        {
            this.info = default(Dado);
        }

        public override string ToString()
        {
            return base.ToString() + " info: "+this.info.ToString();
        }
    }
}
