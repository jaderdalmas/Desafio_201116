using Desafio.Service;
using Desafio.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Desafio.Controllers
{
    /// <summary>
    /// Sonda Controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class SondaController : ControllerBase
    {
        private readonly IMoveSondaService _sondaService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sondaService">Service</param>
        public SondaController(IMoveSondaService sondaService)
        {
            _sondaService = sondaService;
        }

        /// <summary>
        /// Post Sonda Move
        /// </summary>
        /// <param name="request">Request Sonda Move</param>
        /// <returns>List of sondas positions</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(MoveSondaResponse))]
        public IActionResult Post(MoveSondaRequest request) => Ok(_sondaService.MoveSonda(request));
    }
}
