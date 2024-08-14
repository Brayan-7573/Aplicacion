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
	public partial class Geografía : ContentPage
	{
		public Geografía ()
		{
			InitializeComponent ();
		}

        private async void Continentes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Continentes());
        }

        private async void Paises_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Paises());
        }

        private async void Capitales_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Capitales());
        }

        private async void Rios_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Rios());
        }

        private async void Montanas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Montanas());
        }

        private async void Climas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Clima());
        }
    }
}