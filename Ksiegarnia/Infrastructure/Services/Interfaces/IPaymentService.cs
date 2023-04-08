﻿using Domain.DTOs;

namespace Infrastructure.Services.Interfaces
{
    public interface IPaymentService
    {
        /// <summary>
        ///     get payment link
        /// </summary>
        /// <param name="cancelUri">uri to cancel</param>
        /// <param name="redirectUri">uri to redirect</param>
        /// <param name="transaction">transaction</param>
        /// <param name="commission">commission</param>
        /// <returns></returns>
        string GetUri(string cancelUri, string redirectUri, TransactionDto transaction, decimal commission);
    }
}
