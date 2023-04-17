using appStore.Context;
using appStore.Models.PedidosModel;
using appStore.Interfaces.PedidosInterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.Logging;


namespace appStore.Repositories.PedidosRepository
{
    public class PedidosRepository : IPedidosInterfaceRepository
    {
        protected readonly MyContext _context;
        private DbSet<PedidosModel> _dataSet;
        private readonly ILogger<PedidosRepository> _logger;

        public PedidosRepository(MyContext context, ILogger<PedidosRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<bool> GerarPedido(PedidosModel pedido)
        {


            try
            {
                _context.Pedidos.Add(pedido);
                _context.SaveChanges();
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex, "Error retrieving user with ID");
                return false;
            }

            return false;
        } 
    }
}
