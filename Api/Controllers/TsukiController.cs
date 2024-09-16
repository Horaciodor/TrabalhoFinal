using FilMax.Aplicação;
using FilMax.Entidade;
using FilMax.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilMax.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class TsukiController : ControllerBase
    {
        private TsukiService service;
        public TsukiController(IConfiguration configuration)
        {
            service = new TsukiService(configuration);
        }
        [HttpPost("Adicionar-Manga")]
        public void AdicionarManga(Mangas m)
        {
            service.Adicionar(m);
        }
        [HttpDelete("Remover-Manga")]
        public void RemoverManga(int id)
        {
            service.Remover(id);
        }
        [HttpGet("Listar-Manga")]
        public List<Mangas> ListarManga()
        {
            return service.Listar();
        }
        [HttpPut("Editar-Manga")]
        public void EditarManga(Mangas m)
        {
            service.Editar(m);
        }
    }
}
