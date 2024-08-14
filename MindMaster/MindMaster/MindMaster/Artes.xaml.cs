using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MindMaster
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Artes : ContentPage
    {
        public Artes()
        {
            InitializeComponent();
        }

        private async void Pintura_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pintura());
        }

        private async void Escultura_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Escultura());
        }

        private async void Arquitectura_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Arquitectura());
        }

        private async void Danza_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Danza());
        }

        private async void Poesia_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poesia());
        }

        private async void Literatura_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Literatura());
        }

        private async void Teatro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teatro());
        }

        private async void Cine_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cine());
        }
    }
}