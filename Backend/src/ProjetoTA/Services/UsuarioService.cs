using System;
using System.Threading.Tasks;
using ProjetoTA.Data;
using ProjetoTA.Models;
using Microsoft.AspNetCore.Cryptography;
using Microsoft.IdentityModel.Tokens;

namespace ProjetoTA.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioModel> Autenticar(string email, string senha)
        {
            // 1. Buscar o usuário pelo email no repositório
            var usuario = await _usuarioRepository.BuscarPorEmail(email);

            // 2. Verificar se o usuário existe e se a senha é válida
            if (usuario == null || !ValidarSenha(senha, usuario.Senha))
            {
                return null;
            }

            // 3. Criar um token JWT (JSON Web Token) para o usuário autenticado
            var token = GerarToken(usuario);

            // 4. Retornar o modelo de usuário com o token
            return new UsuarioModel
            {
                UsuarioID = usuario.UsuarioID,
                Nome = usuario.Nome,
                Email = usuario.Email,
                DataCadastro = usuario.DataCadastro,
                fotoPerfil = usuario.fotoPerfil,
                Token = token
            };
        }

        public async Task<UsuarioModel> Cadastrar(UsuarioModel usuarioModel)
        {
            // 1. Validar as informações do usuário (nome, email, senha, etc.)

            // 2. Verificar se o email já está em uso
            if (await _usuarioRepository.EmailJaExiste(usuarioModel.Email))
            {
                throw new Exception("Email já está em uso.");
            }

            // 3. Criptografar a senha do usuário
            usuarioModel.Senha = CriptografarSenha(usuarioModel.Senha);

            // 4. Salvar o usuário no repositório
            await _usuarioRepository.Inserir(usuarioModel);

            // 5. Gerar um token JWT para o usuário recém-cadastrado
            var token = GerarToken(usuarioModel);

            // 6. Retornar o modelo de usuário com o token
            return new UsuarioModel
            {
                UsuarioID = usuarioModel.UsuarioID,
                Nome = usuarioModel.Nome,
                Email = usuarioModel.Email,
                DataCadastro = usuarioModel.DataCadastro,
                fotoPerfil = usuarioModel.fotoPerfil,
                Token = token
            };
        }

        public async Task<UsuarioModel> BuscarPorId(int usuarioId)
        {
            // 1. Buscar o usuário pelo ID no repositório
            var usuario = await _usuarioRepository.BuscarPorId(usuarioId);

            // 2. Verificar se o usuário existe
            if (usuario == null)
            {
                return null;
            }

            // 3. Retornar o modelo de usuário
            return new UsuarioModel
            {
                UsuarioID = usuario.UsuarioID,
                Nome = usuario.Nome,
                Email = usuario.Email,
                DataCadastro = usuario.DataCadastro,
                fotoPerfil = usuario.fotoPerfil
            };
        }

        public async Task Atualizar(UsuarioModel usuarioModel)
        {

            // 2. Verificar se o usuário existe
            var usuario = await _usuarioRepository.BuscarPorId(usuarioModel.UsuarioID);
            if (usuario == null)
            {
                throw new Exception("Usuário não encontrado.");
            }

            // 3. Verificar se o email foi alterado e, se sim, se o novo email já está em uso
            if (usuario.Email != usuarioModel.Email && await _usuarioRepository.EmailJaExiste(usuarioModel.Email))
            {
                throw new Exception("Email já está em uso.");
            }

            // 4. Atualizar as informações do usuário no repositório
            await _usuarioRepository.Atualizar(usuarioModel);
        }

        private bool ValidarSenha(string senhaDigitada, string senhaHash)
        {
            // 1. Convert the user-entered password to a hash using the same algorithm and salt as the stored hash
            using (var sha256 = SHA256.Create())
            {
                var salt = Convert.FromBase64String(senhaHash.Split(':')[1]); // Extract the salt from the stored hash
                var hashedSenhaDigitada = sha256.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada + salt));
                var hashedSenhaDigitadaString = Convert.ToBase64String(hashedSenhaDigitada);

                // 2. Compare the generated hash with the stored hash
                return hashedSenhaDigitadaString == senhaHash;
            }
        }
