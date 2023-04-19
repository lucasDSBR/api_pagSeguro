using api.Models.PedidosModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Interfaces.PedidosInterfaceRepository
{
    public interface IPedidosInterfaceRepository
    {
        Task<bool> GerarPedido(PedidosModel pedido);
    }
}
