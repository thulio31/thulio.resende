using Aluno._03Entidades;
using Aluno._03Entidades.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
        
        CreateMap<CreateAlunoDTO, Alunos>().ReverseMap();

        CreateMap<CreateTurmaDTO, Turma>().ReverseMap();

        }        
    }
}
