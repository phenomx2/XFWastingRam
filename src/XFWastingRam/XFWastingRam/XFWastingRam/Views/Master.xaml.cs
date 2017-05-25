using Xamarin.Forms.Xaml;
using XFWastingRam.ViewModels;
using XFWastingRam.Views;

namespace XFWastingRam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPageBase<MasterViewModel>
    {
        public Master()
        {
            InitializeComponent();
        }
    }
}
