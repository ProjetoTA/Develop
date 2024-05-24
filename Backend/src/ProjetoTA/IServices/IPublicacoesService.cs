using System.Threading.Tasks;
using ProjetoTA.Models;

namespace ProjetoTA.IServices
{
    public interface IPublicacoesService
    {
        Task<List<PublicacoesModel>> ObterTodasPorUsuarioId(int usuarioId);
        Task<PublicacoesModel> ObterPorId(int publicacaoId);
        Task Cadastrar(PublicacoesModel publicacao);
        Task Atualizar(PublicacoesModel publicacao);
    }
}
