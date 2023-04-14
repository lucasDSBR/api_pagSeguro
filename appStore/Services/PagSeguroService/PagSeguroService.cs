using System;
using System.Net;
using System.Net.Http;
using System;
using System.Net.Http;
using appStore.Models;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using appStore.Interfaces.PagSeguroInterfaceService;

namespace appStore.Services.PagSeguroService
{
    public class PagSeguroService : IPagSerguroInterfaceService
    {
        static HttpClient client = new HttpClient();


        private readonly ILogger<PedidoService> _logger;
        public PagSeguroService(ILogger<PedidoService> logger)
        {
            _logger = logger;
        }

        public async Task<PedidoModel> CriarPedido(PedidoModel predido)
        {
            try
            {
                using var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, "https://sandbox.api.pagseguro.com/orders");

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "A0B2626219B4463787B43E9180EA1477");

                var body = JsonConvert.SerializeObject(predido);

                request.Content = new StringContent(body, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                if(response.StatusCode == HttpStatusCode.Created)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var item = JsonConvert.DeserializeObject<PedidoModel>(content);
                    return item;
                }
                else
                {
                    throw new Exception("Erro ao tentar criar o pedido");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        public async Task<PedidoModel> ConsultarPedido(string idPedido)
        {
            try
            {
                using var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, "https://sandbox.api.pagseguro.com/orders/"+ idPedido);

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "XXXX");


                var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var item = JsonConvert.DeserializeObject<PedidoModel>(content);
                    return item;
                }
                else
                {
                    throw new Exception("Erro ao tentar criar o pedido");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }


        
    }
}
