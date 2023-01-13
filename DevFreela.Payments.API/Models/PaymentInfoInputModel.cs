using System;
namespace DevFreela.Payments.API.Models
{
    public class PaymentInfoInputModel
    {
        public int ProjectId { get; set; }
        public string CreditCardNumber { get; set; }
        public string CVV { get; set; }
        public string ExpiresAt { get; set; }
        public string OwnerCreditCardName { get; set; }
        public decimal Amount { get; set; }
    }
}

