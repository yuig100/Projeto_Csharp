/*
1.	Crie um projeto com Entity Framework.
2.	Defina uma classe de modelo chamada "Produto" com propriedades como "ID", "Nome", "Preço" e "Estoque".
3.	Configure a conexão com o banco de dados usando o Entity Framework.
4.	Escreva um método para adicionar um novo produto ao banco de dados.
5.	Implemente um método para atualizar as informações de um produto existente.
6.	Crie um método que liste todos os produtos.
*/

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MeuProjeto
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public void AdicionarProduto()
        {
            using (var context = new ProdutoContext())
            {
                context.Produtos.Add(this);
                context.SaveChanges();
            }
        }

        public void AtualizarProduto()
        {
            using (var context = new ProdutoContext())
            {
                var produtoExistente = context.Produtos.Find(ID);
                if (produtoExistente != null)
                {
                    context.Entry(produtoExistente).CurrentValues.SetValues(this);
                    context.SaveChanges();
                }
            }
        }

        public static List<Produto> ListarProdutos()
        {
            using (var context = new ProdutoContext())
            {
                return context.Produtos.ToList();
            }
        }
    }

    public class ProdutoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string server = "localhost";
            string user = "root";
            string senha = "";
            string database = "minhaempresadb";

            string connectionString = $"Server={server};User={user};Password={senha};Database={database}";

            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 26)));
        }

        public DbSet<Produto> Produtos { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var newProduct = new Produto
            {
                Nome = "Novo Produto",
                Preco = 9.99,
                Estoque = 100
            };

            newProduct.AdicionarProduto();

            var produtos = Produto.ListarProdutos();
            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.ID}, Nome: {produto.Nome}, Preço: {produto.Preco}, Estoque: {produto.Estoque}");
            }
        }
    }
}
