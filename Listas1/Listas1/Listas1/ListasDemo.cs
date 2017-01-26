using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Listas1
{
    public class ListasDemo : ContentPage
    {
        public ListasDemo()
        {
            var nombres = new[]
            {
                "Hector",
                "Cristina",
                "Regina",
                "Juan",
                "Ronaldo",
                "Humberto",
                "Hopkins",
                "Cristiano",
                "Cesar"
            };

            var miListView = new ListView();
            miListView.ItemsSource = from nombre in nombres
                                     where nombre.StartsWith("H")
                                     select nombre;

            miListView.ItemSelected += (sender, e) =>
            {
                if(e.SelectedItem != null)
                {
                    Debug.WriteLine("Selected " + e.SelectedItem);
                    miListView.SelectedItem = null;
                }
            };
            Content = miListView;
        }
    }
}
