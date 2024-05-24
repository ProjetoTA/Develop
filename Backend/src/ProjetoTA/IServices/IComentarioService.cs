using System.Collections.Generic;
using System.Threading.Tasks;
using ProjetoTA.Models;

namespace ProjetoTA.Services
{
    public interface IComentarioService
    {
        Task<List<ComentariosModels>> ObterTodosPorPublicacaoId(int publicacaoId);
        Task Cadastrar(ComentariosModels comentario);
    }
}
