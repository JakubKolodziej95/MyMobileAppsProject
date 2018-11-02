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

        }

        // LOG OUT BUTTON
        private void btnLogOut_Clicked(object sender, EventArgs e)
        {
            // log out should bring user back to log-in page and clear stack,
            // not push a new instance of main page on top of the stack.
            Navigation.PushAsync(new MainPage());
        }
    }
}