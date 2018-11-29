using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pista;
            int Carro;
            int Carro2;


            Console.WriteLine("Escolha a Pista para Jogar:" +
                "1. Areia"+
                "2. Neve"+
                "3. Barro"+
                "4. Asfalto");
            Pista = int.Parse(Console.ReadLine());


            Console.WriteLine("Escolha um Modelo de Carro para Jogar:" +
                "1. Renegage" +
                "2. Ferrari" +
                "3. Bugre" +
                "4. Ranger");
            Carro = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha outro Modelo de Carro para Jogar:" +
                "1. Renegage" +
                "2. Ferrari" +
                "3. Bugre" +
                "4. Ranger");
            Carro2 = int.Parse(Console.ReadLine());

            if (Carro2 == Carro)
            {
                throws new Exception("Não é possível escolher o mesmo carro. Porfavor escolha outro");
                
                    Console.WriteLine("Escolha um Modelo diferente do primeiro jogador:" +
                "1. Renegage" +
                "2. Ferrari" +
                "3. Bugre" +
                "4. Ranger");
                Carro2 = int.Parse(Console.ReadLine());
            }
             {
                try
                {
                    Carro.(Carro);
                    modelo.Text = Convert.ToString(Carro.modelo);
                    MessageBox.Show("Tente outro carro");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Carro selecionado");
                }

            }
    }
}
