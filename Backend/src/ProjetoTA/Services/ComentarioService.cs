using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjetoTA.Data;
using ProjetoTA.Models;

namespace ProjetoTA.Services
{
    public class ComentarioService : IComentarioService
    {
        private readonly IComentarioRepository _comentarioRepository;

        public ComentarioService(IComentarioRepository comentarioRepository)
        {
            _comentarioRepository = comentarioRepository;
        }

        public async Task<List<ComentariosModels>> ObterTodosPorPublicacaoId(int publicacaoId)
        {
            // 1. Buscar todos os comentários da publicação pelo ID no repositório
            var comentarios = await _comentarioRepository.ObterTodosPorPublicacaoId(publicacaoId);

            // 2. Converter os objetos Comentario em modelos ComentariosModels
            var comentariosModels = new List<ComentariosModels>();
            foreach (var comentario in comentarios)
            {
                comentariosModels.Add(new ComentariosModels
                {
                    ComentarioID = comentario.ComentarioID,
                    FotoID = comentario.FotoID,
                    Usuario = comentario.Usuario,
                    Comentario = comentario.Comentario,
                    DataComentario = comentario.DataComentario
                });
            }

            // 3. Retornar a lista de modelos ComentariosModels
            return comentariosModels;
        }

        public async Task Cadastrar(ComentariosModels comentarioModel)
        {
            // 1. Validar as informações do comentário (texto, usuário, etc.)

            // 2. Salvar o comentário no repositório
            await _comentarioRepository.Inserir(comentarioModel);
        }
    }
}
