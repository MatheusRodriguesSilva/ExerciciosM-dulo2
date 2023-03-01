using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // teste mercadoria
        List<Mercadoria> mercadorias = new List<Mercadoria>();

        // cadastro de mercadorias
        Mercadoria mercadoria1 = new Mercadoria("Camisa", 50.0, 100);
        Mercadoria mercadoria2 = new Mercadoria("Calça", 100.0, 50);
        mercadorias.Add(mercadoria1);
        mercadorias.Add(mercadoria2);

        // busca de mercadoria pelo nome
        string nomeBusca = "Camisa";
        Mercadoria mercadoriaBusca = mercadorias.Find(mercadoria => mercadoria.Nome == nomeBusca);
        if (mercadoriaBusca != null)
        {
            Console.WriteLine("Mercadoria encontrada: " + mercadoriaBusca.Nome);
        }
        else
        {
            Console.WriteLine("Mercadoria não encontrada");
        }

        // adição de estoque de mercadoria
        int quantidadeAdicao = 50;
        mercadoria1.AdicionarEstoque(quantidadeAdicao);
        Console.WriteLine("Quantidade de " + mercadoria1.Nome + " após adição de estoque: " + mercadoria1.Quantidade);
    }


    class Mercadoria
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Mercadoria(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void AdicionarEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverEstoque(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public class Cliente
        {
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Telefone { get; set; }
        }

        // Classe principal para o controle de estoque
        public class ControleEstoque
        {
            // Lista de clientes cadastrados
            private List<Cliente> clientes;

            public ControleEstoque()
            {
                clientes = new List<Cliente>();
            }

            // Método para cadastrar um novo cliente
            public void CadastrarCliente(string nome, string endereco, string telefone)
            {
                Cliente novoCliente = new Cliente();
                novoCliente.Nome = nome;
                novoCliente.Endereco = endereco;
                novoCliente.Telefone = telefone;

                clientes.Add(novoCliente);
            }
        }
    }
}