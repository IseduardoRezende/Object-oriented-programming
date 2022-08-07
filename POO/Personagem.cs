using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Personagem        //Personagem RPG;
    {
        public string nome;
        public string raca;
        public int idade;
        public string desc;
        public string afiliacao;
        public string classe;
        public float altura;
        public List<float> camposdePoder = new List<float>();
        public List<string> habilidades = new List<string>();
        public int nivel;
        public List<string> itens = new List<string>();

        public void Controle()
        {
            Console.WriteLine("Você está controlando " + nome);
        }
        public void Ação()
        {
            Console.WriteLine($"{nome} está correndo ! ");
        }
    }
}
