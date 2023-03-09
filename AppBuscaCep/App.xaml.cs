using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppBuscaCep.View.modules.Menu;

namespace AppBuscaCep
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.modules.Menu.Menu());
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
