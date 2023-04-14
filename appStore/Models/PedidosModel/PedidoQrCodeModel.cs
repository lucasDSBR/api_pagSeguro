
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using appStore.Models.PedidosModel;
namespace appStore.Models
{
    [Table("PedidosQrCode")]
    public class PedidoQrCodeModel
    {
        public PedidoQrCodeValueModel amount { get; set; }
    }

    public class PedidoQrCodeValueModel
    {
        public int value { get; set; }
    }

    
}