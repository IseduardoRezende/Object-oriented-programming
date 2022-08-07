using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Imovel    // Sistema de Aluguel;
    {
        public string rua;
        public string bairro;
        public string cidade;
        public int numero;
        public string cep;
        public float precoAluguel;
        public List<string> propri = new List<string>();
        public float areatotal;
        public string desc;
        public List<int> qtdcomodos = new List<int>();
        public List<string> comodos = new List<string>();
        public float imagem;
        public float mquadra;
        public string tipo;
        public float iptu;

        public void Pesquisar()
        {
            Console.WriteLine("Pesquisando...");
        }
        public void Alugar()
        {
            Console.WriteLine("Alugando " + tipo);
        }
        public void Pagar()
        {
            Console.WriteLine("Pagando " + precoAluguel +"$ " + "de aluguel em " + tipo);
        }
        public void Cancelar()
        {
            Console.WriteLine("Cancelando aluguel !");
        }
    }
}
