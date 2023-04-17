using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appStore.Models.PagamentoPagSegModel
{
    public class PagamentoPagSegModel
    {
        public IEnumerable<PagamentoChargesModel> charges { get; set; }

    }
}