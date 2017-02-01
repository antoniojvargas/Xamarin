using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginTestCS
{
    public class LoginPageCS : ContentPage
    {
        Entry usernameEntry, passwordEntry;
        Label messageLabel;

        public LoginPageCS()
        {
            var toolbarItem = new ToolbarItem
            {
                Text = "Registro"
            };
            toolbarItem.Clicked += OnSignUpButtonClicked;
            ToolbarItems.Add(toolbarItem);

            messageLabel = new Label();
            usernameEntry = new Entry
            {
                Placeholder = "Usuario"
            };
            passwordEntry = new Entry
            {
                Placeholder = "Clave",
                IsPassword = true
            };
            var loginButton = new Button
            {
                Text = "Ingresar"
            };
            loginButton.Clicked += OnLoginButtonClicked;

            Title = "Ingreso de Usuario";
            Content = new StackLayout
            {
                Spacing = 5,
                Padding = new Thickness(0, 20, 0, 0),                
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children = {                    
                    usernameEntry,                    
                    passwordEntry,
                    loginButton,
                    messageLabel
                }
            };
        }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPageCS());
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPageCS(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Ingreso fallido";
                passwordEntry.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Username && user.Password == Constants.Password;
        }
    }
}
