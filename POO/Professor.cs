using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Professor : Usuario
    {
        public List<string> turmas = new List<string>();
        public List<string> aulas = new List<string>();
        public string materia;

        public Professor(string nome, string email,string materia,string senha) : base(nome, email, senha)
        {
            this.materia = materia;
        }
        public override void Exibir()
        {
            Console.WriteLine("Dados do Professor:\n ");
            base.Exibir();
            Console.WriteLine("Materia lecionada: " + materia);
        }
    }
}
