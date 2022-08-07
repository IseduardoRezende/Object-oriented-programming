using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Retangulo : Desenhavel //Relação tipo Herança, Apenas uma classe permitida;
    {
        public override float Area()
        {
            return 5;
        }
       
        public override void Desenho()
        {
            Console.WriteLine("Retangulo ++++++++++");
        }
    }
}
