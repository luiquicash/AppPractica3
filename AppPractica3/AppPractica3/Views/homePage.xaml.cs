using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPractica3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class homePage : ContentPage
    {
        public homePage()
        {
            InitializeComponent();
        }

        private async void InformacionPersonalPage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InformacionPersonal());
        }

        private async void TareasPendientesPage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TareasPendientes());
        }
    }
}