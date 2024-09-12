using Aluno._03Entidades;
using AutoMapper;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Configuration;
using System.Data.SQLite;

namespace Aluno._02Repository
{
    public class AlunoRepository
    {
        public readonly string _connectionString; //Variável de connection string a ser preenchida
        //private readonly IMapper _mapper; //criando o mapper a ser preenchido   IMapper mapper,

        public AlunoRepository( string StringConnection) //Responsavel por preencher a connection string
        {
            ////_mapper = mapper;
            _connectionString = StringConnection;
        }

        public void Adicionar(Alunos aluno)
        {
            using var connection = new SQLiteConnection(_connectionString);// conexao
            string comandInsert = @"INSERT into Alunos (NOME, IDADE, MATRICULAS, TELEFONE, SERIE, TURMA) 
                                                        values ( @NOME, @IDADE, @MATRICULAS, @TELEFONE, @SERIE, @TURMA)";
            connection.Execute(comandInsert, aluno);
        }
        public void AdicionarContrib(Alunos aluno)
        {
            using var connection = new SQLiteConnection(_connectionString);// conexao
            connection.Insert<Alunos>(aluno);
        }
        public List<Alunos> ListarAlunos()
        {
            using var connection = new SQLiteConnection(_connectionString);// conexao
            return connection.GetAll<Alunos>().ToList(); // retorna a tabela em forma de lista    
        }
        public Alunos BuscarAlunos(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);// conexao
            return connection.Get<Alunos>(id);//busca so um resgistro id e sua linha
        }
        public void Editar(Alunos aluno)
        {
            using var connection = new SQLiteConnection(_connectionString); // conexao
            connection.Update<Alunos>(aluno);
        }
        public void Delete(int id)
        {
            using var connection = new SQLiteConnection(_connectionString); // conexao
            Alunos novoaluno = BuscarAlunos(id);//retorna o objeto produto
            connection.Delete<Alunos>(novoaluno);
        }
    }
}
