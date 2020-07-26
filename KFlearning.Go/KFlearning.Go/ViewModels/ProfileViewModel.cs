using KFlearning.Go.Infrastructure;
using KFlearning.Go.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KFlearning.Go.ViewModels
{
    public class ProfileViewModel : ViewModelBase
    {
        private readonly UserService _userService = UserService.Instance;

        public Uri ProfileUrl => _userService.Profile;

        public string ProfileName => _userService.Name;

        public string ProfileEmail => _userService.Email;
    }
}
