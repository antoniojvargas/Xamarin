using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyDialer
{
    class MyContentPage : ContentPage
    {
        public MyContentPage()
        {
            //var scroll = new ScrollView();
            //Content = scroll;
            //var stack = new StackLayout();
            //stack.Children.Add(new BoxView { BackgroundColor = Color.Red, HeightRequest = 600, WidthRequest = 600 });
            //stack.Children.Add(new Entry());
            var label = new Label
            {
                Text = "Escribe tu nombre"
            };
            var txtNombre = new Entry
            {
                Placeholder = "Escribe tu nombre"
            };
            var btnPrimerBoton = new Button
            {
                Text = "Click me!"
            };
            btnPrimerBoton.Clicked += (sender, e) =>
            {
                DisplayAlert("Mensaje", txtNombre.Text, "OK");
            };
            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { label, txtNombre, btnPrimerBoton }
            };
        }
    }
}
