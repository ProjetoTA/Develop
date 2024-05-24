using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTA.Models
{
    public class petsModel
    {
        public int PetID { get; set; }
        public List<Pet> pets = new List<Pet>();
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Idade
        [ForeignKey("UsuarioID")]
        public int UsuarioID

    }
}