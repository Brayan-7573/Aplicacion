using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MindMaster
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Paises : ContentPage
	{
		public Paises ()
		{
			InitializeComponent ();
		}
        private async void OnMexicoFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mexico());
        }

        private async void OnRusiaFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Rusia());
        }

        private async void OnUSAFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new USA());
        }

        private async void OnChinaFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new China());
        }

        private async void OnSKoreaFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SKorea());
        }

        private async void OnNKoreaFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NKorea());
        }
    }
}