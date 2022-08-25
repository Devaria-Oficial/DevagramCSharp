using DevagramCSharp.Models;

namespace DevagramCSharp.Dtos
{
    public class FeedRespostaDto
    {
        public int IdPublicacao { get; set; }
        public string Descricao { get; set; }
        public string Foto { get; set; }
        public Comentario Comentarios { get; set; }
        public Curtida Curtida { get; set; }
        public UsuarioRespostaDto Usuario { get; set; }
    }
}
