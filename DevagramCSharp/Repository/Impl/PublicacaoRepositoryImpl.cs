using DevagramCSharp.Dtos;
using DevagramCSharp.Models;

namespace DevagramCSharp.Repository.Impl
{
    public class PublicacaoRepositoryImpl : IPublicacaoRepository
    {
        private readonly DevagramContext _context;

        public PublicacaoRepositoryImpl(DevagramContext context)
        {
            _context = context;
        }

        public List<FeedRespostaDto> GetFeed(int idUsuario)
        {
            var feed =
               from publicacoes in _context.Publicacoes
               join seguirdores in _context.Seguidores on publicacoes.IdUsuario equals seguirdores.IdUsuarioSeguido
               where seguirdores.IdUsuarioSeguidor == idUsuario
               select new FeedRespostaDto
               { 
                   IdPublicacao = publicacoes.Id,
                   Foto = publicacoes.Foto,
                   Descricao = publicacoes.Descricao
               };

            return feed.ToList();
        }

        public void Publicar(Publicacao publicacao)
        {
            _context.Add(publicacao);
            _context.SaveChanges();
        }

        

    }
}
