using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginTestCS
{
    public class MainPageCS : ContentPage
    {
        public MainPageCS()
        {
            var toolbarItem = new ToolbarItem
            {
                Text = "Salir"
            };
            toolbarItem.Clicked += OnLogoutButtonClicked;
            ToolbarItems.Add(toolbarItem);

            Title = "Pagina Principal";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Aqui va el App",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginPageCS(), this);
            await Navigation.PopAsync();
        }
    }
}
