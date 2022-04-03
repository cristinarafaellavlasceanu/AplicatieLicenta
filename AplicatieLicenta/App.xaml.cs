using AplicatieLicenta.Services;
using AplicatieLicenta.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplicatieLicenta
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new Login());
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
