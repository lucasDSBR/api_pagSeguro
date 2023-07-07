namespace api.Models.AdesaoPlanoModel
{
    public class CartaoAdesaoPlanoModel
    {
        public string sessionId { get; set; }
        public string amount { get; set; }
        public string cardNumber { get; set; }
        public string cardBrand { get; set; }
        public string cardCvv { get; set; }
        public string cardExpirationMonth { get; set; }
        public string cardExpirationYear { get; set; }
    }
}
