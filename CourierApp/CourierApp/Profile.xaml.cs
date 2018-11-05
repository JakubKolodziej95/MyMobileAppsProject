using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourierApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Profile : ContentPage
	{
		public Profile ()
		{
			InitializeComponent ();
		}

        // CHANGE PASSWORD BUTTON
        private void btnChangePass_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ModalChangePass());
        }

        // LOG OUT BUTTON
        private void btnLogOut_Clicked(object sender, EventArgs e)
        {
            //restores log-in/main page as root page then pops to it
            Application.Current.MainPage = new NavigationPage(new MainPage());
            Navigation.PopToRootAsync();
        }
    }
}