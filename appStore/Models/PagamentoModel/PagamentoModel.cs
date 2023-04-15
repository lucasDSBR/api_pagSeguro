using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appStore.Models.PagamentoModel
{
    [Table("Pagamentos")]
    public class PagamentoModel
    {
        public IEnumerable<PagamentoChargesModel> charges { get; set; }

    }
}