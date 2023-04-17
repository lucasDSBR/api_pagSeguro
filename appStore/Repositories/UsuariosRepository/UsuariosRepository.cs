using appStore.Context;
using appStore.Models.PedidosModel;
using appStore.Interfaces.Repository.UsuariosInterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.Logging;
using appStore.Models.UsuarioModel;

namespace appStore.Repositories.PedidosRepository
{
    public class UsuariosRepository : IUsuariosInterfaceRepository
    {
        protected readonly MyContext _context;
        private readonly ILogger<UsuariosRepository> _logger;

        public UsuariosRepository(MyContext context, ILogger<UsuariosRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<bool> CadastrarUsuario(UsuarioModel usuario)
        {
            try
            {
                _logger.LogInformation("Iniciando registro de usuario...");
                _context.Usuarios.Add(usuario);
                var result = _context.SaveChanges();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving user with ID");
                return false;
            }

            return false;
        }
    }
}
