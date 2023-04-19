using System;
using System.Net;
using System.Net.Http;
using System;
using System.Net.Http;
using api.Models.PedidosPagSegModel;
using api.Models.PagamentoPagSegModel;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using api.Interfaces.PagSeguroInterfaceService;

namespace api.Services.PagSeguroService
{
    public class PagSeguroService : IPagSerguroInterfaceService
    {
        static HttpClient client = new HttpClient();


        private readonly ILogger<PagSeguroService> _logger;
        private readonly IConfiguration _config;
        public PagSeguroService(ILogger<PagSeguroService> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        
        public async Task<string> GerarPedido(PedidoPagSegModel predido)
        {
            string BearerToken = _config["TokensAcesso:BearerToken"];
            string EndPoint = _config["EndPoints:ApiPagSeguto"];
            try
            {
                using var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, $"{EndPoint}/orders");

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", $"{BearerToken}");

                var body = JsonConvert.SerializeObject(predido);

                request.Content = new StringContent(body, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                if(response.StatusCode == HttpStatusCode.Created)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception("Erro ao tentar gerar o pedido");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao tentar gerar o pedido");
            }
        }

        public async Task<string> ConsultarPedido(string idPedido)
        {
            string BearerToken = _config["TokensAcesso:BearerToken"];
            string EndPoint = _config["EndPoints:ApiPagSeguto"];
            try
            {
                using var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"{EndPoint}/orders/" + idPedido);

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", $"{BearerToken}");

                var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception("Erro ao tentar consultar pedido...");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao tentar consultar o pedido");
            }
        }

        public async Task<string> ConsultarPagamentoPedido(string charge_id)
        {
            string BearerToken = _config["TokensAcesso:BearerToken"];
            string EndPoint = _config["EndPoints:ApiPagSeguto"];
            try
            {
                using var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"{EndPoint}/charges/{charge_id}");

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", $"{BearerToken}");

                request.Content = new StringContent("", Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception("Erro ao consultar pagamento");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao consultar pagamento");
            }
        }

        public async Task<string> GerarPagamentoPedido(PagamentoPagSegModel pagamento, string idOrder)
        {
            string BearerToken = _config["TokensAcesso:BearerToken"];
            string EndPoint = _config["EndPoints:ApiPagSeguto"];
            try
            {
                using var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, $"{EndPoint}/orders/{idOrder}/pay");

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", $"{BearerToken}");

                var body = JsonConvert.SerializeObject(pagamento);

                request.Content = new StringContent(body, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception("Erro ao gerar o pagamento");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao gerar pagamento do pedido");
            }
        }

        public async Task<string> CancelarPagamento(PagamentoAmountNoCurrencyModel pagamentoAmount, string charge_id)
        {
            string BearerToken = _config["TokensAcesso:BearerToken"];
            string EndPoint = _config["EndPoints:ApiPagSeguto"];
            try
            {
                using var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, $"{EndPoint}/charges/{charge_id}/cancel");

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", $"{BearerToken}");

                var body = JsonConvert.SerializeObject(pagamentoAmount);

                request.Content = new StringContent(body, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception("Erro ao cancelar pagamento");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cancelar pagamento");
            }
        }
    }
}
