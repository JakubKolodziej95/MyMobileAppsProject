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
	public partial class OrderDetails : ContentPage
	{
		public OrderDetails ()
		{
			InitializeComponent ();
		}

        // CALCULATE COST OF PARCEL BUTTON
        private void btnCalcCost_Clicked(object sender, EventArgs e)
        {
            CalcCost answerCost = new CalcCost();
            Navigation.PushModalAsync(new ModalCost());
        }

        // SEND INVOICE BUTTON
        private void btnInvoice_Clicked(object sender, EventArgs e)
        {
            string s = "Invoice successfully sent to <bound client email>.";
            DisplayAlert("Invoice Sent", s, "OK");
        }

        // SHOW ROUTE MAP BUTTON
        private void btnRouteMap_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Map());
        }

        // MARK AS DELIVERED BUTTON
        private void btnDelivered_Clicked(object sender, EventArgs e)
        {
            // move this object from list in index to list in history
            string s = "Order completed. Order has been moved to 'History'.";
            DisplayAlert("Delivered", s, "OK");
            Navigation.PopAsync();
        }
    }
}