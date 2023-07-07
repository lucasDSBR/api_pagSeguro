using api.Models.PedidosModel;
using api.Services;
using api.Services.PagSeguroService;
using api.Interfaces.UsuariosInterfaceService;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using api.Models.PedidosPagSegModel;
using api.Services.UsuariosService;
using api.Models.UsuarioModel;
using System.Text;

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
            _usuariosService = usuariosService;
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
        //Caso esteja utilizando controller
        [HttpPost("/endpointParaReceberInter")]
        public async Task<IActionResult> webhookInter()
        {
            if (Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase))
            {
                Response.ContentType = "application/json";
                Response.StatusCode = 200;

                string body = string.Empty;
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    body = await reader.ReadToEndAsync();
                }

                Console.WriteLine(body); //Aqui dá um console do JSON recebido

                //Retornando o JSON
                return Content(body);
            }

            return BadRequest();
        }
    }
}

