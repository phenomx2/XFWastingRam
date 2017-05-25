using System.Reactive.Disposables;
using ReactiveUI;
using Splat;

namespace XFWastingRam.ViewModels
{
    public class ViewModelBase : ReactiveObject, IRoutableViewModel, ISupportsActivation
    {
        public ViewModelBase(IScreen hostScreen = null)
        {
            HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();
        }

        protected readonly CompositeDisposable SubscriptionDisposables = new CompositeDisposable();

        public string UrlPathSegment { get; protected set; }
        public IScreen HostScreen { get; protected set; }

        public ViewModelActivator Activator => _viewModelActivator;

        protected readonly ViewModelActivator _viewModelActivator = new ViewModelActivator();

    }
}