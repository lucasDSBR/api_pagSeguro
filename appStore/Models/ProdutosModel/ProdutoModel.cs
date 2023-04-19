using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
	public class ProdutoModel
	{
		public string name { get; set; }
		public int quantity { get; set; }
		public int unit_amount { get; set; }

	}
}