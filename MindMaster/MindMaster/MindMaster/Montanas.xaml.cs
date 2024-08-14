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
	public partial class Montanas : ContentPage
	{
		public Montanas ()
		{
			InitializeComponent ();
		}

        private async void OnEverestFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Everest());
        }

        private async void OnK2FrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new K2());
        }

        private async void OnKangchenjungaFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kangchenjunga());
        }

        private async void OnMakaluFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Makalu());
        }

        private async void OnLhotseFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lhotse());
        }
    }
}