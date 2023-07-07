namespace api.Models.AssinaturaModel.AssinaturaSubModel
{
    public class AssinaturaSubModel
    {
        public string reference_id { get; set; }
        public customerSubModel customer { get; set; }
        public IEnumerable<itemsSubModel> itens { get; set; }
        public shippingSubModel shipping { get; set; }
        public string[] notification_urls { get; set; }
        public IEnumerable<chargesSubModel> charges { get; set; }
    }
    public class customerSubModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string tax_id { get; set; }
        public IEnumerable<phonesCustomerSubModel> phone { get; set; }

    }
    public class phonesCustomerSubModel
    {
        public string country { get; set; }
        public string area { get; set; }
        public string number { get; set; }
        public string type { get; set; }
    }
    public class itemsSubModel
    {
        public string reference_id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public int unit_amount { get; set; }
    }
    public class shippingSubModel
    {
        public addressShippingSubModel address { get; set; }
    }
    public class addressShippingSubModel
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
    public class chargesSubModel
    {
        public string reference_id { get; set; }
        public string description { get; set; }
        public amountSubModel amount { get; set; }
        public paymentMethodSubModel payment_method { get; set; }
        public recurringSubModel recurring { get; set; }
    }
    public class amountSubModel
    {
        public int value { get; set; }
        public string currency { get; set; }
    }
    public class paymentMethodSubModel
    {
        public string type { get; set; }
        public int installments { get; set; }
        public bool capture { get; set; }
        public cardSubModel card { get; set; }
    }
    public class cardSubModel
    {
        public string id { get; set; }
        public cardHolderSubModel holder { get; set; }
        public bool store { get; set; }
    }
    public class cardHolderSubModel
    {
        public string name { get; set; }
    }
    public class recurringSubModel
    {
        public string type { get; set; }
    }
}
