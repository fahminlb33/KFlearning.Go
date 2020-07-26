using KFlearning.Go.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFlearning.Go.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlogView : ContentPage
    {
        public BlogView()
        {
            InitializeComponent();
            BindingContext = new BlogViewModel();
        }
    }
}