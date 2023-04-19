using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
	public class PedidoShippingModel
	{
		public PedidoAddressModel address { get; set; }
	}
}