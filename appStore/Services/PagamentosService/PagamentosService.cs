using appStore.Models.PedidosModel;
using appStore.Models.PagamentoPagSegModel;

namespace appStore.Services
{
    public class PagamentosService
    {
        static HttpClient client = new HttpClient();


        private readonly ILogger<PagamentosService> _logger;
        public PagamentosService(ILogger<PagamentosService> logger)
        {
            _logger = logger;
        }

        public async Task<PagamentoPagSegModel> CriarPagamentoPedido(PagamentoPagSegModel pagamento)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("https://sandbox.api.pagseguro.com/orders", pagamento);
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
