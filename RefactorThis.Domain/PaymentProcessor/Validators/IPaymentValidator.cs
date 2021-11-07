﻿using RefactorThis.Domain.Common.ValidationModel;
using RefactorThis.Persistence;

namespace RefactorThis.Domain.PaymentProcessor.Validators
{
    public interface IPaymentValidator
    {
        ValidationStatus Validate(Invoice invoice, Payment payment);
    }
}