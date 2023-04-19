namespace api.Models.PagamentoPagSegModel
{
    public class PagamentoMethodModel
    {
        public string type { get; set; }
        public int installments { get; set; }
        public bool capture { get; set; }
        public PagamentoCardModel card { get; set; }
    }
}
