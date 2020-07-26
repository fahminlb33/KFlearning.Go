using KFlearning.Go.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace KFlearning.Go.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        public ICommand TestCommand { get; set; }

        public DashboardViewModel()
        {
            TestCommand = new Command(async () =>
            {
                var browser = PageFactory.GetBrowserPage("https://google.com");
                var shell = Application.Current.MainPage as MasterDetailPage;
                await shell.Detail.Navigation.PushAsync(browser);
            });
            
        }
    }
}
