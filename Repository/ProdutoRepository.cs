using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApiTutorial.Data.ValueObjects;
using WebApiTutorial.Model;
using WebApiTutorial.Model.Context;

namespace WebApiTutorial.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly PostgreSQLContext _context;
        private IMapper _mapper;

        public ProdutoRepository(PostgreSQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProdutoVO>> GetAll()
        {
            List<Produto> produtos = await _context.Produtos.ToListAsync();
            return _mapper.Map<List<ProdutoVO>>(produtos);
        }

        public async Task<ProdutoVO> GetById(int id)
        {
            Produto produto = await _context.Produtos.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<ProdutoVO>(produto);
        }
        public async Task<ProdutoRequestVO> Create(ProdutoRequestVO vo)
        {
            Produto produto = _mapper.Map<Produto>(vo);
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProdutoRequestVO>(produto);
        }

        public async Task<ProdutoVO> Update(ProdutoVO vo)
        {
            Produto produto = _mapper.Map<Produto>(vo);
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProdutoVO>(produto);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                Produto produto = await _context.Produtos.Where(p => p.Id == id).FirstOrDefaultAsync();
                if(produto == null)
                    return false;

                _context.Produtos.Remove(produto); 
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
