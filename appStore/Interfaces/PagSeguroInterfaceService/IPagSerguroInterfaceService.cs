using appStore.Models.PedidosModel;
using appStore.Models.PagamentoModel;
namespace appStore.Interfaces.PagSeguroInterfaceService
{
    public interface IPagSerguroInterfaceService
    {
        Task<PedidoModel> CriarPedido(PedidoModel predido);
        Task<PedidoModel> ConsultarPedido(string id);
        Task<PagamentoModel> GerarPagamentoPedido(PagamentoModel pagamento, string idOrder);
        Task<PagamentoModel> ConsultarPagamentoPedido(string charge_id);
        Task<PagamentoModel> CancelarPagamentoPedido(PagamentoAmountNoCurrencyModel pagamentoAmount, string charge_id);
    }
}