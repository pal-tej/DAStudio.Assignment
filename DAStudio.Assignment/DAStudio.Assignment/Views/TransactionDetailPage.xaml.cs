using DAStudio.Assignment.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DAStudio.Assignment.Views
{
    public partial class TransactionDetailPage : ContentPage
    {
        public TransactionDetailPage()
        {
            InitializeComponent();
            BindingContext = new TransactionDetailViewModel();
        }
    }
}