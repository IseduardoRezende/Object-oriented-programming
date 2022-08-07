using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{                         //Apenas uma classe pai Permitida;
    class Aluno : Usuario // : significa = Aluno herda de Usuário;
    {
        public List<string> turmas = new List<string>();
        public string turno;

        public Aluno(string turno, string nome, string email, string senha) : base(nome, email, senha) //: base Referencia a classe pai;
        {
            this.turno = turno;
        }
        public override void Exibir() //override = sobrescrever um método que já está na classe pai;
        {
            Console.WriteLine("Dados do Aluno:\n");
            base.Exibir();        //Polimorfismo de sobreposição, economiza código a reescrita;
            Console.WriteLine("turno: " + turno); 
        }

        public void testandoMod()
        {
            Console.WriteLine(teste + "testei");
        }
    }
}
