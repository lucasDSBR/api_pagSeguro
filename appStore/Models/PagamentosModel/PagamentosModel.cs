using api.Models.PagamentoPagSegModel;
using System.ComponentModel.DataAnnotations;

namespace api.Models.PagamentosModel
{
    public class PagamentosModel
    {
        [Key]
        public int IdPagamento { get; set; }
        public string id { get; set; }
        public string reference_id { get; set; }
        public DateTime created_at { get; set; }
        public CustomerModel customer { get; set; }
        public IEnumerable<ItemsModel> items { get; set; }
        public ShippingModel shipping { get; set; }
        public IEnumerable<QrCodesModel> qr_codes { get; set; }
        public IEnumerable<ChargesModel> charges { get; set; }
        public string[] notification_urls { get; set; }
        public IEnumerable<linksModel> links { get; set; }
    }
    public class CustomerModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string tax_id { get; set; }
        public IEnumerable<PhonesModel> phones { get; set; }
    }
    public class PhonesModel
    {
        public string type { get; set; }
        public string country { get; set; }
        public string area { get; set; }
        public string number { get; set; }
    }
    public class ItemsModel
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public int unit_amount { get; set; }
    }
    public class ShippingModel
    {
        public AddressModel address { get; set; }
    }
    public class AddressModel
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
    public class QrCodesModel
    {
        public string id { get; set; }
        public DateTime expiration_date { get; set; }
        public AmountModel amount { get; set; }
        public string text { get; set; }
        public string[] arrangements { get; set; }
        public IEnumerable<LinksModel> links { get; set; }


    }
    public class AmountModel
    {
        public int value { get; set; }
    }
    public class LinksModel
    {
        public string rel { get; set; }
        public string href { get; set; }
        public string media { get; set; }
        public string type { get; set; }
    }
    public class ChargesModel
    {
        public string id { get; set; }
        public string reference_id { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime paid_at { get; set; }
        public string description { get; set; }
        public ChargesAmountModel amount { get; set; }
        public PaymentResponseModel payment_response { get; set; }
        public PaymentMethodModel payment_method { get; set; }
        public MetadataModel metadata { get; set; }
        public IEnumerable<linksModel> links { get; set; }
    }
    public class ChargesAmountModel
    {
        public int value { get; set; }
        public string currency { get; set; }
        public ChargesAmountSummaryModel summary { get; set; }

    }
    public class ChargesAmountSummaryModel
    {
        public int total { get; set; }
        public int paid { get; set; }
        public int refunded { get; set; }
    }
    public class PaymentResponseModel
    {
        public string code { get; set; }
        public string message { get; set; }
        public string reference { get; set; }

    }
    public class PaymentMethodModel
    {
        public string type { get; set; }
        public int installments { get; set; }
        public bool capture { get; set; }
        public PaymentMethodCardModel card { get; set; }
        public string soft_descriptor { get; set; }
    }
    public class PaymentMethodCardModel
    {
        public string brand { get; set; }
        public string first_digits { get; set; }
        public string last_digits { get; set; }
        public string exp_month { get; set; }
        public string exp_year { get; set; }
        public PaymentMethodCardHolderModel holder { get; set; }
        public bool store { get; set; }
    }
    public class PaymentMethodCardHolderModel
    {
        public string name { get; set; }
    }
    public class MetadataModel
    {
        public string Key { get; set; }
    }
    public class linksModel
    {
        public string rel { get; set; }
        public string href { get; set; }
        public string media { get; set; }
        public string type { get; set; }
    }

}
