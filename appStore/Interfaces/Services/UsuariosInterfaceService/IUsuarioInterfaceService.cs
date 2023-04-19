using api.Models.UsuarioModel;

namespace api.Interfaces.UsuariosInterfaceService
{
    public interface IUsuariosInterfaceService
    {
        Task<UsuarioModel> CadastrarUsuario(UsuarioModel usuario);
        //Task<PedidoPagSegModel> ConsultarPedido(string id);
        //Task<PagamentoPagSegModel> GerarPagamentoPedido(PagamentoPagSegModel pagamento, string idOrder);
        //Task<PagamentoPagSegModel> ConsultarPagamentoPedido(string charge_id);
        //Task<PagamentoPagSegModel> CancelarPagamentoPedido(PagamentoAmountNoCurrencyModel pagamentoAmount, string charge_id);
    }
}
