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
    public partial class EducaciónFísica : ContentPage
    {
        public EducaciónFísica()
        {
            InitializeComponent();
        }

        private async void btnCalentar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calentamiento());
        }

        private async void EjerciciosDeFuerza_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EjerciciosdeFuerza());
        }

        private async void btnDeportesyJuegos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeportesyJuegos());
        }

        private async void btnSaludNutricion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaludyNutrición());
        }

        private async void btnHistoriaDeporte_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HistoriaDeporte());
        }
    }
}