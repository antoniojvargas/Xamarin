using System;
using System.Linq;
using Xamarin.Forms;

namespace LoginTestCS
{
    public class SignUpPageCS : ContentPage
    {
        Entry usernameEntry, passwordEntry, emailEntry;
        Label messageLabel;

        public SignUpPageCS()
        {
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
            emailEntry = new Entry()
            {
                Placeholder = "Correo"
            };
            var signUpButton = new Button
            {
                Text = "Registro"
            };
            signUpButton.Clicked += OnSignUpButtonClicked;

            Title = "Registro de Usuario";
            Content = new StackLayout
            {
                Spacing = 5,
                Padding = new Thickness(0, 20, 0, 0),
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children = {
                    usernameEntry,
                    passwordEntry,
                    emailEntry,
                    signUpButton,
                    messageLabel
                }
            };
        }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            var user = new User()
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text,
                Email = emailEntry.Text
            };

            // Sign up logic goes here

            var signUpSucceeded = AreDetailsValid(user);
            if (signUpSucceeded)
            {
                var rootPage = Navigation.NavigationStack.FirstOrDefault();
                if (rootPage != null)
                {
                    App.IsUserLoggedIn = true;
                    Navigation.InsertPageBefore(new MainPageCS(), Navigation.NavigationStack.First());
                    await Navigation.PopToRootAsync();
                }
            }
            else
            {
                messageLabel.Text = "Registro fallido";
            }
        }

        bool AreDetailsValid(User user)
        {
            return (!string.IsNullOrWhiteSpace(user.Username) && !string.IsNullOrWhiteSpace(user.Password) && !string.IsNullOrWhiteSpace(user.Email) && user.Email.Contains("@"));
        }
    }
}
