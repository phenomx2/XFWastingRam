using System;
using ReactiveUI;
using ReactiveUI.XamForms;
using Splat;
using Xamarin.Forms;
using XFWastingRam.Util;
using XFWastingRam.ViewModels;
using XFWastingRam.Views;

namespace XFWastingRam
{
    public class AppBootstraper : ReactiveObject, IScreen
    {
        public RoutingState Router { get; }

        public AppBootstraper()
        {
            try
            {
                Router = new RoutingState();
                Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));
                RegisterViews();
                RegisterViewModels();
                Router.Navigate.Execute(new LoginViewModel(this));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debugger.Break();
                throw;
            }
        }

        public Page CreateMainPage()
        {
            return new RoutedViewHost();
        }

        private void RegisterViews()
        {
            Locator.CurrentMutable.Register(() => new Login().SetIconPage(), typeof(IViewFor<LoginViewModel>));
            Locator.CurrentMutable.Register(() => new TodoList().SetIconPage(), typeof(IViewFor<TodoListViewModel>));
            Locator.CurrentMutable.Register(() => new Menu().SetIconPage(), typeof(IViewFor<MenuViewModel>));
            Locator.CurrentMutable.Register(() => new UserProfile().SetIconPage(), typeof(IViewFor<UserProfileViewModel>));
            Locator.CurrentMutable.Register(() => new Amenities().SetIconPage(), typeof(IViewFor<AmenitiesViewModel>));
            Locator.CurrentMutable.Register(() => new AuditoriumCalendar().SetIconPage(), typeof(IViewFor<AuditoriumCalendarViewModel>));
            Locator.CurrentMutable.Register(() => new AuditoriumBookingDetail().SetIconPage(), typeof(IViewFor<AuditoriumBookingDetailViewModel>));
            Locator.CurrentMutable.Register(() => new ConfirmAuditoriumBooking().SetIconPage(), typeof(IViewFor<ConfirmAuditoriumBookingViewModel>));
        }

        private void RegisterViewModels()
        {
            Locator.CurrentMutable.Register(() => new TodoListViewModel(this), typeof(TodoListViewModel));
            Locator.CurrentMutable.Register(() => new MenuViewModel(this), typeof(MenuViewModel));
            Locator.CurrentMutable.Register(() => new UserProfileViewModel(this), typeof(UserProfileViewModel));
            Locator.CurrentMutable.Register(() => new AmenitiesViewModel(this), typeof(AmenitiesViewModel));
            Locator.CurrentMutable.Register(() => new AuditoriumCalendarViewModel(this), typeof(AuditoriumCalendarViewModel));
            Locator.CurrentMutable.Register(() => new AuditoriumBookingDetailViewModel(this), typeof(AuditoriumBookingDetailViewModel));
            Locator.CurrentMutable.Register(() => new ConfirmAuditoriumBookingViewModel(this), typeof(ConfirmAuditoriumBookingViewModel));
        }

        private void RegisterSingletons()
        {

        }
    }
}