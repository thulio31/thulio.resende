using Dapper;
using System.Data.SQLite;

namespace CRUDDRAPER
{
    public class InicializadorBd
    {
        public static void Inicializar()
        {
            using var connection = new SQLiteConnection("Data Source=Produto.db");
            
            string criarTabela = @"CREATE TABLE IF NOT EXISTS Produtos(Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                                                                        Nome TEXT NOT NULL,
                                                                        Preco REAL NOT NULL)";

            connection.Execute(criarTabela); //comando do Dapper que executa qualquer comando sql
        }
    }
}