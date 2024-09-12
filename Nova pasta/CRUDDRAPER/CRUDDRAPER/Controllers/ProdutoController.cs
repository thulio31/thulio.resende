using AutoMapper;
using CRUDDRAPER.DTO.Produto;
using Microsoft.AspNetCore.Mvc;
using System.Data.SQLite;

namespace CRUDDRAPER.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoRepository _repository;
        private readonly IMapper _mapper; //criando o mapper a ser preenchido

        public ProdutoController(IMapper mapper, string StringConnection) //preenchendo o mapper e a stringconnection
        {
            _mapper = mapper;
            _repository = new ProdutoRepository(StringConnection); 
        }
        [HttpGet("Listar-Produtos")]
        public List<Produto> ListarProdutos()
        {
            return _repository.ListarProdutos();
        }
        [HttpPost("Adicionar-dapper-contrib")]
        public void AdicionarContrib(CreateProdutoDTO p) //pegando a dto
        {
            Produto produto = new Produto(); //pegando de um objeto e jogando para outro objeto
            produto.Nome = p.Nome;
            produto.Preco = p.Preco;
            _repository.Adicionar(produto);
        }
        [HttpGet("Buscar -Id")]
        public Produto BuscarProduto(int id) 
        {
            return _repository.BuscarProduto(id);
        }

        [HttpPut("Editar-Produtos")]
        public void EditarProduto(Produto p)
        {
            _repository.Editar(p);
        }
    }
}
       