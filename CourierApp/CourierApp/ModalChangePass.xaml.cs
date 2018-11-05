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
	public partial class ModalChangePass : ContentPage
	{
		public ModalChangePass ()
		{
			InitializeComponent ();
		}

        private void btnChangePassConfirm_Clicked(object sender, EventArgs e)
        {
            //some more code //validation
            Navigation.PopModalAsync();
        }

        private void btnChangePassCancel_Clicked(object sender, EventArgs e)
        {

        }
    }
}