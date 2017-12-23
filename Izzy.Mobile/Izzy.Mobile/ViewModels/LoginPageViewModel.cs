using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Prism.Services;

namespace Izzy.Mobile.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        private string _userName;
        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private readonly IPageDialogService _pageDialogService;
        public DelegateCommand LoginCommand { get; }

        public LoginPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService)
        {
            _pageDialogService = pageDialogService;
            LoginCommand = new DelegateCommand(OnLoginCommandExecute, LoginCommandCanExecute).ObservesProperty(() => UserName).ObservesProperty(() => Password);
        }

        private bool LoginCommandCanExecute() => !string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password) && IsNotBusy;

        private void OnLoginCommandExecute()
        {

        }
    }
}
