using Plugin.GoogleClient;
using System;

namespace KFlearning.Go.Services
{
    public class UserService
    {
        private readonly IGoogleClientManager _googleService = CrossGoogleClient.Current;
        private static readonly Lazy<UserService> _instance = new Lazy<UserService>(() => new UserService());

        public static UserService Instance => _instance.Value;

        public string Name { get; set; }
        public string Email { get; set; }
        public Uri Profile { get; set; }

        public void Logout()
        {
            Name = "";
            Email = "";
            Profile = null;
            _googleService.Logout();
        }
    }
}
