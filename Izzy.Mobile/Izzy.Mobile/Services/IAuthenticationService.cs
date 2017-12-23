using System;
using System.Collections.Generic;
using System.Text;
using Izzy.Mobile.Helpers;
using Prism.Navigation;

namespace Izzy.Mobile.Services
{
    public interface IAuthenticationService
    {
        bool Login(string username, string password);

        void Logout();
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly INavigationService _navigationService;


        public AuthenticationService(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public bool Login(string username, string password)
        {
            return false;
        }

        public void Logout()
        {
            Settings.Current.UserToken = string.Empty;
            _navigationService.NavigateAsync("/Login");
        }
    }
}
