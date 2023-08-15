/*
1.	Crie um banco de dados simples contendo uma tabela "Clientes" com campos como "ID", "Nome", "Email" e "Telefone".
2.	Use ADO.NET para criar uma conexão com o banco de dados.
3.	Escreva um método que insira um novo cliente na tabela.
4.	Implemente um método para atualizar as informações de um cliente existente.
5.	Crie um método que liste todos os clientes da tabela.
 */

using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ManipulacaoDadosADO.NET
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
                string database = "minhaempresadb";

                string sql = $"server={server};uid={user};pwd={senha};database={database}";
                conexao = new MySqlConnection(sql);
                conexao.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            Conexao();
            InserirCliente("João Silva", "joao@email.com", "1234567890");
            AtualizarCliente(1, "João da Silva", "joao.novo@email.com", "9876543210");
            ListarClientes();
            string receber = Console.ReadLine();
        }

        static void InserirCliente(string nome, string email, string telefone)
        {

            Conexao();
            string query = "INSERT INTO Clientes (Nome, Email, Telefone) VALUES (@Nome, @Email, @Telefone)";
            var command = new MySqlCommand(query, conexao);

            command.Parameters.AddWithValue("@Nome", nome);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Telefone", telefone);

            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} registro(s) inserido(s).");

            
        }

        static void AtualizarCliente(int id, string novoNome, string novoEmail, string novoTelefone)
        {

            Conexao();
            string query = "UPDATE Clientes SET Nome = @NovoNome, Email = @NovoEmail, Telefone = @NovoTelefone WHERE ID = @ID";
            var command = new MySqlCommand(query, conexao);

            command.Parameters.AddWithValue("@NovoNome", novoNome);
            command.Parameters.AddWithValue("@NovoEmail", novoEmail);
            command.Parameters.AddWithValue("@NovoTelefone", novoTelefone);
            command.Parameters.AddWithValue("@ID", id);

            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} registro(s) atualizado(s).");

            
        }

        static void ListarClientes()
        {

            Conexao();
            string query = "SELECT ID, Nome, Email, Telefone FROM Clientes";
            var command = new MySqlCommand(query, conexao);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nome = reader.GetString(1);
                string email = reader.GetString(2);
                string telefone = reader.GetString(3);
                Console.WriteLine($"ID: {id}, Nome: {nome}, Email: {email}, Telefone: {telefone}");
            }
        }
    }
}
