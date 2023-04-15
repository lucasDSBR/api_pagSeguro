namespace appStore.Models.PagamentoModel
{
    public class PagamentoCardModel
    {
        public string number { get; set; }
        public string exp_month { get; set; }
        public string exp_year { get; set; }
        public string security_code { get; set; }
        public PagamentoHolderModel holder { get; set; }
        public bool store { get; set; }
    }
}
