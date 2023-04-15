using appStore.Models.PedidosModel;
using appStore.Services;
using appStore.Services.PagSeguroService;
using appStore.Interfaces.PagSeguroInterfaceService;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace appStore.Controllers
{
    [ApiController]
	[Route("/api/[controller]")]

	public class PedidosController : ControllerBase
	{
		private readonly ILogger<PagamentosController> _logger;
        private readonly IPagSerguroInterfaceService _pagSeguroService;
        public PedidosController(
            ILogger<PagamentosController> logger,
            IPagSerguroInterfaceService pagSeguroService
           )
        {
            _logger = logger;
            _pagSeguroService = pagSeguroService;
        }

        [HttpGet("{id}")]
        public IEnumerable<PedidoModel> Get(string id)
        {
            try
            {
                var apiPagSeguroCriar = _pagSeguroService.ConsultarPedido(id);
            }
            catch (ArgumentException ex)
            {

                return (IEnumerable<PedidoModel>)StatusCode((int)HttpStatusCode.InternalServerError, ex.Message); //500 Internal Error -- Erro interno do servidor.
            }
            return null;
        }

		[HttpPost]
        [Route("/api/pedidos/criar")]
        public IEnumerable<PedidoModel> Post([FromBody] PedidoModel pedidoData)
        {
            try
            {
                var apiPagSeguroCriar = _pagSeguroService.CriarPedido(pedidoData);
            }
            catch (ArgumentException ex)
            {

                return (IEnumerable<PedidoModel>)StatusCode((int)HttpStatusCode.InternalServerError, ex.Message); //500 Internal Error -- Erro interno do servidor.
            }
            return null;
        }
	}
}