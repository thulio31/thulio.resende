using System.ComponentModel.DataAnnotations.Schema;

namespace Aluno._03Entidades
{
    [Table("Alunos")]
    public class Alunos
    {
        //id do aluno
        public int Id { get; set; }
        //nome do aluno
        public string Nome { get; set; }
        //idade do aluno
        public int Idade { get; set; }
        //matricula do aluno
        public string Matricula { get; set; }
        //telefone do aluno ou responsavel
        public string Telefone { get; set; }
        //serie que o aluno esta
        public string Serie { get; set; }
        //turma do aluno
        public string Turma { get; set; }



    }
}
