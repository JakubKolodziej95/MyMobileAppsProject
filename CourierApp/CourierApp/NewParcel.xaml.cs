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
	public partial class NewParcel : ContentPage
	{
		public NewParcel ()
		{
			InitializeComponent ();
		}

        // ADD NEW ORDER BUTTON
        private void btnAddOrder_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        // CANCEL ADDING AN ORDER BUTTON
        private void btnCancelOrder_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}