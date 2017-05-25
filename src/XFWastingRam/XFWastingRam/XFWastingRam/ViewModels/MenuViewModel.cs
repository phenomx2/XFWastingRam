using Splat;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;
using ReactiveUI;
using XFWastingRam.Dto;
using XFWastingRam.ViewModels;

namespace XFWastingRam.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public ReactiveCommand<Unit,IEnumerable<Amenity>> NavigateToAmenities { get; set; }
        public ReactiveCommand NavigateToContactUs { get; set; }
        public ReactiveCommand NavigateToUserProfile { get; set; }
        private string _date;

        public string CurrentDate
        {
            get => _date;
            set => this.RaiseAndSetIfChanged(ref _date, value);
        }


        public MenuViewModel(IScreen hostScreen) : base(hostScreen)
        {
            UrlPathSegment = "Menu";

            NavigateToAmenities = ReactiveCommand.CreateFromTask( async _ =>
            {
                await Task.Delay(1);
                CurrentDate = DateTime.Now.Ticks.ToString();
                var result = new List<Amenity>
                {
                    new Amenity{ Id = Guid.NewGuid().ToString(), Name = "Amenity1", Cost = 10},
                    new Amenity{ Id = Guid.NewGuid().ToString(), Name = "Amenity2", Cost = 10},
                    new Amenity{ Id = Guid.NewGuid().ToString(), Name = "Amenity3", Cost = 10}
                };
                return result.AsEnumerable();
            });

            NavigateToAmenities.Subscribe(amenities =>
            {
                var vm = Locator.Current.GetService<AmenitiesViewModel>();
                vm.OtherAmenities = amenities;
                HostScreen.Router.Navigate.Execute(vm).Subscribe();
            });

            NavigateToAmenities.ThrownExceptions.Subscribe(ex =>
            {
                Debugger.Break();
            });

            NavigateToContactUs = ReactiveCommand.Create(() =>
            {
                var vm = Locator.Current.GetService<TodoListViewModel>();
                HostScreen.Router.Navigate.Execute(vm).Subscribe();
            });

            NavigateToContactUs.ThrownExceptions.Subscribe(ex =>
            {
                Debugger.Break();
            });

            NavigateToUserProfile = ReactiveCommand.Create(() =>
            {
                var vm = Locator.Current.GetService<UserProfileViewModel>();
                HostScreen.Router.Navigate.Execute(vm).Subscribe();
            });

        }
    }
}