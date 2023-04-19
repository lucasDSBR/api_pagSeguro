namespace api.Models.CancelamentoPagamentoModel
{
    public class CancelamentoPagamentoModel
    {
        public string id { get; set; }
        public string reference_id { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime paid_at { get; set; }
        public string description { get; set; }
        public CancelamentoPagamentoAmountModel amount { get; set; }
        public CancelamentoPagamentoPaymentResponseModel payment_response { get; set; }
        public CancelamentoPagamentoPaymentMethodModel payment_method { get; set; }
        public List<object> links { get; set; }
        public List<string> notification_urls { get; set; }
        public Dictionary<string, object> metadata { get; set; }
    }

    public class CancelamentoPagamentoAmountModel
    {
        public int value { get; set; }
        public string currency { get; set; }
        public CancelamentoPagamentoSummaryModel summary { get; set; }
    }

    public class CancelamentoPagamentoSummaryModel
    {
        public int total { get; set; }
        public int paid { get; set; }
        public int refunded { get; set; }
    }

    public class CancelamentoPagamentoPaymentResponseModel
    {
        public string code { get; set; }
        public string message { get; set; }
        public string reference { get; set; }
    }

    public class CancelamentoPagamentoPaymentMethodModel
    {
        public string type { get; set; }
        public int installments { get; set; }
        public bool capture { get; set; }
        public CancelamentoPagamentoCardModel card { get; set; }
    }

    public class CancelamentoPagamentoCardModel
    {
        public string brand { get; set; }
        public string first_digits { get; set; }
        public string last_digits { get; set; }
        public string exp_month { get; set; }
        public string exp_year { get; set; }
        public CancelamentoPagamentoHolderModel holder { get; set; }
    }

    public class CancelamentoPagamentoHolderModel
    {
        public string name { get; set; }
    }
}



