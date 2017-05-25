using System.Linq;
using System.Reactive.Disposables;
using XFWastingRam.ViewModels;
using ReactiveUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFWastingRam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuditoriumCalendar : ContentPageBase<AuditoriumCalendarViewModel>
    {
        public AuditoriumCalendar()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell1.IsVisible, x => x.ElementAt(0))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell2.IsVisible, x => x.ElementAt(1))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell3.IsVisible, x => x.ElementAt(2))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell4.IsVisible, x => x.ElementAt(3))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell5.IsVisible, x => x.ElementAt(4))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell6.IsVisible, x => x.ElementAt(5))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell7.IsVisible, x => x.ElementAt(6))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell8.IsVisible, x => x.ElementAt(7))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell9.IsVisible, x => x.ElementAt(8))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell10.IsVisible, x => x.ElementAt(9))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell11.IsVisible, x => x.ElementAt(10))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell12.IsVisible, x => x.ElementAt(11))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell13.IsVisible, x => x.ElementAt(12))
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.MondayCells,
                        v => v.MondayCell14.IsVisible, x => x.ElementAt(13))
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel, vm => vm.ToBookingDetail,
                        v => v.MondayGesture.Command, x => x)
                    .DisposeWith(disposables);
            });
        }
    }
}
