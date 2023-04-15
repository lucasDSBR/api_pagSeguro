namespace appStore.Models.PagamentoModel
{
    public class PagamentoChargesModel
    {
        public string reference_id { get; set; }
        public string description { get; set; }
        public PagamentoAmountModel amount { get; set; }
        public PagamentoMethodModel payment_method { get; set; }
        public PagamentoMetadataModel metadata { get; set; }
        public string[] notification_urls { get; set; }
    }
}
