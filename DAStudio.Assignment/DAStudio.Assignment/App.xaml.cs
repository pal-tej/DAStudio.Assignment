using DAStudio.Assignment.Services;
using DAStudio.Assignment.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DAStudio.Assignment
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<TransactionDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
