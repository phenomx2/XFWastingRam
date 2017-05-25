using ReactiveUI;
using XFWastingRam.ViewModels;

namespace XFWastingRam.ViewModels
{
    public class UserProfileViewModel : ViewModelBase
    {
        public UserProfileViewModel(IScreen hostScreen) : base(hostScreen)
        {
            UrlPathSegment = "Perfil de usuario";
        }
    }
}