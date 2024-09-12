using AutoMapper;
using CRUDDRAPER.DTO.Produto;

namespace CRUDDRAPER
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap < CreateProdutoDTO, Produto>().ReverseMap();
        }
        
    }
}
