using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPortable
{
    public class MyContentPage : ContentPage
    {
        public MyContentPage()
        {
            var label = new Label
            {
                Text = "Escribe tu nombre"
            };
            var txtNombre = new Entry
            {
                Placeholder = "Escribe tu nombre"
            };
            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { label, txtNombre}
            };
        }
    }
}
