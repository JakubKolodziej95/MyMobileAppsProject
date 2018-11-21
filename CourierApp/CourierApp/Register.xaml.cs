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
	public partial class Register : ContentPage
	{
		public Register ()
		{
			InitializeComponent ();
		}

        // COMPLETE REGISTRATION BUTTON
        private void registerDone_Clicked(object sender, EventArgs e)
        {
            string id;

            RandomID rndId = new RandomID();
            id = rndId.GenerateId();
            DisplayAlert("Welcome", "Your user ID is:\n\n" + id + "\n\nPlease remember it, you will require it to log in.", "Ok");

            ProfileInfo proInf = new ProfileInfo();

            Navigation.PopAsync();
        }
    }
}