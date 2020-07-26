using KFlearning.Go.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFlearning.Go.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellView : MasterDetailPage
    {
        public ShellView()
        {
            InitializeComponent();
        }
    }
}