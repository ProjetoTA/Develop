using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjetoTA.Data;
using ProjetoTA.Models;

namespace ProjetoTA.Services
{
    public class PublicacaoService : IPublicacoesService
    {
        private readonly IPublicacaoRepository _publicacaoRepository;

        public PublicacaoService(IPublicacaoRepository publicacaoRepository)
        {
            _publicacaoRepository = publicacaoRepository;
        }

        public async Task<List<PublicacoesModel>> ObterTodasPorUsuarioId(int usuarioId)
        {
            // 1. Buscar todas as publicações do usuário pelo ID no repositório
            var publicacoes = await _publicacaoRepository.ObterTodasPorUsuarioId(usuarioId);

            // 2. Converter os objetos Publicacao em modelos PublicacoesModel
            var publicacoesModels = new List<PublicacoesModel>();
            foreach (var publicacao in publicacoes)
            {
                publicacoesModels.Add(new PublicacoesModel
                {
                    FotoID = publicacao.FotoID,
                    PetID = publicacao.PetID,
                    Conteudo = publicacao.Conteudo,
                    DataPublicacoes = publicacao.DataPublicacoes
                });
            }

            // 3. Retornar a lista de modelos PublicacoesModel
            return publicacoesModels;
        }

        public async Task<PublicacoesModel> ObterPorId(int publicacaoId)
        {
            // 1. Buscar a publicação pelo ID no repositório
            var publicacao = await _publicacaoRepository.ObterPorId(publicacaoId);

            // 2. Verificar se a publicação existe
            if (publicacao == null)
            {
                return null;
            }

            // 3. Converter o objeto Publicacao em modelo PublicacoesModel
            var publicacaoModel = new PublicacoesModel
            {
                FotoID = publicacao.FotoID,
                PetID = publicacao.PetID,
                Conteudo = publicacao.Conteudo,
                DataPublicacoes = publicacao.DataPublicacoes
            };

            // 4. Retornar o modelo PublicacoesModel
            return publicacaoModel;
        }

        public async Task Cadastrar(PublicacoesModel publicacaoModel)
        {
            // 1. Validar as informações da publicação (conteúdo, pet, etc.)

            // 2. Salvar a publicação no repositório
            await _publicacaoRepository.Inserir(publicacaoModel);
        }

        public async Task Atualizar(PublicacoesModel publicacaoModel)
        {
            // 1. Validar as informações da publicação (conteúdo, pet, etc.)

            // 2. Verificar se a publicação existe
            var publicacao = await _publicacaoRepository.ObterPorId(publicacaoModel.FotoID);
            if (publicacao == null)
            {
                throw new Exception("Publicação não encontrada.");
            }

            // 3. Atualizar as informações da publicação no repositório
            await _publicacaoRepository.Atualizar(publicacaoModel);
        }
    }
}
