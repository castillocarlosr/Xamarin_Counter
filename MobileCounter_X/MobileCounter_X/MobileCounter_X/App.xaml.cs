using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileCounter_X.Services;
using MobileCounter_X.Views;

namespace MobileCounter_X
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
