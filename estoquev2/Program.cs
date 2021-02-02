using System;
using System.Collections.Generic;

namespace estoquev2
{
    class Program
    {
        int ids = 1;
        public class Produto
        {
            public Produto() { }

            public int Id { get; set; }
            public int Quantidade { get; set; }
            public string Nome { get; set; }
            public string Tipo { get; set; }

            public Produto(int id, int quantidade, string nome, string tipo)
            {
                this.Id = id;
                this.Quantidade = quantidade;
                this.Nome = nome;
                this.Tipo = tipo;
            }
        }

        static List<Produto> produtos;

        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu do estoque");
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Remover");
            Console.WriteLine("3 - Consultar");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("Escolha uma opção: ");

            string line = Console.ReadLine();
            if (!int.TryParse(line, out int op))
            {
                Console.WriteLine("Opção inválida.");
                Console.Read();
            }

            Program p = new Program();

            switch (op)
            {
                case 1:
                    p.Add();
                    return true;
                case 2:
                    p.Rem();
                    return true;
                case 3:
                    p.Lst();
                    Console.WriteLine("Pressione espaço para continuar. ");
                    Console.ReadKey();
                    return true;
                case 4:
                    return false;
                default:
                    return true;
            }
        }

        public void Add()
        {
            int id = ids;
            Console.WriteLine("Insira o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o tipo: ");
            string tipo = Console.ReadLine();
            Console.WriteLine("Insira a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            produtos.Add(new Produto(id, quantidade, nome, tipo));
        }

        public void Rem()
        {

        }

        public void Lst()
        {
            foreach(Produto p in produtos)
            {
                Console.WriteLine("ID " + p.Id + "|Nome "+p.Nome + "|Tipo " + p.Tipo+"|Quantidade "+p.Quantidade);
            }
        }

        static void Main(string[] args)
        {

            produtos = new List<Produto>();

            bool menu = true;
            while (menu){
                menu = Menu();
            }
            Environment.Exit(1);
           
        }
    }
}
