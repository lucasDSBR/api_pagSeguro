
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api.Models.PedidosModel;
namespace api.Models
{
    public class PedidoQrCodeModel
    {
        public PedidoQrCodeValueModel amount { get; set; }
    }

    public class PedidoQrCodeValueModel
    {
        public int value { get; set; }
    }

    
}