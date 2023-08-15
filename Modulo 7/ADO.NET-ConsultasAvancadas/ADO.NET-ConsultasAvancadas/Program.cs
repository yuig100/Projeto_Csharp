/*
1.	Adicione uma tabela "Pedidos" ao banco de dados com campos como "ID", "Data", "ClienteID", "Total", etc.
2.	Crie uma consulta ADO.NET que retorne todos os pedidos de um cliente específico.
3.	Escreva uma consulta ADO.NET que retorne o total de vendas por mês.
4.	Implemente uma consulta que liste os clientes que fizeram mais de um pedido nos últimos 3 meses.
*/

using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace MeuProjeto
{
    class Program
    {
        static MySqlConnection conexao;

        static void Conexao()
        {
            try
            {
                string server = "localhost";
                string user = "root";
                string senha = "";
                string banco = "minhaempresadb";

                string sql = $"server={server};uid={user};pwd={senha};database={banco}";
                conexao = new MySqlConnection(sql);
                conexao.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ConsultaTotalVendasPorMes()
        {
            Conexao();

            string query = @"SELECT ClienteID,EXTRACT(YEAR FROM Data) AS Ano,EXTRACT(MONTH FROM Data) AS Mes,SUM(Total) AS TotalVendas FROM pedidos GROUP BY ClienteID,EXTRACT(YEAR FROM Data),EXTRACT(MONTH FROM Data) ORDER BY ClienteID,Ano,Mes";

            var command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ano = reader.GetInt32("Ano");
                int mes = reader.GetInt32("Mes");
                double totalVendas = reader.GetDouble("TotalVendas");

                Console.WriteLine($"Ano: {ano}, Mês: {mes}, Total de Vendas: {totalVendas}");
            }

            reader.Close(); // Fechando o leitor manualmente após o uso
        }

        static void Main()
        {
            ConsultaTotalVendasPorMes();
        }
    }
}
