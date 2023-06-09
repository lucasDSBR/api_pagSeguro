using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models.PedidosPagSegModel
{
	public class PedidoPagSegModel
    {
		public string reference_id { get; set; }
		public DateTime created_at { get; set; }
		public PedidoCustomerModel customer { get; set; }
		public IEnumerable<ProdutoModel> items { get; set; }
		public IEnumerable<PedidoQrCodeModel> qr_codes { get; set; }
		public PedidoShippingModel shipping { get; set; }
		public string[] notification_urls {get; set; }

	}
}