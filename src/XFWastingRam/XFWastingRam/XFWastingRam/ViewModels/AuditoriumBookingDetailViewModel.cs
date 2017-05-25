using System;
using System.Diagnostics;
using ReactiveUI;
using Splat;

namespace XFWastingRam.ViewModels
{
    public class AuditoriumBookingDetailViewModel : ViewModelBase
    {
        private TimeSpan _start;
        private TimeSpan _end;

        public ReactiveCommand ToConfirm { get; set; }
        public TimeSpan Start
        {
            get => _start;
            set => this.RaiseAndSetIfChanged(ref _start, value);
        }

        public TimeSpan End
        {
            get => _end;
            set => this.RaiseAndSetIfChanged(ref _end, value);
        }

        public AuditoriumBookingDetailViewModel(IScreen hostScreen) : base(hostScreen)
        {
            UrlPathSegment = "Detalle reserva";
            ToConfirm = ReactiveCommand.Create(() =>
            {
                System.Diagnostics.Debug.WriteLine(Start);
                System.Diagnostics.Debug.WriteLine(End);
                var vm = Locator.Current.GetService<ConfirmAuditoriumBookingViewModel>();
                HostScreen.Router.Navigate.Execute(vm).Subscribe();
            });
            ToConfirm.ThrownExceptions.Subscribe(ex =>
            {
                Debugger.Break();
            });
        }
    }
}