using api.Models.CancelamentoPagamentoModel;
using api.Models.ConsultaPagamentoModel;
using api.Models.PagamentoPagSegModel;
using api.Models.PagamentosModel;

namespace api.Interfaces.PagamentosInterfaceService
{
    public interface IPagamentosInterfaceService
    {
        Task<PagamentosModel> GerarPagamento(PagamentoPagSegModel pagamento, string idpedido);
        Task<CancelamentoPagamentoModel> CancelarPagamento(PagamentoAmountNoCurrencyModel pagamentoAmount, string charge_id);
        Task<ConsultaPagamentoModel> ConsultarPagamento(string charge_id);
    }
}