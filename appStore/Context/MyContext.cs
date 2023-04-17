using Microsoft.EntityFrameworkCore;
using appStore.Models.PedidosModel;
using appStore.Models.UsuarioModel;

namespace appStore.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<PedidosModel> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PedidosModel>()
                .Property(p => p.notification_urls)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
            modelBuilder.Entity<PedidosQrCodesModel>()
               .Property(p => p.arrangements)
               .HasConversion(
                   v => string.Join(',', v),
                   v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
