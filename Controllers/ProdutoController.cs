using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiTutorial.Data.ValueObjects;
using WebApiTutorial.Repository;

namespace WebApiTutorial.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository ?? throw new ArgumentNullException(nameof(produtoRepository));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoVO>> GetById(int id)
        {
            var produto = await _produtoRepository.GetById(id);
            if (produto == null)
                return NotFound();
            return Ok(produto);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoVO>>> GetAll()
        {
            var produtos = await _produtoRepository.GetAll();
            if (produtos == null)
                return NotFound();
            return Ok(produtos);
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoRequestVO>> Create(ProdutoRequestVO vo)
        {
            if (vo == null)
                return BadRequest();

            var produto = await _produtoRepository.Create(vo);
            return Ok(produto);
        }

        [HttpPost("/api/v1/produto/lista")]
        public async Task<IActionResult> CreateALL(List<ProdutoRequestVO> lvo)
        {
            if (lvo == null)
                return BadRequest();

            var retorno = new List<ProdutoRequestVO>();

            foreach (var vo in lvo)
            {
                await _produtoRepository.Create(vo);
                retorno.Add(vo);
            }            
               return Ok(retorno);
        }

        [HttpPut]
        public async Task<ActionResult<ProdutoVO>> Update(ProdutoVO vo)
        {
            if (vo == null)
                return BadRequest();

            var produto = await _produtoRepository.Update(vo);
            return Ok(produto);
        }

        [HttpDelete("id")]
        public async Task<ActionResult> Delete(int id)
        {
            var produto = await _produtoRepository.Delete(id);
            if (!produto)
                return BadRequest();

            return Ok(produto);
        }
    }
}
