using ReactiveUI;
using Splat;
using XFWastingRam.ViewModels;

namespace XFWastingRam.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel(IScreen hostScreen) : base(hostScreen)
        {
            UrlPathSegment = "TodoList";
        }
    }
}