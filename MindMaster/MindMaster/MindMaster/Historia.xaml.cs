using System;
using Xamarin.Forms;

namespace MindMaster
{
    public partial class Historia : ContentPage
    {
        public Historia()
        {
            InitializeComponent();
        }

        private async void OnPrimerHombreEnLaLunaTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hombre_en_la_luna());
        }

        private async void OnCaidaDelMuroDeBerlinTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Caida_muro_berlin());
        }

        private async void OnDescubrimientoDeAmericaTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DescubrimientoDeAmerica());
        }

        private async void OnRevolucionFrancesaTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RevolucionFrancesa());
        }

        private async void OnIndependenciaDeEstadosUnidosTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IndependenciaDeEstadosUnidos());
        }

        private async void OnRevolucionIndustrialTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RevolucionIndustrial());
        }
    }
}
