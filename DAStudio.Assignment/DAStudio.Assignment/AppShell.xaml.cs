using DAStudio.Assignment.ViewModels;
using DAStudio.Assignment.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DAStudio.Assignment
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TransactionDetailPage), typeof(TransactionDetailPage));
        }

    }
}
