using System;
using System.Diagnostics;
using System.Threading.Tasks;
using ReactiveUI;
using Splat;

namespace XFWastingRam.ViewModels
{
    public class ConfirmAuditoriumBookingViewModel : ViewModelBase
    {
        public ReactiveCommand Cancel { get; set; }
        public ReactiveCommand Confirm { get; set; }

        public ConfirmAuditoriumBookingViewModel(IScreen hostScreen) : base(hostScreen)
        {
            Cancel = ReactiveCommand.Create(() =>
            {
                var vm = Locator.Current.GetService<MenuViewModel>();
                HostScreen.Router.NavigateAndReset.Execute(vm).Subscribe();
            });

            Confirm = ReactiveCommand.CreateFromTask(async _ =>
            {
                await Task.Delay(1);
                var vm = Locator.Current.GetService<MenuViewModel>();
                HostScreen.Router.NavigateAndReset.Execute(vm).Subscribe();
            });
            Cancel.ThrownExceptions.Subscribe(ex =>
            {
                Debugger.Break();
            });
            Confirm.ThrownExceptions.Subscribe(ex =>
            {
                Debugger.Break();
            });
        }
    }
}