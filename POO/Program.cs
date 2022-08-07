using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Netflix.com.br;

namespace POO //Sem necessidade de utilizar o using pois a classe program e poo se entendem;
{
    class Program           //Classe principal do programa, Main;    
                            //Anotações POO: Teoria;

        //Programação orientada a objetos trabalha muito com classes e tudo que vem de uma classe é objeto, por isso o nome. Copia de classes, Instância;
    {
        static void Main(string[] args) //Static serve para acessar métodos sem precisar criar Instâncias para receber estas;
        {
            //Paradigma é um estilo de programar
            //Procedural até o momento, apenas utiliza variáveis e funções no projeto;
            //Monolito -> cheio de código em um unico programa e copiando código;
            //POO é um estilo de programar, o mais popular;
            //Diferencial está em separar as unidades lógicas, evita repetição de código, melhor organização, mais facil, evolução, desempenho e tempo ou seja muito util;
            //Unidade == classe;
            //Classificação em POO == agrupamento de semelhantes, precisa retirar caracteristicas gerais que entidade possui;
            //Toda classe possui atributos e métodos, Atributos são informações/dados da classe, Métodos são ações que a classe pode realizar;
            //Classe é uma abstração dos atributos e métodos, Define um conjunto de entidades com os mesmos atributos e métodos;
            //Semelhante a Struct;
            //Define tipos;
            //Funções dentro de classes são chamdas de métodos;

            //Criando classes em um novo arquivo e puxando os métoodos destas atráves de variáveis: 

            //Classe é o conceito, molde;
            //Objeto é a realização da Classe;

            //Objeto:
            /*Filme filme = new Filme();  //New cria uma copia da classe, Instância o nome, aloca na memória e passa o endereço para a variável;
            filme.nome = "Star Wars";   //EX: Filme() é o construtor;
            filme.Executar();

            Console.WriteLine("=================\n");

            Filme filme2 = new Filme(); //=> Dando erro pois defini 4 parametros que meu construtor deve receber e no momento só está recebdo um;
            filme2.nome = "Naruto";
            filme2.Executar();
            Filme.plat = "Prime Video"; //Variável estático, Global;
            Filme.Pausar(); //Exemplo método estático;*/

            /*Console.WriteLine("====================\n");

            Filme filme = new Filme("Tá dando onda", 2007, "Filme no Mar", "DreamWorks");

            Filme Eradogelo = new Filme("Era do gelo", 2005, "Ação e aventura", "DreamWorks");

            Console.WriteLine(filme.nome);  //Mais prático !
            Console.WriteLine(filme.ano);

            Console.ReadLine();

            /*Filme filme3 = new Filme();
            filme3.ano = 2006;
            filme3.nome = "C# Evolution";   //Construtores evitam repetições como estas codificadas;
            filme3.studio = "Udemy";
            filme3.desc = "Curso de C#";
            Console.ReadLine();*/

            /* Console.WriteLine("====================\n");

             Celular prod = new Celular();
             prod.nome = "Samsung A20";
             prod.Ligar();

             Console.WriteLine("=================\n");

             Jogo jogo = new Jogo();
             jogo.titulo = "The Witcher 3";
             jogo.Jogar();
             jogo.Salvar();

             Console.WriteLine("&&&&&&&&&&&&&&\n");

            //Static:
            Filme.Pausar();
            filme.plat = "Netflix";

             //CLASSE
             //1° CÓPIA

             //OBJETO
             //INFINITAS CÓPIAS

             nomemeu();

             Console.WriteLine("=================\n");

             Pedido pedido = new Pedido();
             pedido.nomealim = "Batata frita";
             pedido.numpedido = 2;
             pedido.Retirar();
             pedido.nomealim = "Pudim";
             pedido.preco = 15f;
             pedido.numpedido = 1;
             pedido.Pagar();

             Console.WriteLine("/////////////////\n");

             //Filme.  => Estático;
             //Filme filme = new Filme();  => Não estáticos, apenas objetos da classe;

             Personagem pers = new Personagem();
             pers.nome = "Edumoky";
             pers.Ação();

             Console.WriteLine("=====================\n");

             Imovel imovel = new Imovel();
             imovel.tipo = "Apartamento";
             imovel.precoAluguel = 1000f;
             imovel.Pagar();
             imovel.tipo = "Casa";
             imovel.precoAluguel = 500f;
             imovel.Pagar();

             Console.WriteLine("||||||||||||\n");

             Filme.Somar();

             Console.ReadLine();

             Filme.Sub(3, 9);

             Console.WriteLine("===============\n");

             //Encapsulamento POO, trás maior segurança ao seu código;

             /*Eradogelo.nome = "Era 3";
             Eradogelo.atores.Add("Brad Pitt");
             Eradogelo.atores = null;
             Eradogelo.atores.Clear();*/

            /*Eradogelo.AddAtor("Brad Pitt");
            Eradogelo.AddAtor("Tom");        //Maior segurança = Encapsulamento;
            Eradogelo.ExibAtores();         //Encapsulamento é um tipo de POO que impede que o externo acesse suas informações do objeto diretamente e assim usando funções como intermediadores e metódos de validação para acesso; 

            Console.WriteLine("||||||||||||||\n");

            /////////////////////////////////////////////////////////*/

            //Polimorfismo = Multiplas formas, um objeto/função pode ter multiplas formas;
            //Exemplo: Usuario:
            /*Usuario a = new Aluno("Matutino", "Eduardo", "dudumoises2005@gmail.com", "edu123");
            Usuario prof = new Professor("Roberto", "rog2000@gmail.com", "Ciências", "rog345");
            Usuario ze = new Zelador("Zézinho", "ze200@gmail.com", "ze123");
            
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(a);
            usuarios.Add(prof);
            usuarios.Add(ze);

            //Logar(string, string) :=)
            // a.Logar("email", "edu123");
            //Logar(int, string)    Polimorfismo de sobrecarga... atuando
            //a.Logar(12435, "email");

            //Convertendo tipo Usuario da variável u para tipo Aluno;
            //Console.WriteLine(((Aluno)a).turno); //Cast, converte váriáveis tipo pai para tipo filho para acessalas; 

            ///Console.WriteLine(((Professor)prof).materia); //Cast do Professor dentro do tipo Usuario;
            //Console.WriteLine("=================");

           // ++++++++++++++++++++++
                //Console.WriteLine(((Zelador)ze).testandoMod(usuarios)); ********************* VER COM PROFESSOR!!!!
           // ++++++++++++++++++++++

            //Polimorfismo de sobreposição:
            a.Exibir();
            Console.WriteLine("===================");
            prof.Exibir();
            Console.WriteLine("===================");
            ze.Exibir();
            Console.WriteLine("===================");

            /*Herança é uma forma de evitar repetições de código eem seu programa;
            Console.WriteLine("\nAluno:");
            Aluno a = new Aluno("Matutino", "Eduardo", "dudumoises2005@gmail.com", "edu123");
            a.Logar();
            a.testandoMod();
            a.Exibir();

            Console.WriteLine("===================");

            Console.WriteLine("Professor:");
            Professor prof = new Professor("Roberto", "rog2000@gmail.com", "Ciências", "rog345");
            prof.Logar();
            prof.Exibir();

            Console.WriteLine("==================");

            Console.WriteLine("Zelador:");
            Zelador ze = new Zelador("Zézinho", "ze200@gmail.com","ze123");
            ze.Logar();
            ze.Exibir(); 
            ze.testandoMod();*/

            //Interface: Servem para definir um contrato com classes EX: aplicativo de desenho = Linha, Circulo, Triangulo, Quadrado e Retangulo;
            //Criei Classes para minhas variáveis;
            //Forma Lenta e Repetida: Se houvesse 20 casos, pior aunda;
            //Forma Longa: Procedural;

            /*string formasele = "Retan";

            if (formasele == "Linha")
            {
                //Lógica de desenho de linha;  Métodos diferentes de se fazer = bagunça;
            }
            else if (formasele == "Quadra")
            {
                //Lógica de desenho do quadrado
            }
            else if (formasele == "Retan")
            {
                //Lógica do desenho do retangulo;
            }*/

            //Interface serve para organizar seu código;
            //Imaginando um Menu de um app tipo Paint: Linha, Circulo, Triangulo, Quadrado e Retangulo
            //Forma com Interface: 

            IDesenhavel forma = new Linha(); //Passando variável;
            forma.Desenhar(); //executando Interface;
            IDesenhavel forma2 = new Quadrado();
            forma2.Desenhar();
            
            //IDesenhavel forma = new Linha();

            //forma.Desenho();

            Console.WriteLine("=============");

            //Classes Abstratas: Se parece com Interface mas podendo adicionar atributos dentro da classe;

            Desenhavel ret = new Retangulo();
            ret.Desenho();

            //Namespace: Bloco de código definido onde dentro desse bloco definimos os tipos;

            //Objeto tipo filme do Namespace da netflix;
            //Netflix.com.br.Filme filmeNetflix = new Netflix.com.br.Filme();

            //Classe filme do Namespace POO;
            //Filme filme = new Filme("A vida", 2005, "TOP", "Warner Bros");
            //filme.Listar();

            /*Forma mais rápida utilizando using do novo Namespace Netflix:
            Serie serie = new Serie();
            serie.Filminho();
            Teste teste = new Teste();
            teste.Ola();*/

            //Diferença entre Struct e Classes = Struct mais limitada, Paradigma Procedural; Struct = trabalhando com cópias = Pesado, consome mais memória;;
            
            //Classe não cópia; apenas faz refêrencia a um objeto já definifido, aponta para o valor e não cria um novo objeto = ponteiro; != Struct;
            //Gerenciamento na memória  = chave principal de diferença;
            //Funcionalidade do C# GC = GARBET COLLECTOR, Limpa variáveis que não estão referenciando um Objeto, funciona apenas em Classes;

            Filme filme = new Filme("Era do Gelo", 2007, "TOP", "Warner");
            Filme filme2 = filme; //Apenas Refêrencia endereço do objeto que está na memória;
            Filme filme3 = filme2;

            Filme filme4 = new Filme("Vingadores", 2015, "Herois", "Marvel"); //Criando novo objeto do tipo Filme

            //Console.WriteLine(filme2.nome);
            
            filme.nome = "Shriek";

            Console.WriteLine(filme3.nome);

            Console.WriteLine(filme4.nome);

            Console.ReadLine();
        }

        //Exemplo de uma classe com atributos e métodos:

        /*class Jogo
        {
            public string título;
            public string gênero;       //Atributos de uma classe jogo;
            public string produtora;
            public float preco;

            public void Abrir()
            {
                Console.WriteLine("Abrindo...");
            }
            public void Carregar()       //Métodos de uma classe jogo;
            {
                Console.WriteLine("Carregando !");
            }
            public void Fechar()
            {
                Console.WriteLine("Aperte ESC para sair !");
            }
        }*/

        //Abstração: Simplificação de conceito, tirar a essencia de algo, apenas o essencial de um contexto;
        //Abstração na programação ->  *Depende do Contexto*, apenas informaçõe necessárias de uma entidade;
        //AbsAtração deve se extrair métodos da classe que acabou de desenvolvver;
        //Abstração de uma entidade não são iguais em um mesmo contexto, EX: Animais em um PetShop e Animais em uma Granja;
        //Recomendado que crie classes por arquivos, maior organização, porém pode se criar classes abaixo da classe Main, como o exemplo da Classe Jogo;
       
        static void nomemeu() //estático pela practicidade;
        {
            Console.WriteLine("Meu nome é edu");    //Função Aleatoria;
        }
    }
}