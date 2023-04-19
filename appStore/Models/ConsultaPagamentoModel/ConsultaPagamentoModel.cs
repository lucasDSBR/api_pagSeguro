namespace api.Models.ConsultaPagamentoModel
{
    public class ConsultaPagamentoModel
    {
        public string id { get; set; }
        public string reference_id { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public string description { get; set; }
        public ConsultaPagamentoAmountModel amount { get; set; }
        public ConsultaPagamentoPaymentResponseModel payment_response { get; set; }
        public ConsultaPagamentoPaymentMethodModel payment_method { get; set; }
        public List<ConsultaPagamentoLinkModel> links { get; set; }
        public List<string> notification_urls { get; set; }
    }

    public class ConsultaPagamentoAmountModel
    {
        public decimal value { get; set; }
        public string currency { get; set; }
        public ConsultaPagamentoSummaryModel summary { get; set; }
    }

    public class ConsultaPagamentoSummaryModel
    {
        public decimal total { get; set; }
        public decimal paid { get; set; }
        public decimal refunded { get; set; }
    }

    public class ConsultaPagamentoPaymentResponseModel
    {
        public int code { get; set; }
        public string message { get; set; }
        public string reference { get; set; }
    }

    public class ConsultaPagamentoPaymentMethodModel
    {
        public string type { get; set; }
        public int installments { get; set; }
        public bool capture { get; set; }
        public ConsultaPagamentoCardModel card { get; set; }
    }

    public class ConsultaPagamentoCardModel
    {
        public string brand { get; set; }
        public string first_digits { get; set; }
        public string last_digits { get; set; }
        public string exp_month { get; set; }
        public string exp_year { get; set; }
        public ConsultaPagamentoHolderModel holder { get; set; }
    }

    public class ConsultaPagamentoHolderModel
    {
        public string name { get; set; }
    }

    public class ConsultaPagamentoLinkModel
    {
        public string rel { get; set; }
        public string href { get; set; }
        public string media { get; set; }
        public string type { get; set; }
    }


}