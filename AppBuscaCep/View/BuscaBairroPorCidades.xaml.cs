using AppBuscaCep.Model;
using AppBuscaCep.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuscaCep.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuscaBairroPorCidades : ContentPage
    {
        ObservableCollection<Cidade> lista_cidade = new ObservableCollection<Cidade>();
        ObservableCollection<Bairro> lista_bairro = new ObservableCollection<Bairro>();

        public BuscaBairroPorCidades()
        {
            InitializeComponent();

            pck_cidade.ItemsSource = lista_cidade;
            lst_bairros.ItemsSource = lista_bairro;
        }

        private async void pck_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Picker disparador = sender as Picker;

                Cidade cidade_selecionada = disparador.SelectedItem as Cidade;

                List<Bairro> arr_bairros = await DataService.GetBairrosByIdCidade(cidade_selecionada.id_cidade);
                
                lista_bairro.Clear();

                arr_bairros.ForEach(item => lista_bairro.Add(item));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void pck_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Picker disparador = sender as Picker;

                string estado_selecionado = disparador.SelectedItem as string;
                List<Cidade> arr_cidades = await DataService.GetCidadeByEstado(estado_selecionado);

                lista_cidade.Clear();

                arr_cidades.ForEach(i => lista_cidade.Add(i));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}