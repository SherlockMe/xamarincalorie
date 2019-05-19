using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ornek_2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BesinPage : ContentPage
	{
		public BesinPage ()
		{
			InitializeComponent ();
		}

        private void BtnIptal_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void BtnTamam_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<BesinPage>(this, "Tamam");
            Navigation.PopAsync();
        }
    }
}