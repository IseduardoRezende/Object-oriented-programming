using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Linha : IDesenhavel
    {
        public float Area()
        {
            return 29;
        }

        public void Desenhar()
        {
            Console.WriteLine("Linha ------------");
        }
    }
}