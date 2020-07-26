using KFlearning.Go.Infrastructure;
using KFlearning.Go.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace KFlearning.Go.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        private readonly UserService _userService = UserService.Instance;

        public ICommand OpenHomepageCommand { get; set; }
        public ICommand SendFeedbackCommand { get; set; }

        public DashboardViewModel()
        {
            OpenHomepageCommand = new Command(OpenHomepage_Handler);
            SendFeedbackCommand = new Command(SendFeedback_Handler);
        }

        private async void OpenHomepage_Handler()
        {
            await Browser.OpenAsync("https://kodesiana.com");
        }

        private async void SendFeedback_Handler()
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = "KFlearning Go Support Feedback",
                    Body = "Halo Admin! Saya pengguna KFlearning Go, ada saran yang ingin saya sampaikan!\n\n--Tulis saran Anda disini--",
                    To = new List<string>(){ "support@kodesiana.com" }
                };
                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                await Application.Current.MainPage.DisplayAlert("KFlearning Go", "Perangkat Anda tidak mendukung email.", "Tutup");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("KFlearning Go", "Gagal membuat email", "Tutup");
            }
        }
    }
}
