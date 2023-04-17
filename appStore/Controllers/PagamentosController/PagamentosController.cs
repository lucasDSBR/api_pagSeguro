using appStore.Models;
using appStore.Services;
using appStore.Services.PagSeguroService;
using appStore.Interfaces.PagSeguroInterfaceService;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using appStore.Models.PagamentoPagSegModel;

namespace appStore.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]

    public class PagamentosController : ControllerBase
    {
        private readonly ILogger<PagamentosController> _logger;
        private readonly IPagSerguroInterfaceService _pagSeguroService;
        public PagamentosController(
            ILogger<PagamentosController> logger,
            IPagSerguroInterfaceService pagSeguroService
           )
        {
            _logger = logger;
            _pagSeguroService = pagSeguroService;
        }

        [HttpPost("gerarpagamento/{idOrder}")]
        public IEnumerable<PagamentoPagSegModel> Post([FromBody] PagamentoPagSegModel pagamento, string idOrder)
        {
            try
            {
                var apiPagSeguroCriarPagamento = _pagSeguroService.GerarPagamentoPedido(pagamento, idOrder);
            }
            catch (ArgumentException ex)
            {

                return (IEnumerable<PagamentoPagSegModel>)StatusCode((int)HttpStatusCode.InternalServerError, ex.Message); //500 Internal Error -- Erro interno do servidor.
            }
            return null;
        }

        [HttpPost("cancelarpagamento/{charge_id}")]
        public IEnumerable<PagamentoPagSegModel> Post([FromBody] PagamentoAmountNoCurrencyModel pagamentoAmount, string charge_id)
        {
            try
            {
                var apiPagSeguroCriarPagamento = _pagSeguroService.CancelarPagamentoPedido(pagamentoAmount, charge_id);
            }
            catch (ArgumentException ex)
            {

                return (IEnumerable<PagamentoPagSegModel>)StatusCode((int)HttpStatusCode.InternalServerError, ex.Message); //500 Internal Error -- Erro interno do servidor.
            }
            return null;
        }

        [HttpGet("consultarpagamento/{char_id}")]
        public IEnumerable<PagamentoPagSegModel> Get(string charge_id)
        {
            try
            {
                var apiPagSeguroConsultarPagamento = _pagSeguroService.ConsultarPagamentoPedido(charge_id);
            }
            catch (ArgumentException ex)
            {

                return (IEnumerable<PagamentoPagSegModel>)StatusCode((int)HttpStatusCode.InternalServerError, ex.Message); //500 Internal Error -- Erro interno do servidor.
            }
            return null;
        }
    }
}