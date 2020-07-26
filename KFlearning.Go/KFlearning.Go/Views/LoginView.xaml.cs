using KFlearning.Go.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFlearning.Go.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ((LoginViewModel)BindingContext).CheckLogin();
        }
    }
}