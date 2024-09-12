using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno._03Entidades.DTO
{
    public class CreateTurmaDTO
    {
        // nome da turma
        public string Nome { get; set; }
        //alunos na turma
        public int Alunos { get; set; }
        //vagas da turma
        public int Vagas { get; set; }
        //carga horaria 
        public double CargaHoraria { get; set; }
        //codigo de identificação
        public string CodigoTurma { get; set; }
        //status cheia vazia 
        public string Status { get; set; }
    }
}
