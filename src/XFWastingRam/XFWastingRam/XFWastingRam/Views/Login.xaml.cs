using System;
using System.Reactive.Disposables;
using ReactiveUI;
using Xamarin.Forms.Xaml;
using Splat;
using System.Diagnostics;
using Xamarin.Forms;
using XFWastingRam.ViewModels;
using XFWastingRam.Views;

namespace XFWastingRam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPageBase<LoginViewModel>
    {
        public Login()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this
                .Bind(
                    ViewModel, vm => vm.UserName,
                    v => v.UserName.Text).DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.WelcomeMessage,
                    v => v.WelcomeMessage.Text, x => x).DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.LoginCommand,
                        v => v.btnLogin.Command, x => x)
                    .DisposeWith(disposables);
                //var navigationPage = Parent as NavigationPage;
                //if (navigationPage != null)
                //    navigationPage.BarBackgroundColor = Color.White;

            });
        }
    }
}
