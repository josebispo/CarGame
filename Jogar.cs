using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Jogar : Carro, IEscolhas
    {
        public Jogar(string m, int cv, int k, int cT) : base(m, cv, k, cT)
        {

        }

               
        public void escolherPista(int pista)
        {
            
        }
        public void escolherVeiculo(int modelo) { }
        public void escolherTanque(int tanque)
        {
            base.capacidadeTanque = tanque;
        }

        // Instanciação
        Carro JeepRenegage = new Carro("Renegage", 150, 8, 40);
        Carro Ferrari = new Carro("Ferrari", 300, 7, 40);
        Carro Bugre = new Carro("Bugre", 80, 11, 40);
        Carro FordRanger = new Carro("Ranger", 180, 8, 60);
    }
}
