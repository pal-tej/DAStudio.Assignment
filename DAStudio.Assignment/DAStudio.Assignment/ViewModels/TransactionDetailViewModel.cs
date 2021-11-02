using DAStudio.Assignment.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DAStudio.Assignment.ViewModels
{
    [QueryProperty(nameof(TransactionId), nameof(TransactionId))]
    public class TransactionDetailViewModel : BaseViewModel
    {
        private string transactionId;
        private string name;
        private string bankName;
        private int paidAmount;
        private string referenceNumber;
        private string cfNumber;
        public string Id { get; set; }
        public DateTime createdAtDateTime;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public DateTime CreatedAtDateTime
        {
            get => createdAtDateTime;
            set => SetProperty(ref createdAtDateTime, value);
        }

        public string ReferenceNumber
        {
            get => referenceNumber;
            set => SetProperty(ref referenceNumber, value);
        }

        public string CfNumber
        {
            get => cfNumber;
            set => SetProperty(ref cfNumber, value);
        }

        public string BankName
        {
            get => bankName;
            set => SetProperty(ref bankName, value);
        }

        public int PaidAmount
        {
            get => paidAmount;
            set => SetProperty(ref paidAmount, value);
        }


        public string TransactionId
        {
            get
            {
                return transactionId;
            }
            set
            {
                transactionId = value;
                LoadTransactionId(value);
            }
        }

        public async void LoadTransactionId(string transactionId)
        {
            try
            {
                var transaction = await DataStore.GetTransactionDetailAsync(transactionId);
                Id = transaction.Id;
                Name = transaction.Name;
                BankName = transaction.BankName;
                PaidAmount = transaction.PaidAmount;
                ReferenceNumber = transaction.ReferenceNumber;
                CfNumber = transaction.CfNumber;

                var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                CreatedAtDateTime = epoch.Add(TimeSpan.FromSeconds(transaction.CreatedAt)).ToLocalTime();


            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Transaction");
            }
        }
    }
}
