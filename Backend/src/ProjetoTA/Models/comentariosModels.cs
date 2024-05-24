using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTA.Models
{
    public class comentariosModels
    {
        public int ComentarioID { get; set; }
        [ForeignKey("FotoID")]
        public int FotoID { get; set; }
        public int Usuario { get; set; }
        public string Comentario { get; set; }
        public string DataComentario { get; set; }
    }
}