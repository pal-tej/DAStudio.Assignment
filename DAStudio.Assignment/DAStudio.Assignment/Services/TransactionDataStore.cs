using DAStudio.Assignment.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DAStudio.Assignment.Services
{
    public class TransactionDataStore : ITransactionDataStore
    {
        readonly string _baseUrl = "https://61769aed03178d00173dad89.mockapi.io/api/v1";

        readonly List<Transaction> _transactions = new List<Transaction>();

        public async Task<TransactionDetail> GetTransactionDetailAsync(string id)
        {
            TransactionDetail result = null;

            using (var client = new HttpClient())
            {
                result = JsonConvert.DeserializeObject<TransactionDetail>(await client.GetStringAsync($"{_baseUrl}/transactions/{id}"));
            }
            return result;
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsAsync(bool forceRefresh = false)
        {
            List<Transaction> result = new List<Transaction>();

            if (forceRefresh)
            {
                _transactions.Clear();
                using (var client = new HttpClient())
                {
                    Transaction[] transactions = JsonConvert.DeserializeObject<Transaction[]>(await client.GetStringAsync($"{_baseUrl}/transactions"));
                    _transactions.AddRange(transactions);
                }
            }

            return _transactions;
        }
    }
}
