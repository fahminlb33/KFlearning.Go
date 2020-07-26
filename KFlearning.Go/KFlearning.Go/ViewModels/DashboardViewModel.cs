using KFlearning.Go.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace KFlearning.Go.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        public ICommand LoginCommand { get; set; }

        public DashboardViewModel()
        {

        }
    }
}
