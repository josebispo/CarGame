using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Motocicleta : Veiculo
    {
        public int cilindradas;

        public Motocicleta(string m, int cv, int k, int cT)
        {
            this.modelo = m;
            this.CavalosPotencia = cv;
            this.kmL = k;
            this.capacidadeTanque = cT;

        }


    }

    
}
