using System.Collections.Generic;
using System.Threading.Tasks;
using ProjetoTA.Models;

namespace ProjetoTA.IServices
{
    public interface IPetService
    {
        Task<List<PetModel>> ObterTodosPorUsuarioId(int usuarioId);
        Task<PetModel> ObterPorId(int petId);
        Task Cadastrar(PetModel pet);
        Task Atualizar(PetModel pet);
        
    }
}
