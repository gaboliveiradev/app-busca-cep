using AppBuscaCep.Model;
using AppBuscaCep.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuscaCep.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuscaCepPorLogradouro : ContentPage
    {
        public BuscaCepPorLogradouro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                loader.IsRunning = true;
                List<Cep> arr_ceps = await DataService.GetCepByLogradouro(txt_logradouro.Text);
                lst_ceps.ItemsSource = arr_ceps;
            } catch (Exception err) 
            {
                await DisplayAlert("Erro", err.Message, "OK");
            } finally
            {
                loader.IsRunning = false;
            }
        }
    }
}