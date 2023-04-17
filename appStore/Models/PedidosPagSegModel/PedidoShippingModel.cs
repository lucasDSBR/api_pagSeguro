using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appStore.Models
{
	public class PedidoShippingModel
	{
		public PedidoAddressModel address { get; set; }
	}
}