using Microsoft.AspNetCore.Mvc;
using api.Models.PagamentosModel;
using api.Models.AssinaturaModel;
using api.Models.AssinaturaModel.AssinaturaSubModel;

namespace api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]

    public class AssinaturaController : ControllerBase
    {
        private readonly ILogger<AssinaturaController> _logger;
        public AssinaturaController(
            ILogger<AssinaturaController> logger
           )
        {
            _logger = logger;
        }

        [HttpPost("assinatura")]
        public Task<PagamentosModel> PostAssinatura([FromBody] AssinaturaModel assinatura)
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
        [HttpPost("assinaturaSub")]
        public Task<PagamentosModel> PostAssinaturaSub([FromBody] AssinaturaSubModel assinatura)
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

    }
}