using DAStudio.Assignment.Models;
using DAStudio.Assignment.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DAStudio.Assignment.ViewModels
{
    public class TransactionsViewModel : BaseViewModel
    {
        private Transaction _selectedTransaction;

        public ObservableCollection<Transaction> Transactions { get; }
        public Command LoadTransactionsCommand { get; }
        public Command<Transaction> TransactionTapped { get; }

        public TransactionsViewModel()
        {
            Title = "Transaction History";
            Transactions = new ObservableCollection<Transaction>();
            LoadTransactionsCommand = new Command(async () => await ExecuteLoadTransactionsCommand());

            TransactionTapped = new Command<Transaction>(OnTransactionSelected);

        }

        async Task ExecuteLoadTransactionsCommand()
        {
            IsBusy = true;

            try
            {
                Transactions.Clear();
                var transactions = await DataStore.GetTransactionsAsync(true);
                foreach (var transaction in transactions)
                {
                    Transactions.Add(transaction);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedTransaction = null;
        }

        public Transaction SelectedTransaction
        {
            get => _selectedTransaction;
            set
            {
                SetProperty(ref _selectedTransaction, value);
                OnTransactionSelected(value);
            }
        }

        async void OnTransactionSelected(Transaction transaction)
        {
            if (transaction == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(TransactionDetailPage)}?{nameof(TransactionDetailViewModel.TransactionId)}={transaction.Id}");
        }
    }
}