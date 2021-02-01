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

            public int id { get; set; }
            public int quantidade { get; set; }
            public string nome { get; set; }
            public string tipo { get; set; }

            public Produto(int id, int quantidade, string nome, string tipo)
            {
                this.id = id;
                this.quantidade = quantidade;
                this.nome = nome;
                this.tipo = tipo;
            }
        }

        static List<Produto> produtos;

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
                Console.WriteLine("ID " + p.id + "|Nome "+p.nome + "|Tipo " + p.tipo+"|Quantidade "+p.quantidade);
                Console.Read();
            }
        }

        static void Main(string[] args)
        {

            int op;

            produtos = new List<Produto>();

            while(true){
                Console.WriteLine("Menu do estoque");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Consultar");
                Console.WriteLine("4 - Sair");

                op = int.Parse(Console.ReadLine());

                Program p = new Program();

                    switch (op)
                    {
                        case 1:
                            p.Add();
                            break;
                        case 2:
                            p.Rem();
                            break;
                        case 3:
                            p.Lst();
                            break;
                        case 4:
                            Environment.Exit(1);
                            break;
                    }
                    Console.Clear();
            }
           
        }
    }
}
