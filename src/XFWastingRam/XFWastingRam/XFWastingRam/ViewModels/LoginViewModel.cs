using System;
using System.Diagnostics;
using ReactiveUI;
using Splat;
using XFWastingRam.ViewModels;

namespace XFWastingRam.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public ReactiveCommand LoginCommand { get; set; }

        private string _userName;
        private string _welcomeMessage;
        public string UserName
        {
            get => _userName;
            set => this.RaiseAndSetIfChanged(ref _userName, value);
        }

        public string WelcomeMessage
        {
            get => _welcomeMessage;
            set => this.RaiseAndSetIfChanged(ref _welcomeMessage, value);
        }

        public LoginViewModel(IScreen hostScreen) : base(hostScreen)
        {
            UrlPathSegment = "Login";
            WelcomeMessage = "Bienvenido a HexaConcierge";
            LoginCommand = ReactiveCommand.Create(() =>
            {
                var menuVm = Locator.Current.GetService<MenuViewModel>();
                HostScreen.Router.Navigate.Execute(menuVm).Subscribe();
            });
            LoginCommand.ThrownExceptions.Subscribe(ex =>
            {
                
                Debugger.Break();
            });
        }

        


    }
}