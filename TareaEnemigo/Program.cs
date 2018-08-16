using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Pokemon
    {
        public int positionX { get; set; }
        public int positionY { get; set; }
        public int explosion { get; set; }
        public int movimiento { get; set; }
        public int puntos { get; set; }
        private int _ataque;
        public int ataque
        {
            get
            {
                return _ataque;
            }
            set
            {
                if (value >= 4)
                {
                    _ataque = value;

                }
                else if (value < 4)
                {
                    Console.WriteLine("+500PUNTOS");
                    Console.WriteLine("Points: " + puntos + 500);
                }
                else if (value == 0) ;
                {
                    Console.WriteLine("");
                }
            }
        }

    }
}