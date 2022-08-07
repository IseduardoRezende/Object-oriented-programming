using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Usuario
    {
        public string nome;
        public string email;
        public string senha;
        protected string teste; //Atributo pode ser acessado pelos filhos também atráves do Protected;

        public Usuario(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }       

       //C# considera o tipo e a ordem dos parametros no método do Polimorfismo de sobrecarga !
       //Necessário Assinaturas diferentes para criar multiplas versões de um mesmo método;
        public void Logar() //Assinaturas do método = Logar(void) 
        {
            Console.WriteLine(teste);
            Console.WriteLine("Logando no sistema...");
        }
        public void Logar(string codigo)  //Mesmo nome de método porém com parametros diferentes, isto é Polimorfismo de sobrecarga, multiplas versões de um mesmo método;
        {
            Console.WriteLine("Logando com código...");
        }
        public void Logar(string email, string senha) //Assinaturas desse método = Logar(string, string) 
        {
            Console.WriteLine("Logando com email e senha");
        }
        public void Logar(string email, int pin)
        {
            Console.WriteLine("Logando usuário...");
        }
        public void Logar(int pin, string email) //Assinatura do método = Logar(int, string)
        {
            Console.WriteLine("Logando com pin...");
        }
          //Polimorfismo de sobreposição: Método que pode ser subscrito nas classes filhas de uma classe pai;
          //Atráves da chave virtual;
        public virtual void Exibir()
        {
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"nome: {nome}");
            Console.WriteLine($"senha: {senha}");
        }
    }
}
