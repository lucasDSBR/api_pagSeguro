
using api.Models.PagamentoPagSegModel;
using api.Interfaces.PagamentosInterfaceService;
using api.Models.PagamentosModel;
using api.Interfaces.PagSeguroInterfaceService;
using api.Models.PedidosModel;
using Newtonsoft.Json;
using api.Models.CancelamentoPagamentoModel;
using api.Models.ConsultaPagamentoModel;

namespace api.Services
{
    public class PagamentosService : IPagamentosInterfaceService
    {
        static HttpClient client = new HttpClient();


        private readonly ILogger<PagamentosService> _logger;
        private readonly IPagSerguroInterfaceService _pagSeguroService;

        public PagamentosService(ILogger<PagamentosService> logger,
            IPagSerguroInterfaceService pagSeguroService
        )
        {
            _logger = logger;
            _pagSeguroService = pagSeguroService;
        }

        public async Task<PagamentosModel> GerarPagamento(PagamentoPagSegModel pagamento, string idpedido)
        {
            try
            {
                var result = await _pagSeguroService.GerarPagamentoPedido(pagamento, idpedido);
                PagamentosModel pagamentoOk = JsonConvert.DeserializeObject<PagamentosModel>(result);

                return pagamentoOk;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<CancelamentoPagamentoModel> CancelarPagamento(PagamentoAmountNoCurrencyModel pagamento, string idpedido)
        {
            try
            {
                var result =  await _pagSeguroService.CancelarPagamento(pagamento, idpedido);
                CancelamentoPagamentoModel cancelamento = JsonConvert.DeserializeObject<CancelamentoPagamentoModel>(result);

                return cancelamento;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<ConsultaPagamentoModel> ConsultarPagamento(string charge_id)
        {
            try
            {
                var result = await _pagSeguroService.ConsultarPagamentoPedido(charge_id);
                ConsultaPagamentoModel consulta = JsonConvert.DeserializeObject<ConsultaPagamentoModel>(result);

                return consulta;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
