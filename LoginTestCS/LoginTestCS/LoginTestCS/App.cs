using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LoginTestCS
{
    public class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }

        //public List<User> users = new List<User>();
        public static List<User> users { get; set; }

        public App()
        {
            users = new List<User>();

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPageCS());
            }
            else
            {
                MainPage = new NavigationPage(new MainPageCS());
            }
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
