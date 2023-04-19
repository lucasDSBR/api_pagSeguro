using api.Interfaces.PagSeguroInterfaceService;
using api.Models.PedidosModel;
using api.Models.PedidosPagSegModel;
using api.Interfaces.PedidosInterfaceRepository;
using System.Net;
using api.Context;
using api.Interfaces.UsuariosInterfaceService;
using api.Models.UsuarioModel;
using api.Interfaces.Repository.UsuariosInterfaceRepository;

namespace api.Services.UsuariosService
{
    public class UsuariosService : IUsuariosInterfaceService
    {

        private readonly ILogger<UsuariosService> _logger;
        private readonly IUsuariosInterfaceRepository _usuariosInterfaceRepository;
        public UsuariosService(ILogger<UsuariosService> logger,
            IUsuariosInterfaceRepository usuariosInterfaceRepository
        )
        {
            _logger = logger;
            _usuariosInterfaceRepository = usuariosInterfaceRepository;
        }

        public async Task<UsuarioModel> CadastrarUsuario(UsuarioModel usuario)
        {
            try
            {
                var result = _usuariosInterfaceRepository.CadastrarUsuario(usuario);

            }
            catch (Exception ex)
            {

                return null;
            }
            return null;
        }
    }
}
