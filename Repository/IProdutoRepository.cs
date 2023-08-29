using WebApiTutorial.Data.ValueObjects;

namespace WebApiTutorial.Repository
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<ProdutoVO>> GetAll();

        Task<ProdutoVO> GetById(int id);

        Task<ProdutoRequestVO> Create(ProdutoRequestVO vo);

        Task<ProdutoVO> Update(ProdutoVO vo);
        Task<bool> Delete(int id);
    }
}
