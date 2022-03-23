using CursosProway.ProjetosAula4.POO.Autos;
using CursosProway.ProjetosAula4.POO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula4.POO
{
    internal class Program
    {
        static List<Carro> ListaCarros { get; set; }
        static List<Moto> ListaMotos { get; set; }
        static void Main(string[] args)
        {
            ListaCarros = new List<Carro>();
            ListaMotos = new List<Moto>();

            bool controlaPrograma = true;
            string opcaoPrograma;

            // Laço principal da aplicação
            do
            {
                Console.WriteLine("L - Listar Automóveis");
                Console.WriteLine("I - Inserir Automóveis");
                Console.WriteLine("S - Sair");
                opcaoPrograma = Console.ReadLine();

                switch (opcaoPrograma.ToUpper())
                {
                    case "L":
                        ListarAutomovel();
                        break;
                    case "I":
                        InserirAutomovel();
                        break;
                    case "S":
                        controlaPrograma = false;
                        break;
                }
            }while(controlaPrograma);

        }

        static void ListarAutomovel()
        {
            Console.WriteLine("Informe o tipo de automóvel que deseja listar");
            Console.WriteLine("C - Carro");
            Console.WriteLine("M - Moto");

            var opcao = Console.ReadLine();

            if(opcao.ToUpper() == "C")
            {
                foreach(Carro carro in ListaCarros)
                {
                    Console.WriteLine(carro.GetInformacoes());
                }
            } else
            {
                foreach(Moto moto in ListaMotos)
                {
                    Console.WriteLine(moto.GetInformacoes());
                }
            }
        }

        static void InserirAutomovel()
        {
            Console.WriteLine("Informe o tipo de automóvel que deseja inserir");
            Console.WriteLine("C - Carro");
            Console.WriteLine("M - Moto");

            var opcao = Console.ReadLine();

            if (opcao.ToUpper() == "C")
            {
                Carro carro = new Carro();
                Console.WriteLine("Informe o Marca:");
                carro.Marca = Console.ReadLine();

                Console.WriteLine("Informe o Modelo:");
                carro.Nome = Console.ReadLine();

                Console.WriteLine("Informe o Limite de Velocidade:");
                carro.LimiteVelocidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a Quantidade de Portas:");
                carro.QtdePortas = int.Parse(Console.ReadLine());

                ListaCarros.Add(carro);
            }
            else
            {
                Moto moto = new Moto();
                Console.WriteLine("Informe o Marca:");
                moto.Marca = Console.ReadLine();

                Console.WriteLine("Informe o Modelo:");
                moto.Nome = Console.ReadLine();

                Console.WriteLine("Informe o Limite de Velocidade:");
                moto.LimiteVelocidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Há capacete integrado? (S)");
                var integrado = Console.ReadLine();

                moto.CapaceteIntegrado = (integrado.ToUpper() == "S");

                ListaMotos.Add(moto);
            }
        }

        static void POO1()
        {
            Pessoa pessoa1 = new Pessoa("Ramon", 32);

            Console.WriteLine($"{pessoa1.ExibeNome()}, tenho {pessoa1.Idade} anos.");
        }

        static void POO2()
        {
            List<Pessoa> listaPessoa = new List<Pessoa>();

            listaPessoa.Add(new Pessoa("Ramon", 32));
            listaPessoa.Add(new Pessoa("Lucas", 20));
            listaPessoa.Add(new Pessoa("João", 20));
            listaPessoa.Add(new Pessoa("Vinícius", 20));
            listaPessoa.Add(new Pessoa("Kauan", 18));
            listaPessoa.Add(new Pessoa("André", 18));
            listaPessoa.Add(new Pessoa("Gustavo", 18));

            foreach (Pessoa pessoa in listaPessoa)
            {
                Console.WriteLine($"{pessoa.ExibeNome()}, {pessoa.Idade} |");
            }
        }

        static void POO3()
        {
            Caucasiano pessoaCaucasiana = new Caucasiano("Brad Pitt", 40);
            Oriental pessoaOriental = new Oriental("Jackie Chan", 45);

            Console.WriteLine(pessoaCaucasiana.GetInformacoes());
            Console.WriteLine(pessoaOriental.GetInformacoes());
        }
    }
}
