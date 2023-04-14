using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appStore.Models
{
	[Table("PedidosShipping")]
	public class PedidoShippingModel
	{
		public PedidoAddressModel address { get; set; }

	}
}