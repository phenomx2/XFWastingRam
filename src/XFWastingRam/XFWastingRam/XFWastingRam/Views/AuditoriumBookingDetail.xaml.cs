using System.Reactive.Disposables;
using XFWastingRam.ViewModels;
using ReactiveUI;
using Xamarin.Forms.Xaml;

namespace XFWastingRam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuditoriumBookingDetail : ContentPageBase<AuditoriumBookingDetailViewModel>
    {
        public AuditoriumBookingDetail()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel, vm => vm.Start,
                    v => v.StartTime.Time).DisposeWith(disposables);
                this.Bind(ViewModel, vm => vm.End,
                    v => v.EndTime.Time).DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.ToConfirm,
                    v => v.Confirm.Command, x => x).DisposeWith(disposables);
            });

        }
    }
}
