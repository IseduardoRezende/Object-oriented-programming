using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO  //Padrão Namespace;
{
    //struct Filminho { public string nomeX; public string gêneroX; } //Classes se parecem Structs;
 
    class Filme     //Classe, Abstração e Métodos:
    {
        public string nome;
        public string desc;
        public int ano;
        public string studio;
        private List<string> atores = new List<string>(); //Vantagem privado => Conforto, só usa a variável naquele arquivo especifico;

         static public string plat = "Netflix"; //Acessa variável plat sem precisar criar um objeto do tipo Filme;

        //Construtor em Classes não é obrigado a utilizar todas variáveis que atribuiu, diferente do Structure;
        public Filme(string nome, int ano, string desc, string studio) //=> Construtor Classe;
        {
            this.nome = nome;
            this.studio = studio;
            this.desc = desc;
            this.ano = ano;
       
            Console.WriteLine("Listas de filmes novos abaixo:");
        }
            
        public void Executar()
        {
            Console.WriteLine(atores);
            Console.WriteLine("Rodando filme: " + nome +"!");
        }
         static public void Pausar()
        {
            Console.WriteLine("|| Pausado");
            Console.WriteLine(plat); //usando vriável static dentro de um método estático;
        }                            //Pertence apenas a classe || Variável global da classe;

        static public void Somar()
        {
            Console.WriteLine("Digite o primero número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int b = int.Parse(Console.ReadLine());
            int result = a + b;
            Console.WriteLine($"O resultado é: {result}");
        }
        static public void Sub(int a, int b)
        {
            Console.WriteLine($"Subtraindo valores desejados = {a - b}");
        }
       
        //Modificadores de acesso: public por exemplo:

        public void AddAtor(string nome) //Método Encapsulador:
        {
            if (nome != null)
            {
                if(nome.Length > 4)
                {
                    atores.Add(nome);
                }
            }
        }
        public void ExibAtores()
        {
            foreach (string ator in atores)
            {
                Console.WriteLine(ator);
            }
        }
        public void Listar()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"descrição: {desc}");
            Console.WriteLine($"studio: {studio}");
        }
    }
}
