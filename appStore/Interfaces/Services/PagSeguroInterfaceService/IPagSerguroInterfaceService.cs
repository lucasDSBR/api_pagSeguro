using appStore.Models.PedidosModel;
using appStore.Models.PagamentoPagSegModel;
using appStore.Models.PedidosPagSegModel;

namespace appStore.Interfaces.PagSeguroInterfaceService
{
    public interface IPagSerguroInterfaceService
    {
        Task<string> GerarPedido(PedidoPagSegModel predido);
        Task<PedidoPagSegModel> ConsultarPedido(string id);
        Task<PagamentoPagSegModel> GerarPagamentoPedido(PagamentoPagSegModel pagamento, string idOrder);
        Task<PagamentoPagSegModel> ConsultarPagamentoPedido(string charge_id);
        Task<PagamentoPagSegModel> CancelarPagamentoPedido(PagamentoAmountNoCurrencyModel pagamentoAmount, string charge_id);
    }
}