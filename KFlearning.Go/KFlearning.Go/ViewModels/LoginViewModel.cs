using KFlearning.Go.Infrastructure;
using KFlearning.Go.Views;
using Newtonsoft.Json;
using Plugin.GoogleClient;
using Plugin.GoogleClient.Shared;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace KFlearning.Go.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        IGoogleClientManager _googleService = CrossGoogleClient.Current;
        private bool _silentLogin;
        private bool _loginIsVisible;

        public ICommand LoginCommand { get; set; }

        public bool LoginIsVisible 
        {
            get => _loginIsVisible; 
            set
            {
                _loginIsVisible = value;
                OnPropertyChanged(nameof(LoginIsVisible));
            } 
        }

        public LoginViewModel()
        {
            _googleService.OnLogin += _googleService_OnLogin;
            LoginCommand = new Command(async () =>
            {
                await LoginGoogleAsync();
            });
        }

        private async void _googleService_OnLogin(object sender, GoogleClientResultEventArgs<GoogleUser> e)
        {
            if (e.Status == GoogleActionStatus.Completed)
            {
                var googleUserString = JsonConvert.SerializeObject(e.Data);
                Debug.WriteLine($"Google Logged in succesfully: {googleUserString}");
                Application.Current.MainPage = new ShellView();
            }

            if (_silentLogin)
            {
                LoginIsVisible = e.Status != GoogleActionStatus.Completed;
                return;
            }

            LoginIsVisible = true;
            switch (e.Status)
            {
                case GoogleActionStatus.Completed:
                    break;
                case GoogleActionStatus.Canceled:
                    await Application.Current.MainPage.DisplayAlert("KFlearning Go", "Otentikasi dibatalkan", "Tutup");
                    break;
                case GoogleActionStatus.Error:
                    await Application.Current.MainPage.DisplayAlert("KFlearning Go", "Gagal melakukan otentikasi dengan Google", "Tutup");
                    break;
                case GoogleActionStatus.Unauthorized:
                    await Application.Current.MainPage.DisplayAlert("KFlearning Go", "Tidak dapat meminta akses dengan akun", "Tutup");
                    break;
            }
        }

        public async Task CheckLogin()
        {
            try
            {
                _silentLogin = true;
                await _googleService.SilentLoginAsync();
            }
            catch (Exception ex)
            {
                LoginIsVisible = true;
                Debug.WriteLine(ex.ToString());
            }
        }

        private async Task LoginGoogleAsync()
        {
            try
            {
                _silentLogin = false;
                if (!string.IsNullOrEmpty(_googleService.AccessToken))
                {
                    _googleService.Logout();
                }

                LoginIsVisible = false;
                await _googleService.LoginAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                LoginIsVisible = true;
                await Application.Current.MainPage.DisplayAlert("KFlearning Go", "Gagal melakukan otentikasi dengan Google", "Tutup");
            }
        }
    }
}
