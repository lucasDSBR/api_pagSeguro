using api.Interfaces.PagSeguroInterfaceService;
using api.Interfaces.PedidosInterfaceRepository;
using api.Models.PedidosPagSegModel;
using System.Text.Json;
using System;
using System.Collections.Generic;
using api.Models.PedidosModel;
using Newtonsoft.Json;
using System.Reflection.Metadata;
using System.Net.Http.Headers;
using System.Net;

namespace api.Services.PedidosService
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

        public async Task<PedidosModel> GerarPedido(PedidoPagSegModel predido)
        {
            try
            {
                var resultPagSeguro = _pagSeguroService.GerarPedido(predido);

                PedidosModel pedido = JsonConvert.DeserializeObject<PedidosModel>(resultPagSeguro.Result);

                _pedidosRepository.GerarPedido(pedido);

                return pedido;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao realizar registro do pedido");
            }
        }

        public async Task<PedidosModel> ConsultarPedido(string idPedido)
        {
            try
            {
                var resultPagSeguro = await _pagSeguroService.ConsultarPedido(idPedido);

                PedidosModel pedido = JsonConvert.DeserializeObject<PedidosModel>(resultPagSeguro);

                return pedido;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao realizar consulta do pedido");
            }
        }
    }
}
