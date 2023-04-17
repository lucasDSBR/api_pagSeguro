using appStore.Interfaces.PagSeguroInterfaceService;
using appStore.Models.PedidosModel;
using appStore.Models.PedidosPagSegModel;
using appStore.Interfaces.PedidosInterfaceRepository;
using System.Net;
using appStore.Context;
using appStore.Interfaces.UsuariosInterfaceService;
using appStore.Models.UsuarioModel;
using appStore.Interfaces.Repository.UsuariosInterfaceRepository;

namespace appStore.Services.UsuariosService
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
