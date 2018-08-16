using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon();
            pokemon1.positionX = 2;
            pokemon1.positionY = 4;
            pokemon1.movimiento = 4;
            pokemon1.ataque = 8;
            if (pokemon1.ataque < 5)
            {
                pokemon1.puntos = 1000;
            }
            else if (pokemon1.ataque < 2)
            {
                pokemon1.ataque = 100;
            }

            Console.WriteLine("Pokemon salvaje a aparecido");
            Console.WriteLine(" ");
            Console.WriteLine("Eevee:");
            Console.WriteLine("posición X:" + pokemon1.positionX);
            Console.WriteLine("posición Y: " + pokemon1.positionY);
            Console.WriteLine("Numero de movimientos: " + pokemon1.movimiento);
            Console.WriteLine("Ataques: " + pokemon1.ataque);
            Console.WriteLine(" ");
            if (pokemon1.puntos == 1000 || pokemon1.puntos < 1000)
            {
                Console.WriteLine("Has derrotado a Eevee");
            }

            Console.ReadLine();
        }
    }
}