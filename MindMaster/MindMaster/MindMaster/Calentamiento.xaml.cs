using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MindMaster
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calentamiento : ContentPage
    {
        public Calentamiento()
        {
            InitializeComponent();
        }

        private async void RotacionesdeCuello_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new RotacionesdeCuello());
        }

        private async void CírculosdeBrazos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CírculosdeBrazos());
        }

        private async void RotacionesdeCadera_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RotacionesdeCadera());
        }

        private async void TroteLigero_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TroteLigero());
        }
    }
}