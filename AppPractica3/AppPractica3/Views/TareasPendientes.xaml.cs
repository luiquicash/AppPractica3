using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPractica3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TareasPendientes : ContentPage
    {
        public class Tareas{
            public int id { get; set; }
            public string titulo { get; set; }
            public string descripcion { get; set; }
            public string fecha { get; set; }
            public int diasrestantes { get; set; }
            public bool completada { get; set; }
        };

        public TareasPendientes()
        {
            InitializeComponent();

            List<Tareas> listatareas = new List<Tareas>();
            listatareas.Add(new Tareas
            {
                id = 1,
                titulo = "Terminar Sistema Prestamos",
                diasrestantes = 60,
                descripcion = "Faltan los puntos visuales y afinar el pago de las cuotas",
                fecha = "8/9/2020",
                completada = false
            });

            listatareas.Add(new Tareas
            {
                id = 2,
                titulo = "Ir al taller",
                diasrestantes = 5,
                descripcion = "Revisar Precio de la parrilla delantera",
                fecha = "8/10/2020",
                completada = true
            });

            listatareas.Add(new Tareas
            {
                id = 3,
                titulo = "Comprar disco externo",
                diasrestantes = 15,
                descripcion = "para liberar espacio en disco de mi pc",
                fecha = "8/15/2020",
                completada = false
            });

            listatareas.Add(new Tareas
            {
                id = 4,
                titulo = "Ir a la veterinaria",
                diasrestantes = 3,
                descripcion = "Chequeo mensual de mi perro",
                fecha = "8/20/2020",
                completada = false
            });

            listatareas.Add(new Tareas
            {
                id = 5,
                titulo = "Practica de Basquet",
                diasrestantes = 20,
                descripcion = "ir a la cancha para practicar movimientos de bola",
                fecha = "8/22/2020",
                completada = false
            });

            tareasPendientes.ItemsSource = listatareas;
        }

        async void tareasPendientes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var tareaSeleccionada = e.SelectedItem as Tareas;
            if (tareaSeleccionada == null)
            {
                return;
            }

            await Navigation.PushAsync(new DetallesTareaPage(tareaSeleccionada));
        }
    }
}