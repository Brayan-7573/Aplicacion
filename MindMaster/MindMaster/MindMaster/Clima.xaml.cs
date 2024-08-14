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
	public partial class Clima : ContentPage
	{
		public Clima ()
		{
			InitializeComponent ();
		}

        private async void OnTropicalTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClimaTropical());
        }

        private async void OnAridTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClimaArido());
        }

        private async void OnTemperateTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClimaTempado());
        }

        private async void OnPolarTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClimaPolar());
        }
    }
}