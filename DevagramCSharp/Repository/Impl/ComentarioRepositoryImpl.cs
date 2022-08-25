using DevagramCSharp.Models;

namespace DevagramCSharp.Repository.Impl
{
    public class ComentarioRepositoryImpl : IComentarioRepository
    {

        private readonly DevagramContext _context;

        public ComentarioRepositoryImpl(DevagramContext context)
        {
            _context = context;
        }

        public void Comentar(Comentario comentario)
        {
            _context.Add(comentario);
            _context.SaveChanges();
        }
    }
}
