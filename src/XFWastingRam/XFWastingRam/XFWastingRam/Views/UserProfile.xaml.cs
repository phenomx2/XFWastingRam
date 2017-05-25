using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFWastingRam.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFWastingRam.Views;

namespace XFWastingRam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserProfile : ContentPageBase<UserProfileViewModel>
    {
        public UserProfile()
        {
            InitializeComponent();
        }
    }
}
