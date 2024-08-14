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
	public partial class Rios : ContentPage
	{
		public Rios ()
		{
			InitializeComponent ();
		}
        private async void OnAsiaFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Asia());
        }

        private async void OnAfricaFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Africa());
        }

        private async void OnNorthAmericaFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Americadelnorte());
        }

        private async void OnSouthAmericaFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AmericadelSur());
        }

        private async void OnOceaniaFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Oceania());
        }

        private async void OnAntarcticaFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Antartida());
        }
    }
}