using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Quadrado : IDesenhavel
    {
        public float Area()
        {
            return 2;
        }

        public void Desenhar()
        {
            Console.WriteLine("Quadrado -=--=");
        }
    }
}