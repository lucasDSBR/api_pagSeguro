using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appStore.Models
{
	[Table("Produtos")]
	public class ProdutoModel
	{
		public string name { get; set; }
		public int quantity { get; set; }
		public int unit_amount { get; set; }

	}
}