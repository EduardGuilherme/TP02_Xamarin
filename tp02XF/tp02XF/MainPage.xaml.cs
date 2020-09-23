using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tp02XF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnEstiloPadrão(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_EstiloPadrão());
        }

        async void btnEstiloDinamico(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_EstiloDinamico());
        }
    }
}
