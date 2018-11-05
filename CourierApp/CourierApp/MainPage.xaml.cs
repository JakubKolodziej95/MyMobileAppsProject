using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CourierApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // LOG IN BUTTON
        private void logInButton_Clicked(object sender, EventArgs e)
        {
            bool isUserEmpty, isPassEmpty;
            isUserEmpty = String.IsNullOrEmpty(logInUser.Text);
            isPassEmpty = String.IsNullOrEmpty(logInPass.Text);

            if(isUserEmpty || isPassEmpty)
            {
                DisplayAlert("Error", "Username or Password are incorrect", "OK");
            }
            else
            {
                //pushes to index and sets it as root page
                Navigation.PushAsync(new Index());
                Application.Current.MainPage = new NavigationPage(new Index());
            }
        }
        
        // REGISTRATION BUTTON
        private void registerButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }
    }
}
