using Aluno._03Entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Aluno._02Repository.data
{
    public class Inicializadorbd
    {

        private const string ConnectionString = "Data Source=Escola.db";
        public static void Inializador()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string commandoSQL = @" 
                CREATE TABLE IF NOT EXISTS Alunos(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                IDADE INTEGER NOT NULL,
                MATRICULAS TEXT NOT NULL,
                TELEFONE TEXT NOT NULL,
                SERIE TEXT NOT NULL,
                TURMA TEXT NOT NULL
                 );";
                
                commandoSQL += @" 
                CREATE TABLE IF NOT EXISTS Turmas(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                ALUNOS INTERGER NOT NULL,
                VAGAS INTERGER NOT NULL,
                CARGAHORARIA REAL NOT NULL,
                CODIGOTURMA TEXT NOT NULL,
                STATUS TEXT NOT NULL
                 );";


                connection.Execute(commandoSQL); //comando do Dapper que executa qualquer comando sql

            }
        }
    }
}
