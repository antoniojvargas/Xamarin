﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppPortable
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //var content = new MyContentPage();

            // MainPage = new NavigationPage(content);
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
