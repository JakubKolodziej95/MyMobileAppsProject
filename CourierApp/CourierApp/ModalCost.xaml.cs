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
    public partial class ModalCost : ContentPage
    {
        public ModalCost()
        {
            InitializeComponent();
        }

        private void btnConfirmSign_Clicked(object sender, EventArgs e)
        {
            //some extra code
            Navigation.PopModalAsync();
        }

        private void btnCancelSign_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}