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
	public partial class Capitales : ContentPage
	{
		public Capitales ()
		{
			InitializeComponent ();
		}
        private async void OnParisFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Paris());
        }

        private async void OnLondresFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Londres());
        }

        private async void OnTokioFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tokio());
        }

        private async void OnNuevaYorkFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NuevaYork());
        }

        private async void OnSydneyFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sydney());
        }

        private async void OnBuenosAiresFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuenosAires());
        }
    }
}