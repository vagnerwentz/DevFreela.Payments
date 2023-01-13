using System;
using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Services
{
    public interface IPaymentService
    {
        Task<bool> ProcessPayment(PaymentInfoInputModel paymentInfoInputModel);
    }
}

