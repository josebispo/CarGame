using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Veiculo
    {
        protected int cavalosPotencia;

        public int CavalosPotencia
        {
            get { return cavalosPotencia; }
            set { cavalosPotencia = value; }
        }

        //turbinar o veiculo
        public virtual void Cavalos(int value)
        {
             cavalosPotencia = value; 
        }

        protected int kmL;

        protected int KmL
        {
            get { return kmL; }
            set { kmL = value; }
        }

        protected int capacidadeTanque;
        protected string marca;
        protected string modelo;
        protected string cor;
        protected string categoria;
        protected enum terreno { Terra, Asfalto, Gelo, Areia };
        protected int peso;
        protected int ano;

        public int Desempenho(int k, int cT)
        {
            this.kmL = k;
            this.capacidadeTanque = cT;
            int desempenho = k / cT;
            return desempenho;
        }

    }
}
