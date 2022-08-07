using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Zelador : Usuario // : significa = Aluno herda de Usuário;
    {
        public List<string> tarefas = new List<string>();

        public Zelador(string nome, string email, string senha) : base(nome, email, senha)
        {
            
        }
        public override void Exibir()
        {
            Console.WriteLine("Dados do Zelador:\n ");
            base.Exibir();
        }
        public void testandoMod()
        {
            Console.WriteLine(teste + "testei");
        }
    }
}
