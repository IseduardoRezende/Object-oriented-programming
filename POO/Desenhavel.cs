using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{                       //Contrato:
   abstract class Desenhavel  //Classe Abstrata = junção de Interface com Herança;
    {
        public int cor;
        public int tamanho;
        public string tipo;

        public abstract float Area(); //override;

        public abstract void Desenho(); //Funciona igual uma Interface;
    }
}
