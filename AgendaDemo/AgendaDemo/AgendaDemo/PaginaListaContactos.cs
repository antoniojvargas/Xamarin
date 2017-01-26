using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaDemo
{
    public class PaginaListaContactos : MasterDetailPage
    {
        public PaginaListaContactos()
        {
            var lista = new ListView();
            lista.ItemsSource = 
                GeneradorDeContactos.
                CrearContacto().
                OrderBy(x => x.Nombre);

            Master = new ContentPage
            {
                Title = "Contactos",
                Content = lista
            };
            Detail = new PaginaContacto(GeneradorDeContactos.CrearContacto().First());

        }
    }
}
