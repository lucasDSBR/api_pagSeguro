using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appStore.Models
{
    [Table("PedidosPhone")]
    public class PedidoPhoneModel
    {
        public string country { get; set; }
        public string area { get; set; }
        public string number { get; set; }
        public string type { get; set; }

    }
}