using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MindMaster
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void btninicio_Clicked(object sender, EventArgs e)
        {

            
            await Navigation.PushAsync(new inicio());
            await btninicio.ScaleTo(1.2, 100);
            await btninicio.ScaleTo(1, 100);

        }
    }
}
