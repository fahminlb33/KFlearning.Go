using KFlearning.Go.Infrastructure;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace KFlearning.Go.ViewModels
{
    public class ShellNavbarViewModel : ViewModelBase
    {
        private object _selectedItem;

        public ICommand ListViewItemSelectedCommand { get; set; }

        public ObservableCollection<ShellMenuItemViewModel> MenuItems { get; set; }

        public object SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        public ShellNavbarViewModel()
        {
            PopulateItems();


        }

        private void PopulateItems()
        {
            MenuItems = new ObservableCollection<ShellMenuItemViewModel>(new[]
            {
                new ShellMenuItemViewModel { Id = 0, Title = "Profil" },
                new ShellMenuItemViewModel { Id = 1, Title = "Beranda" },
                new ShellMenuItemViewModel { Id = 2, Title = "Tutorial" },
                new ShellMenuItemViewModel { Id = 3, Title = "Blog" },
                new ShellMenuItemViewModel { Id = 4, Title = "About" },
                new ShellMenuItemViewModel { Id = 5, Title = "Logout" },
            });
        }

        private void ListView_ItemSelected(ShellMenuItemViewModel model)
        {
            if (model == null) return;

            //var page = (Page)Activator.CreateInstance(item.TargetType);
            //page.Title = model.Title;

            //var master = App.Current.MainPage as MasterDetailPage;
            //master.Detail = new NavigationPage(page);
            //master.IsPresented = false;

            SelectedItem = null;
        }

    }
}