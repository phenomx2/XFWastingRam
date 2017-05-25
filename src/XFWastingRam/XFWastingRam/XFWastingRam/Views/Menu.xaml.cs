using XFWastingRam.ViewModels;
using ReactiveUI;
using Xamarin.Forms.Xaml;
using System.Reactive.Disposables;

namespace XFWastingRam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPageBase<MenuViewModel>
    {
        public Menu()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, vm => vm.NavigateToAmenities,
                    v => v.AmenitiesGesture.Command, x => x).DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.NavigateToContactUs,
                        v => v.ContactUsGesture.Command, x => x).DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.NavigateToUserProfile,
                    v => v.Profile.Command, x => x).DisposeWith(disposables);

            });
        }

        
    }
}
