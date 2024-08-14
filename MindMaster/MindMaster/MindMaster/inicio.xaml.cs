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
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void btnArtes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Artes());
        }

        private async void btnCiencias_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CienciasN());
        }

        private async void btnEducaciónFísica_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EducaciónFísica());
        }

        private async void btnGeografía_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Geografía());
        }

        private async void btnHistoria_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Historia());
        }

        private async void btnEducaciónSe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Educacion_Socioemocional());
        }
    }
}