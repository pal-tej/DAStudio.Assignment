using DAStudio.Assignment.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAStudio.Assignment.Services
{
    public interface ITransactionDataStore
    {
        Task<TransactionDetail> GetTransactionDetailAsync(string id);

        Task<IEnumerable<Transaction>> GetTransactionsAsync(bool forceRefresh = false);
    }
}
