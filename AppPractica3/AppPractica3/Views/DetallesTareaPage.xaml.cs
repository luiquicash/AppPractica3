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
    public partial class DetallesTareaPage : ContentPage
    {
        public DetallesTareaPage(TareasPendientes.Tareas TareaSeleccionada)
        {
            InitializeComponent();
            titulo.Text = TareaSeleccionada.titulo;
            descripcion.Text = TareaSeleccionada.descripcion;
            diasrestantes.Text = Convert.ToString(TareaSeleccionada.diasrestantes);
            fecha.Text = TareaSeleccionada.fecha;
            completada.IsChecked = TareaSeleccionada.completada;
        }
        public TareasPendientes.Tareas TareaSeleccionada { get; }
    }
}