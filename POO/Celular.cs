using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Celular    //E-comerce Celular;
    {
        public string marca;
        public string nome;
        public float potenciaBateria;
        public string processador;
        public string modelo;
        public float tamantela;
        public int qtdestoque;        //Atributos;
        public float preco;
        public string desc;
        public List<string> listadeAcessorios = new List<string>();
       
        public void Ligar()
        {
            Console.WriteLine("Ligando " + nome + "!");    //Métodos
        }
        public void Desligar()
        {
            Console.WriteLine("Bateria Descarregou !");
        }
        public void Instalar()
        {
            Console.WriteLine("Instalando !");
        }
        public void Atualizar()
        {
            Console.WriteLine("Atualizando Sistema !");
        }
        public void Reiniciar()
        {
            Console.WriteLine("Reiniciando !");
        }
    }
}
