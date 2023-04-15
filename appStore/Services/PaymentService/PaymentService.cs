using appStore.Models.PedidosModel;
using appStore.Models.PagamentoModel;

namespace appStore.Services
{
    public class PaymentService
    {
        static HttpClient client = new HttpClient();


        private readonly ILogger<PedidoService> _logger;
        public PaymentService(ILogger<PedidoService> logger)
        {
            _logger = logger;
        }

        public async Task<PedidoModel> CriarPagamentoPedido(PagamentoModel pagamento)
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
