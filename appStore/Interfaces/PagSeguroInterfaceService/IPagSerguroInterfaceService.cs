using appStore.Models;

namespace appStore.Interfaces.PagSeguroInterfaceService
{
    public interface IPagSerguroInterfaceService
    {
        Task<PedidoModel> CriarPedido(PedidoModel predido);
        Task<PedidoModel> ConsultarPedido(string id);
    }
}