using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Carro : Veiculo
    {

        public int torque;
        public int portas;
        public int desempenho;

        // Polimorfismo turbo
        public override void Cavalos(int value)
        {
            base.Cavalos(value);
        }


        // Construtores
        public Carro(string m, int cv, int k, int cT )
        {
            this.modelo = m;
            this.CavalosPotencia = cv;
            this.kmL = k;
            this.capacidadeTanque = cT;
            
        }

        

        

    }
}
