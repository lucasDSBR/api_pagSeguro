using System;
using System.Net;
using System.Net.Http;
using System;
using System.Net.Http;
using appStore.Models.PedidosPagSegModel;
using appStore.Models.PagamentoPagSegModel;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using appStore.Interfaces.PagSeguroInterfaceService;

namespace appStore.Services.PagSeguroService
{
    public class PagSeguroService : IPagSerguroInterfaceService
    {
        static HttpClient client = new HttpClient();


        private readonly ILogger<PagSeguroService> _logger;
        public PagSeguroService(ILogger<PagSeguroService> logger)
        {
            _logger = logger;
        }

        public async Task<string> GerarPedido(PedidoPagSegModel predido)
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
                    var teste = content.GetType();
                    return content;
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

        public async Task<PedidoPagSegModel> ConsultarPedido(string idPedido)
        {
            try
            {
                using var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, "https://sandbox.api.pagseguro.com/orders/"+ idPedido);

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "xx");


                var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var item = JsonConvert.DeserializeObject<PedidoPagSegModel>(content);
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

        public async Task<PagamentoPagSegModel> ConsultarPagamentoPedido(string charge_id)
        {
            try
            {
                using var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"https://sandbox.api.pagseguro.com/charges/{charge_id}");

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "xx");

                request.Content = new StringContent("", Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var item = JsonConvert.DeserializeObject<PagamentoPagSegModel>(content);
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

        public async Task<PagamentoPagSegModel> GerarPagamentoPedido(PagamentoPagSegModel pagamento, string idOrder)
        {
            try
            {
                using var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, $"https://sandbox.api.pagseguro.com/orders/{idOrder}/pay");

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "xx");

                var body = JsonConvert.SerializeObject(pagamento);

                request.Content = new StringContent(body, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var item = JsonConvert.DeserializeObject<PagamentoPagSegModel>(content);
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

        public async Task<PagamentoPagSegModel> CancelarPagamentoPedido(PagamentoAmountNoCurrencyModel pagamentoAmount, string charge_id)
        {
            try
            {
                using var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, $"https://sandbox.api.pagseguro.com/charges/{charge_id}/cancel");

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "xx");

                var body = JsonConvert.SerializeObject(pagamentoAmount);

                request.Content = new StringContent(body, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var item = JsonConvert.DeserializeObject<PagamentoPagSegModel>(content);
                    return item;
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Erro ao tentar criar o pedido: {content}");
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
