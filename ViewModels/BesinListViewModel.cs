using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Ornek_2.View;
using Ornek_2.ViewModels.Base;
using Xamarin.Forms;

namespace Ornek_2.ViewModels
{
    public class BesinListViewModel : BaseVM
    {
        private INavigation navigation;

        private ObservableCollection<BesinViewModel> items;
        public ObservableCollection<BesinViewModel> Items
        {
            get { return items; }
            set
            {
                if (items != value)
                {
                    items = value;
                    OnPropertyChanged();
                }
            }
        }

        private BesinViewModel _selectedItem;
        public BesinViewModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand InsertCommand { get; set; }

        public BesinListViewModel(INavigation navigation)
        {
            this.navigation = navigation;

            InsertCommand = new Command(OnInsert);

            OnRefresh();

            MessagingCenter.Subscribe<BesinPage>(this, "Tamam", (sender) =>
            {
                BesinViewModel besin = (sender as BesinPage).BindingContext as BesinViewModel;
                if(besin.Id == 0)
                {
                    if(App.Database.EkleGuncelle(besin.Model) > 0)
                    {
                        Items.Add(besin);
                    }
                }
                else
                {
                    if (App.Database.EkleGuncelle(besin.Model) > 0)
                    {
                        int index = Items.IndexOf(Items.FirstOrDefault(x => x.Id == besin.Id));
                        Items[index] = besin;
                    }
                }
            });
        }

        private void OnInsert(object obj)
        {
            navigation.PushAsync(new BesinPage() { BindingContext = new BesinViewModel() });
        }

        private void OnRefresh()
        {
            items = new ObservableCollection<BesinViewModel>();
            foreach (var model in App.Database.Listele())
            {
                items.Add(new BesinViewModel(model));
            }
        }

        public void Sil(BesinViewModel vm)
        {
            if(App.Database.Sil(vm.Id) > 0)
            {
                //silindi
                Items.Remove(vm);

                //int index = Items.IndexOf(items.FirstOrDefault(x => x.Id == vm.Id));
                //Items.RemoveAt(index);
            }
        }

        public void Guncelle(BesinViewModel vm)
        {
            navigation.PushAsync(new BesinPage() { BindingContext = vm.Copy() });
        }
    }
}
