using Chapter.Contexts;
using Chapter.Domains;
using Microsoft.IdentityModel.Tokens;

namespace Chapter.Repositories{
    public class ProjetoRepository{
        private readonly ExoApiContext _ctx;
        public ProjetoRepository(ExoApiContext ctx) {
            _ctx = ctx;
        }
        public List<Projeto> Listar() {
            return _ctx.Projetos.ToList();
        }
    }
}