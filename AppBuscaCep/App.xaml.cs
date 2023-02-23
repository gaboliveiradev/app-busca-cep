using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppBuscaCep.View.modules;
using AppBuscaCep.View.modules.BairrosPorCidade;

namespace AppBuscaCep
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BairrosPorCidade();
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
