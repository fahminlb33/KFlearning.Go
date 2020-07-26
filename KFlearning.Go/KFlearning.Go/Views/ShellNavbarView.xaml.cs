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
    public partial class ShellNavbarView : ContentPage
    {
        public ShellNavbarView()
        {
            InitializeComponent();
            
            var vm = new ShellNavbarViewModel();
            vm.RequestDeselection += Vm_RequestDeselection;
            BindingContext = vm;
        }

        private void Vm_RequestDeselection(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() => MenuItemsListView.SelectedItem = null);
        }
    }
}