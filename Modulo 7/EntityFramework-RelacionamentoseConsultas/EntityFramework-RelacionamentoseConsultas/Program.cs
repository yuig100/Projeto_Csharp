/*
1.	Crie uma classe de modelo "Categoria" e estabeleça um relacionamento de um-para-muitos com a classe "Produto".
2.	Escreva uma consulta do Entity Framework que retorne todos os produtos de uma determinada categoria.
3.	Implemente uma consulta que liste todas as categorias junto com a contagem de produtos em cada uma.
4.	Crie uma consulta que retorne os produtos mais caros de cada categoria.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MeuProjeto
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string server = "localhost";
            string user = "root";
            string senha = "";
            string database = "minhaempresadb";

            string connectionString = $"Server={server};User={user};Password={senha};Database={database}";

            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 26)));
        }
    }

    public class Categoria
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public List<Produto> Produtos { get; set; }
    }

    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }

    class Program
    {
        public static void listarproduto()
        {

            using (var context = new ProdutoContext())
            {
                int categoriaId = 1; // Substitua pelo ID da categoria desejada
                var produtosCategoria = context.Produtos
                    .Where(p => p.CategoriaId == categoriaId)
                    .ToList();

                foreach (var produto in produtosCategoria)
                {
                    Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}");
                }
            }

        }
        public static void listarcategoria()
        {

            using (var context = new ProdutoContext())
            {
                var categoriasComContagem = context.Categoria
                    .Include(c => c.Produtos)
                    .Select(c => new
                    {
                        CategoriaNome = c.Nome,
                        ContagemProdutos = c.Produtos.Count
                    })
                    .ToList();

                foreach (var categoria in categoriasComContagem)
                {
                    Console.WriteLine($"Categoria: {categoria.CategoriaNome}, Produtos: {categoria.ContagemProdutos}");
                }
            }

        }
        
        public static void retornaromaiscaro()
        {

            using (var context = new ProdutoContext())
            {
                var produtosMaisCarosPorCategoria = context.Categoria
                    .Select(c => new
                    {
                        CategoriaNome = c.Nome,
                        ProdutoMaisCaro = c.Produtos.OrderByDescending(p => p.Preco).FirstOrDefault()
                    })
                    .ToList();

                foreach (var categoria in produtosMaisCarosPorCategoria)
                {
                    if (categoria.ProdutoMaisCaro != null)
                    {
                        Console.WriteLine($"Categoria: {categoria.CategoriaNome}, Produto Mais Caro: {categoria.ProdutoMaisCaro.Nome}, Preço: {categoria.ProdutoMaisCaro.Preco}");
                    }
                    else
                    {
                        Console.WriteLine($"Categoria: {categoria.CategoriaNome}, Produto Mais Caro: Nenhum produto encontrado");
                    }
                }
            }

        }

        static void Main()
        {

            listarproduto();
            listarcategoria();
            retornaromaiscaro();

        }
    }
}
