using KFlearning.Go.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KFlearning.Go.ViewModels
{

    public class ShellMenuItemViewModel
    {
        public ShellMenuItemViewModel()
        {
            TargetType = typeof(DashboardView);
            
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}