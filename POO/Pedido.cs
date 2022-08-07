using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Pedido //Sistama Restaurante;
    {
        public int numpedido;
        //public int guiche;
        public List<string> listadeRefeicao = new List<string>();
        public List<string> localizacao = new List<string>();
        public float preco;
        public string nomealim;
        public string tipalim;
        //public float total;

        public void Pesquisar()
        {
            Console.WriteLine("Pesquisando...");
        }
        public void Pedir()
        {
            Console.WriteLine("Seu pedido de" + nomealim + "foi feito");
        }
        public void Retirar()
        {
            Console.WriteLine($"Seu pedido {numpedido}: " + nomealim + " pode ser retirado !");
        }
        public void Pagar()
        {
            Console.WriteLine($"Seu pedido {numpedido}: " + nomealim + " custou: " + preco +"$");
        }
    }
}
