using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ornek_2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ornek_2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BesinListPage : ContentPage
	{
        private object silItem;

        

        public BesinListPage ()
		{
			InitializeComponent ();

          
            //BindingContext = viewModel;
            BindingContext = new BesinListViewModel(Navigation);
		}

        private async void MenuSil_Clicked(object sender, EventArgs e)
        {
            MenuItem silItem = sender as MenuItem;
            BesinViewModel vm = silItem.CommandParameter as BesinViewModel;

            bool cevap = await DisplayAlert("Besin Sil", vm.Ad + " silmek istiyor musunuz?", "Evet", "Hayır");
            if(cevap)
            {
                //viewModel.Sil(vm);
                (BindingContext as BesinListViewModel).Sil(vm);
            }

        }

        private void MenuGuncelle_Clicked(object sender, EventArgs e)
        {
            MenuItem guncelleItem = sender as MenuItem;
            BesinViewModel vm = guncelleItem.CommandParameter as BesinViewModel;

            (BindingContext as BesinListViewModel).Guncelle(vm);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
          
        }
    }
}