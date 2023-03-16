using AppBuscaCep.Model;
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
        }

        private void pck_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pck_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}