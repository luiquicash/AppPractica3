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
    public partial class InformacionPersonal : ContentPage
    {
        public InformacionPersonal()
        {
            InitializeComponent();
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
                if (txtNombre.Text == null)
                {
                    DisplayAlert("Error", "Debe Introducir el Nombre para Continuar", "Ok");
                }
                else if (txtCedula.Text == null)
                {
                    DisplayAlert("Error", "Debe Introducir la Cedula para Continuar", "Ok");
                }
                else if (txtTelefono.Text == null)
                {
                    DisplayAlert("Error", "Debe Introducir el Telefono para Continuar", "Ok");
                }
                else if (txtCorreo.Text == null)
                {
                    DisplayAlert("Error", "Debe Introducir el Correo para Continuar", "Ok");
                }
                else if (txtDireccion.Text == null)
                {
                    DisplayAlert("Error", "Debe Introducir la Direccion para Continuar", "Ok");
                }
                else
                {
                    DisplayAlert("Informacion Guardada", "Nombre: "+txtNombre.Text+"\n Cedula: "+txtCedula.Text+ "\n Telefono: "+txtTelefono.Text+
                        "\n Correo: "+txtCorreo.Text+ "\n Direccion: "+txtDireccion.Text, "Continuar");
                }
        }
    }
}