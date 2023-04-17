using appStore.Models.UsuarioModel;

namespace appStore.Interfaces.Repository.UsuariosInterfaceRepository
{
    public interface IUsuariosInterfaceRepository
    {
        Task<bool> CadastrarUsuario(UsuarioModel usuario);
        //Task<PedidoPagSegModel> ConsultarPedido(string id);
        //Task<PagamentoPagSegModel> GerarPagamentoPedido(PagamentoPagSegModel pagamento, string idOrder);
        //Task<PagamentoPagSegModel> ConsultarPagamentoPedido(string charge_id);
        //Task<PagamentoPagSegModel> CancelarPagamentoPedido(PagamentoAmountNoCurrencyModel pagamentoAmount, string charge_id);
    }
}
