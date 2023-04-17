using appStore.Models.PedidosModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace appStore.Interfaces.PedidosInterfaceRepository
{
    public interface IPedidosInterfaceRepository
    {
        Task<bool> GerarPedido(PedidosModel pedido);
    }
}
