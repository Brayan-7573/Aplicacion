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
	public partial class Continentes : ContentPage
	{
		public Continentes ()
		{
			InitializeComponent ();
		}
        private async void OnAmazonasFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Amazonas());
        }

        private async void OnNiloFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RioNilo());
        }

        private async void OnYangtzeFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Yangtze());
        }

        private async void OnMisisipiFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Misisipi());
        }

        private async void OnGangesFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ganges());
        }
    }
}