using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appStore.Models.PedidosModel
{
    public class PedidosComArrayModel
    {
        [Key]
        public int IdPedido { get; set; }
        public string id { get; set; }
        public string reference_id { get; set; }
        public DateTime created_at { get; set; }
        public PedidosComArrayCustomerModel customer { get; set; }
        public IEnumerable<PedidosComArrayItemsModel> items { get; set; }
        public PedidosComArrayShippingModel shipping { get; set; }
        public IEnumerable<PedidosComArrayQrCodesModel> qr_codes { get; set; }
        public string[] notification_urls { get; set; }
        public IEnumerable<PedidosComArrayLinksModel> links { get; set; }
        
    }
    public class PedidosComArrayCustomerModel
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string tax_id { get; set; }
        public IEnumerable<PedidosPhonesModel> phones { get; set; }
    }
    public class PedidosComArrayPhonesModel
    {
        [Key]
        public int Id { get; set; }
        public string type { get; set; }
        public string country { get; set; }
        public string area { get; set; }
        public string number { get; set; }
    }
    public class PedidosComArrayItemsModel
    {
        [Key]
        public int Id { get; set; }
        public string reference_id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public int unit_amount { get; set; }
    }
    public class PedidosComArrayShippingModel
    {
        [Key]
        public int Id { get; set; }
        public PedidosShippingAddressModel address { get; set; }
    }
    public class PedidosComArrayShippingAddressModel
    {
        [Key]
        public int Id { get; set; }
        public string street { get; set; }
        public string number { get; set; }
        public string complement { get; set; }
        public string locality { get; set; }
        public string city { get; set; }
        public string region_code { get; set; }
        public string country { get; set; }
        public string postal_code { get; set; }
    }
    public class PedidosComArrayQrCodesModel
    {
        [Key]
        public int IdQrCode { get; set; }
        public string id { get; set; }
        public DateTime expiration_date { get; set; }
        public PedidosQrCodesAmountModel amount { get; set; }
        public string text { get; set; }
        public string[] arrangements { get; set; }
        public IEnumerable<PedidosQrCodesLinksModel> links { get; set; }
    }
    public class PedidosComArrayQrCodesAmountModel
    {
        [Key]
        public int Id { get; set; }
        public string value { get; set; }
    }
    public class PedidosComArrayQrCodesArrangementsModel
    {
        [Key]
        public int Id { get; set; }
        public string[] arrangement { get; set; }
    }
    public class PedidosComArrayQrCodesLinksModel
    {
        [Key]
        public int Id { get; set; }
        public string rel { get; set; }
        public string href { get; set; }
        public string media { get; set; }
        public string type { get; set; }
    }
    public class PedidosComArrayNotificationUrlsModel
    {
        [Key]
        public int Id { get; set; }
        public string url { get; set; }
    }
    public class PedidosComArrayLinksModel
    {
        [Key]
        public int Id { get; set; }
        public string rel { get; set; }
        public string href { get; set; }
        public string media { get; set; }
        public string type { get; set; }
    }
}
