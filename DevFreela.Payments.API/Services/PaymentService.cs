﻿using System;
using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Services;

public class PaymentService : IPaymentService
{
    public Task<bool> ProcessPayment(PaymentInfoInputModel paymentInfoInputModel)
    {
        return Task.FromResult(true);
    }
}


