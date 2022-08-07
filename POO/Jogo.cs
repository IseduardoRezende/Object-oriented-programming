using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Jogo      //Loja virtual de games;
    {
        public string titulo;
        public string destri;
        public string desen;
        public int ano;
        public string genero;
        public string desc;
        public string faixetaria;
        public float preco;
        public string plat;
        public float tamanDownload;

        public void Atualizar()
        {
            Console.WriteLine("Atualizando " + titulo + "!");
        }
        public void Salvar()
        {
            Console.WriteLine("Salvando seu progresso");
        }
        public void Jogar()
        {
            Console.WriteLine("Você está jogando " + titulo + "!");
        }
        public void Fechar()
        {
            Console.WriteLine("Fechando " + titulo);
        }
        public void Carregar()
        {
            Console.WriteLine("Carregando " + titulo);
        }
    }
}
