using api.Models.PedidosModel;
using api.Models.PagamentoPagSegModel;
using api.Models.PedidosPagSegModel;

namespace api.Interfaces.PagSeguroInterfaceService
{
    public interface IPagSerguroInterfaceService
    {
        Task<string> GerarPedido(PedidoPagSegModel predido);
        Task<string> ConsultarPedido(string id);
        Task<string> GerarPagamentoPedido(PagamentoPagSegModel pagamento, string idOrder);
        Task<string> ConsultarPagamentoPedido(string charge_id);
        Task<string> CancelarPagamento(PagamentoAmountNoCurrencyModel pagamentoAmount, string charge_id);
    }
}