using api.Models;
using api.Services;
using api.Services.PagSeguroService;
using api.Interfaces.PagSeguroInterfaceService;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using api.Models.PagamentoPagSegModel;
using api.Interfaces.PagamentosInterfaceService;
using api.Models.PagamentosModel;
using api.Models.CancelamentoPagamentoModel;
using api.Models.ConsultaPagamentoModel;

namespace api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]

    public class PagamentosController : ControllerBase
    {
        private readonly ILogger<PagamentosController> _logger;
        private readonly IPagSerguroInterfaceService _pagSeguroService;
        private readonly IPagamentosInterfaceService _pagamentosService;
        public PagamentosController(
            ILogger<PagamentosController> logger,
            IPagamentosInterfaceService pagamentosService
           )
        {
            _logger = logger;
            _pagamentosService = pagamentosService;
        }

        [HttpPost("gerarpagamento/{idOrder}")]
        public Task<PagamentosModel> Post([FromBody] PagamentoPagSegModel pagamento, string idOrder)
        {
            try
            {
                var result = _pagamentosService.GerarPagamento(pagamento, idOrder);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("cancelarpagamento/{charge_id}")]
        public Task<CancelamentoPagamentoModel> Post([FromBody] PagamentoAmountNoCurrencyModel pagamentoAmount, string charge_id)
        {
            try
            {
                var result = _pagamentosService.CancelarPagamento(pagamentoAmount, charge_id);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("consultarpagamento/{charge_id}")]
        public Task<ConsultaPagamentoModel> Get(string charge_id)
        {
            try
            {
                var result = _pagamentosService.ConsultarPagamento(charge_id);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}