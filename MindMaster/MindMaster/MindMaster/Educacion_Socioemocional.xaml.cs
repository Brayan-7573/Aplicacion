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
	public partial class Educacion_Socioemocional : ContentPage
	{
		public Educacion_Socioemocional ()
		{
			InitializeComponent ();
		}

        private async void OnEmpatiaTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Empatia());
        }

        private async void OnAutoestimaTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Autoestima());
        }

        private async void OnResolucionDeConflictosTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Resolucion_de_Conflictos());
        }

        private async void OnComunicacionEfectivaTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Comunicacion_Efectiva());
        }

        private async void OnRegulacionEmocionalTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Regulacion_Emocional());
        }

        private async void OnResponsabilidadSocialTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Responsabilidad_Social());
        }
    }
}