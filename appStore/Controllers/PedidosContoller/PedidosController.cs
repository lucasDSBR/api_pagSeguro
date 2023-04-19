using api.Models.PedidosModel;
using api.Services;
using api.Services.PagSeguroService;
using api.Interfaces.PagSeguroInterfaceService;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using api.Models.PedidosPagSegModel;

namespace api.Controllers
{
    [ApiController]
	[Route("/api/[controller]")]

	public class PedidosController : ControllerBase
	{
		private readonly ILogger<PagamentosController> _logger;
        private readonly IPedidosInterfaceService _pedidosService;
        public PedidosController(
            ILogger<PagamentosController> logger,
            IPedidosInterfaceService pedidosService
           )
        {
            _logger = logger;
            _pedidosService = pedidosService;
        }

        [HttpGet("consultarpedido/{id}")]
        public Task<PedidosModel> Get(string id)
        {
            try
            {
                var result = _pedidosService.ConsultarPedido(id);
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message); //500 Internal Error -- Erro interno do servidor.
            }
        }

		[HttpPost("gerarpedido")]
        public Task<PedidosModel> Post([FromBody] PedidoPagSegModel pedidoData)
        {
            try
            {
                var result = _pedidosService.GerarPedido(pedidoData);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }
	}
}