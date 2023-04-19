using api.Models.PedidosModel;
using api.Services;
using api.Services.PagSeguroService;
using api.Interfaces.UsuariosInterfaceService;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using api.Models.PedidosPagSegModel;
using api.Services.UsuariosService;
using api.Models.UsuarioModel;

namespace api.Controllers
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