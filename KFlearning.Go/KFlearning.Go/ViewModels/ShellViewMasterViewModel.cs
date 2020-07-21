using KFlearning.Go.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KFlearning.Go.ViewModels
{
    class ShellViewMasterViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ShellViewMasterMenuItem> MenuItems { get; set; }

        public ShellViewMasterViewModel()
        {
            MenuItems = new ObservableCollection<ShellViewMasterMenuItem>(new[]
            {
                    new ShellViewMasterMenuItem { Id = 0, Title = "Profil" },
                    new ShellViewMasterMenuItem { Id = 1, Title = "Beranda" },
                    new ShellViewMasterMenuItem { Id = 2, Title = "Tutorial" },
                    new ShellViewMasterMenuItem { Id = 3, Title = "Blog" },
                    new ShellViewMasterMenuItem { Id = 4, Title = "About" },
                    new ShellViewMasterMenuItem { Id = 5, Title = "Logout" },
                });
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}