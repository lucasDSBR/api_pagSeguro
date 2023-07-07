using Microsoft.AspNetCore.Mvc;
using api.Models.PagamentosModel;
using api.Models.AssinaturaModel;
using api.Models.AssinaturaModel.AssinaturaSubModel;
using api.Models.PedidosPagSegModel;
using api.Models.AdesaoPlanoModel;
using api.Interfaces.PagSeguroInterfaceService;
using api.Interfaces.PlanoInterfaceService;

namespace api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]

    public class PlanoController : ControllerBase
    {
        private readonly ILogger<PlanoController> _logger;
        private readonly IPlanoInterfaceService _planoService;
        public PlanoController(
            ILogger<PlanoController> logger,
            IPlanoInterfaceService planoService
           )
        {
            _logger = logger;
            _planoService = planoService;
        }

        [HttpPost("gerarplano/{email}/{token}")]
        public Task<PagamentosModel> PostGerarPlano(string email, string token)
        {
            try
            {
                //var result = _pagamentosService.GerarPagamento(pagamento, idOrder);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpPost("gerarSessao/{email}/{token}")]
        public Task<PagamentosModel> PostGerarSessao(string email, string token) 
        {
            try
            {
                //var result = _pagamentosService.GerarPagamento(pagamento, idOrder);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpPost("adesaoPlano")]
        public Task<PagamentosModel> PostAdesaoPlano([FromBody] CartaoAdesaoPlanoModel data)
        {
            try
            {
                var result = _planoService.AdesaoPlano(data);
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}