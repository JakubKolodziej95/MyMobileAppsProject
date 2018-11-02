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
	public partial class Index : ContentPage
	{
		public Index ()
		{
			InitializeComponent ();
		}

        // NEW PARCEL FORM BUTTON
        private void btnNewParcel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewParcel());
        }

        // HISTORY BUTTON
        private void btnHistory_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new History());
        }

        // CALENDAR BUTTON
        private void btnCalendar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calendar());
        }

        // PROFILE BUTTON
        private void btnProfile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile());
        }

        // !!!!!!!!!!!! DELETE !!!!!!!!!!!!! 
        private void tempObject_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderDetails());
        }
    }
}