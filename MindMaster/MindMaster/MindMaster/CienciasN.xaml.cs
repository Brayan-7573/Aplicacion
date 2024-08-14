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
	public partial class CienciasN : ContentPage
	{
		public CienciasN ()
		{
			InitializeComponent ();
		}

        private async void Biología_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Biología());
        }

        private async void Química_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Química());
        }

        private async void Física_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Física());
        }

        private async void Astronomía_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Astronomía());
        }

        private async void Geología_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Geología());
        }
    }
}