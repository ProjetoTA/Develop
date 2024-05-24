using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTA.Models
{
    public class usuarioModel
    {
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string DataCadastro { get; set; }
        public byte fotoPerfil { get; set; }
    }
    }
