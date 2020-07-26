using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFlearning.Go.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrowserView : ContentPage
    {
        public BrowserView()
        {
            InitializeComponent();
        }

        public BrowserView(string url) : this()
        {
            w.Source = url;
        }
    }
}