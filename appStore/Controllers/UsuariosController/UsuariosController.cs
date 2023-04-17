using appStore.Models.PedidosModel;
using appStore.Services;
using appStore.Services.PagSeguroService;
using appStore.Interfaces.UsuariosInterfaceService;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using appStore.Models.PedidosPagSegModel;
using appStore.Services.UsuariosService;
using appStore.Models.UsuarioModel;

namespace appStore.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]

    public class UsuariosController : ControllerBase
    {
        private readonly ILogger<UsuariosController> _logger;
        private readonly IUsuariosInterfaceService _usuariosService;
        public UsuariosController(
            ILogger<UsuariosController> logger,
            IUsuariosInterfaceService usuariosService
           )
        {
            _logger = logger;
            _usuariosService  = usuariosService;
        }

        [HttpGet("consultarusuario/{id}")]
        public IEnumerable<PedidoPagSegModel> Get(string id)
        {
            try
            {
                //var apiPagSeguroCriar = _pagSeguroService.ConsultarPedido(id);
            }
            catch (ArgumentException ex)
            {

                return (IEnumerable<PedidoPagSegModel>)StatusCode((int)HttpStatusCode.InternalServerError, ex.Message); //500 Internal Error -- Erro interno do servidor.
            }
            return null;
        }

        [HttpPost("cadastrarusuario")]
        public IEnumerable<PedidoPagSegModel> Post([FromBody] UsuarioModel usuario)
        {
            try
            {
                var result = _usuariosService.CadastrarUsuario(usuario);
            }
            catch (ArgumentException ex)
            {

                return (IEnumerable<PedidoPagSegModel>)StatusCode((int)HttpStatusCode.InternalServerError, ex.Message); //500 Internal Error -- Erro interno do servidor.
            }
            return null;
        }
    }
}