using KFlearning.Go.Infrastructure;
using KFlearning.Go.Models;
using KFlearning.Go.Services;
using KFlearning.Go.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace KFlearning.Go.ViewModels
{
    public class ShellNavbarViewModel : ViewModelBase
    {
        private readonly UserService _userService = UserService.Instance;

        public ICommand ListViewItemSelectedCommand { get; set; }

        public ObservableCollection<NavbarItemModel> MenuItems { get; set; }

        public Uri ProfileSource => _userService.Profile;
        public string ProfileName => $"Hai, {_userService.Name}!";

        public event EventHandler RequestDeselection;

        public ShellNavbarViewModel()
        {
            PopulateItems();
            ListViewItemSelectedCommand = new Command<NavbarItemModel>(ListView_ItemSelected);
            Task.Run(() => Task.Delay(200)).ContinueWith(x =>
            {
                OnPropertyChanged(nameof(ProfileSource));
                OnPropertyChanged(nameof(ProfileName));
            });
        }

        private void PopulateItems()
        {
            MenuItems = new ObservableCollection<NavbarItemModel>(new[]
            {
                new NavbarItemModel { Id = PageId.Dashboard, Title = "Beranda" },
                new NavbarItemModel { Id = PageId.Tutorial, Title = "Tutorial" },
                new NavbarItemModel { Id = PageId.Blog, Title = "Blog" },
                new NavbarItemModel { Id = PageId.About, Title = "About" },
                new NavbarItemModel { Id = PageId.Logout, Title = "Logout" },
            });
        }

        private void ListView_ItemSelected(NavbarItemModel model)
        {
            if (model == null) return;
            if (model.Id == PageId.Logout)
            {
                _userService.Logout();
                Application.Current.MainPage = PageFactory.GetPage(PageId.Login);
                return;
            }

            var master = Application.Current.MainPage as MasterDetailPage;
            var page = PageFactory.GetPage(model.Id);
            master.Detail = new NavigationPage(page);
            master.IsPresented = false;

            RequestDeselection?.Invoke(this, EventArgs.Empty);
        }

    }
}