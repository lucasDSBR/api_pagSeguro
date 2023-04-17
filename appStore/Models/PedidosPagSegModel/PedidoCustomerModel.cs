using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appStore.Models
{
	public class PedidoCustomerModel
	{
		public string name { get; set; }
		public string email { get; set; }
		public string tax_id { get; set; }
		public IEnumerable<PedidoPhoneModel> phones { get; set; }

	}
}