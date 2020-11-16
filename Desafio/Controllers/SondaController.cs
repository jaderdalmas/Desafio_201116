using Desafio.Service;
using Desafio.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SondaController : ControllerBase
    {
        private readonly ILogger<SondaController> _logger;
        private readonly IMoveSondaService _sondaService;

        public SondaController(ILogger<SondaController> logger, IMoveSondaService sondaService)
        {
            _logger = logger;

            _sondaService = sondaService;
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(MoveSondaResponse))]
        public IActionResult Post(MoveSondaRequest request) => Ok(_sondaService.MoveSonda(request));
    }
}
