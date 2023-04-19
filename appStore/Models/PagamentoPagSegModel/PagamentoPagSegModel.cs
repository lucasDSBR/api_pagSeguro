using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models.PagamentoPagSegModel
{
    public class PagamentoPagSegModel
    {
        public IEnumerable<PagamentoChargesModel> charges { get; set; }

    }
}