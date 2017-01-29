using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ScrollTest
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //var content = new ContentPage
            //{
            //    Title = "ScrollTest",
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Start,
            //        Padding = 30,
            //        Spacing = 10,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Escribe tu nombre"
            //            },
            //            new Entry {
            //                Placeholder = "Escribe tu nombre"
            //            },
            //            new Button {
            //                Text = "Click me!!!"
            //            }
            //        }
            //    }
            //};

            MainPage = new MyContentPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
