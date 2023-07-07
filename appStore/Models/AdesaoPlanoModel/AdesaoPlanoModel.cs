namespace api.Models.AdesaoPlanoModel
{
    public class AdesaoPlanoModel
    {
        public string Plan { get; set; }
        public string Reference { get; set; }
        public Sender Sender { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }

    public class Sender
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Hash { get; set; }
        public Phone Phone { get; set; }
        public Address Address { get; set; }
        public IEnumerable<Document> Documents { get; set; }
    }

    public class Phone
    {
        public string AreaCode { get; set; }
        public string Number { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }

    public class Document
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class PaymentMethod
    {
        public string Type { get; set; }
        public CreditCard CreditCard { get; set; }
    }

    public class CreditCard
    {
        public string Token { get; set; }
        public Holder Holder { get; set; }
    }

    public class Holder
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public IEnumerable<Document> Documents { get; set; }
        public Phone Phone { get; set; }
        public Address BillingAddress { get; set; }
    }

}
