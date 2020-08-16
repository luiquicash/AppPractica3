using AppPractica3.Views;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPractica3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        [Required(ErrorMessage = "El Nombre de Usuario es Obligatorio")]
        [BindProperty]
        public string Username { get; set; }
        [Required(ErrorMessage = "La Contraseña es Obligatoria")]
        [BindProperty]
        public string Password { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private async void IniciarSesion_ClickedAsync(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Username = useName.Text;
            login.Password = usePass.Text;

            if (login.Username != null && login.Password != null)
            {
                if (login.Username.ToLower() == "admin@uteco.edu.do" && login.Password == "Password")
                {
                    if (usePass.Text.Length >= 2)
                    {
                        await Navigation.PushModalAsync(new MainPage());
                    }
                    else
                    {
                        await DisplayAlert("ERROR", "La Contraseña debe contener minimo de 8 digitos", "OK");
                    }
                }
                else
                {
                    await DisplayAlert("ERROR", "Usuario o Contraseña incorrecta favor revisar y volver a intentarlo", "OK");
                }
            }
            else
            {
                await DisplayAlert("ERROR", "Debe Introducir los valores solicitados para acceder", "OK");
            }
        }
    }
}