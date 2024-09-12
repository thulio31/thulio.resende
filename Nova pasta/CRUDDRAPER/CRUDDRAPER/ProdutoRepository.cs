using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;

namespace CRUDDRAPER
{
    public class ProdutoRepository
    {
        public readonly string _connectionString;
        public ProdutoRepository(string StringConnection)
        {
            _connectionString = StringConnection;
        }

        public void Adicionar(Produto p)
        {
            using var connection = new SQLiteConnection(_connectionString);
            string comandInsert = @"INSERT into Produtos (Nome, Preco) 
                                                        values (@Nome, @Preco)";
            connection.Execute(comandInsert, p);
        }
        public void AdicionarContrib(Produto p)
        {
            using var connection = new SQLiteConnection(_connectionString);// conexao
            connection.Insert<Produto>(p);
        }
        public List<Produto> ListarProdutos() 
        {
            using var connection = new SQLiteConnection(_connectionString);// conexao
            return connection.GetAll<Produto>().ToList(); // retorna a tabela em forma de lista    
        }
        public Produto BuscarProduto(int id) 
        {
        using var connection = new SQLiteConnection(_connectionString);// conexao
            return connection.Get<Produto>(id);//busca so um resgistro id e sua linha
        }
        public void Editar(Produto p) 
        {
            using var connection = new SQLiteConnection(_connectionString); // conexao
            connection.Update<Produto>(p);
        }
        public void Delete(int id)
        {
            using var connection = new SQLiteConnection(_connectionString); // conexao
            Produto novoproduto = BuscarProduto(id);//retorna o objeto produto
            connection.Delete<Produto>(novoproduto);
        }
    }

}
