using api.Models.PedidosModel;
using api.Models.PagamentoPagSegModel;
using api.Models.PedidosPagSegModel;

namespace api.Interfaces.PagSeguroInterfaceService
{
    public interface IPedidosInterfaceService
    {
        Task<PedidosModel> GerarPedido(PedidoPagSegModel predido);
        Task<PedidosModel> ConsultarPedido(string id);
    }
}