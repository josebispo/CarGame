using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pista
    {
        private string nomePista;

        private string NomePista
        {
            get { return nomePista; }
            set { nomePista = value; }
        }

        private int distanciaPista;

        public int DistanciaPista
        {
            get { return distanciaPista; }
            set { distanciaPista = value; }
        }

        public void pista(string nome, int distancia) {
            distanciaPista = distancia;
            nomePista = nome;
        }

        public Pista(string n, int d)
        {
            this.NomePista = n;
            this.distanciaPista = d;
        }

        Pista Areia = new Pista("Areia", 360);
        Pista Neve = new Pista("Neve", 270);
        Pista Barro = new Pista("Barro", 180);
        Pista Asfalto = new Pista("Asfalto", 500);

    }
}
