using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using XFWastingRam.ViewModels;
using ReactiveUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFWastingRam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmAuditoriumBooking : ContentPageBase<ConfirmAuditoriumBookingViewModel>
    {
        public ConfirmAuditoriumBooking()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, vm => vm.Cancel,
                    v => v.Cancel.Command, x => x).DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.Confirm,
                    v => v.Comfirm.Command, x => x).DisposeWith(disposables);
            });
        }
    }
}