using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTA.Models
{
    public class publicacoesModel
    {
        public int FotoID { get; set; }
        [ForeignKey("PetID")]
        public int PetID { get; set; }
        public byte Imagem { get; set; }
        public string Legenda { get; set; }
        public string DataPublicacoes { get; set; }
    
    }
}