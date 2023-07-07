namespace api.Models.AssinaturaModel
{
    public class AssinaturaModel
    {
        public string reference_id { get; set; }
        public customerModel customer { get; set; }
        public IEnumerable<itemsModel> itens { get; set; }
        public shippingModel shipping { get; set; }
        public string[] notification_urls { get; set; }
        public IEnumerable<chargesModel> charges { get; set; }
    }
    public class customerModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string tax_id { get; set; }
        public IEnumerable<phonesCustomerModel> phone { get; set; }

    }
    public class phonesCustomerModel
    {
        public string country { get; set; }
        public string area { get; set; }
        public string number { get; set; }
        public string type { get; set; }
    }
    public class itemsModel
    {
        public string reference_id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public int unit_amount { get; set; }
    }
    public class shippingModel
    {
        public addressShippingModel address { get; set; }
    }
    public class addressShippingModel
    {
        public string street { get; set; }
        public string number { get; set; }
        public string complement { get; set; }
        public string locality { get; set; }
        public string city { get; set; }
        public string region_code { get; set; }
        public string country { get; set; }
        public string postal_code { get; set; }
    }
    public class chargesModel
    {
        public string reference_id { get; set; }
        public string description { get; set; }
        public amountModel amount { get; set; }
        public paymentMethodModel payment_method { get; set; }
        public recurringModel recurring { get; set; }
    }
    public class amountModel
    {
        public int value { get; set; }
        public string currency { get; set; }
    }
    public class paymentMethodModel
    {
        public string type { get; set; }
        public int installments { get; set; }
        public bool capture { get; set; }
        public cardModel card { get; set; }
    }
    public class cardModel
    {
        public string encrypted { get; set; }
        public string security_code { get; set; }
        public cardHolderModel holder { get; set; }
        public bool store { get; set; }
    }
    public class cardHolderModel
    {
        public string name { get; set; }
    }
    public class recurringModel
    {
        public string type { get; set; }
    }
}
