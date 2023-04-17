using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appStore.Models
{
	public class PedidoAddressModel
	{
		public string street { get; set; }
		public string number { get; set; }
		public string complement { get; set; }
		public string locality { get; set; }
		public string city { get; set; }
		public string region_code { get; set; }
		public string country { get; set; }
		public string postal_code { get; set; }

	}
}