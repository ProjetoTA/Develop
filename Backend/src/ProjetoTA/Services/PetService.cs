using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjetoTA.Data;
using ProjetoTA.Models;

namespace ProjetoTA.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public async Task<List<PetModel>> ObterTodosPorUsuarioId(int usuarioId)
        {
            // 1. Buscar todos os pets do usuário pelo ID no repositório
            var pets = await _petRepository.ObterTodosPorUsuarioId(usuarioId);

            // 2. Converter os objetos Pet em modelos PetModel
            var petModels = new List<PetModel>();
            foreach (var pet in pets)
            {
                petModels.Add(new PetModel
                {
                    PetID = pet.PetID,
                    Nome = pet.Nome,
                    Tipo = pet.Tipo,
                    Idade = pet.Idade,
                    UsuarioID = pet.UsuarioID
                });
            }

            // 3. Retornar a lista de modelos PetModel
            return petModels;
        }

        public async Task<PetModel> ObterPorId(int petId)
        {
            // 1. Buscar o pet pelo ID no repositório
            var pet = await _petRepository.ObterPorId(petId);

            // 2. Verificar se o pet existe
            if (pet == null)
            {
                return null;
            }

            // 3. Converter o objeto Pet em modelo PetModel
            var petModel = new PetModel
            {
                PetID = pet.PetID,
                Nome = pet.Nome,
                Tipo = pet.Tipo,
                Idade = pet.Idade,
                UsuarioID = pet.UsuarioID
            };

            // 4. Retornar o modelo PetModel
            return petModel;
        }

        public async Task Cadastrar(PetModel petModel)
        {
            // 1. Validar as informações do pet (nome, tipo, idade, etc.)

            // 2. Salvar o pet no repositório
            await _petRepository.Inserir(petModel);
        }

        public async Task Atualizar(PetModel petModel)
        {
            // 1. Validar as informações do pet (nome, tipo, idade, etc.)

            // 2. Verificar se o pet existe
            var pet = await _petRepository.ObterPorId(petModel.PetID);
            if (pet == null)
            {
                throw new Exception("Pet não encontrado.");
            }

            // 3. Atualizar as informações do pet no repositório
            await _petRepository.Atualizar(petModel);
        }
    }
}
