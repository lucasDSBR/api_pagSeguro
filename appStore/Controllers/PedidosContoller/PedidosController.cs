using appStore.Models.PedidosModel;
using appStore.Services;
using appStore.Services.PagSeguroService;
using appStore.Interfaces.PagSeguroInterfaceService;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using appStore.Models.PedidosPagSegModel;

namespace appStore.Controllers
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
        public IEnumerable<PedidoPagSegModel> Get(string id)
        {
            try
            {
                //var apiPagSeguroCriar = _pagSeguroService.ConsultarPedido(id);
            }
            catch (ArgumentException ex)
            {

                return (IEnumerable<PedidoPagSegModel>)StatusCode((int)HttpStatusCode.InternalServerError, ex.Message); //500 Internal Error -- Erro interno do servidor.
            }
            return null;
        }

		[HttpPost("gerarpedido")]
        public IEnumerable<PedidoPagSegModel> Post([FromBody] PedidoPagSegModel pedidoData)
        {
            try
            {
                var result = _pedidosService.GerarPedido(pedidoData);
            }
            catch (ArgumentException ex)
            {

                return (IEnumerable<PedidoPagSegModel>)StatusCode((int)HttpStatusCode.InternalServerError, ex.Message); //500 Internal Error -- Erro interno do servidor.
            }
            return null;
        }
	}
}