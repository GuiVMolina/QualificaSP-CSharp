using Chapter.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapter.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase {
        private readonly ProjetoRepository _projetoRepository;
        public ProjetoController(ProjetoRepository projetoRepository) {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(_projetoRepository.Listar());
        }
    }
}