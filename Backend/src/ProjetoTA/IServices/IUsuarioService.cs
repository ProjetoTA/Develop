using System.Threading.Tasks;
using ProjetoTA.Models;

namespace ProjetoTA.IServices
{
    public interface IUsuarioService
    {
        Task<UsuarioModel> Autenticar(string email, string senha);
        Task<UsuarioModel> Cadastrar(UsuarioModel usuario);
        Task<UsuarioModel> BuscarPorId(int usuarioId);
        Task Atualizar(UsuarioModel usuario);
    }
}
