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
                    new ShellViewMasterMenuItem { Id = 0, Title = "Page 1" },
                    new ShellViewMasterMenuItem { Id = 1, Title = "Page 2" },
                    new ShellViewMasterMenuItem { Id = 2, Title = "Page 3" },
                    new ShellViewMasterMenuItem { Id = 3, Title = "Page 4" },
                    new ShellViewMasterMenuItem { Id = 4, Title = "Page 5" },
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