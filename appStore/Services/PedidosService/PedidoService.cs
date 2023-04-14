using appStore.Models;

namespace appStore.Services
{
    public class PedidoService
    {
        static HttpClient client = new HttpClient();


        private readonly ILogger<PedidoService> _logger;
        public PedidoService(ILogger<PedidoService> logger)
        {
            _logger = logger;
        }

        public async Task<PedidoModel> CriarPedido(PedidoModel predido)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("https://sandbox.api.pagseguro.com/orders", predido);
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
