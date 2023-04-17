using appStore.Interfaces.PagSeguroInterfaceService;
using appStore.Interfaces.PedidosInterfaceRepository;
using appStore.Models.PedidosPagSegModel;
using System.Text.Json;
using System;
using System.Collections.Generic;
using appStore.Models.PedidosModel;
using Newtonsoft.Json;
using System.Reflection.Metadata;

namespace appStore.Services.PedidosService
{
    public class PedidosService : IPedidosInterfaceService
    {
        private readonly ILogger<PedidosService> _logger;
        private readonly IPagSerguroInterfaceService _pagSeguroService;
        private readonly IPedidosInterfaceRepository _pedidosRepository;
        public PedidosService(ILogger<PedidosService> logger,
            IPagSerguroInterfaceService pagSeguroService,
            IPedidosInterfaceRepository pedidosRepository
        )
        {
            _logger = logger;
            _pagSeguroService = pagSeguroService;
            _pedidosRepository = pedidosRepository;
        }

        public async Task<PedidoPagSegModel> GerarPedido(PedidoPagSegModel predido)
        {
            try
            {
                var resultPagSeguro = _pagSeguroService.GerarPedido(predido);

                PedidosModel pedido = JsonConvert.DeserializeObject<PedidosModel>(resultPagSeguro.Result);

                _pedidosRepository.GerarPedido(pedido);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao realizar registro do pedido");
                return null;
            }
            return null;
        }
    }
}
