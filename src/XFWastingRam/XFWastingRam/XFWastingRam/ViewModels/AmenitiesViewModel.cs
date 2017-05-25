using System;
using System.Collections.Generic;
using ReactiveUI;
using System.Diagnostics;
using Splat;
using XFWastingRam.Dto;
using XFWastingRam.ViewModels;

namespace XFWastingRam.ViewModels
{
    public class AmenitiesViewModel : ViewModelBase
    {
        public ReactiveCommand MyReservations { get; set; }
        public ReactiveCommand ToAuditorium { get; set; }
        public IEnumerable<Amenity> OtherAmenities { get; set; }

        public AmenitiesViewModel(IScreen hostScreen) : base(hostScreen)
        {
            UrlPathSegment = "Amenities";
            MyReservations = ReactiveCommand.Create(() =>
            {
                Debug.WriteLine("Mis reservaciones");
            });
            ToAuditorium = ReactiveCommand.Create(() =>
            {
                var vm = Locator.Current.GetService<AuditoriumCalendarViewModel>();
                HostScreen.Router.Navigate.Execute(vm).Subscribe();
            });
            OtherAmenities = new List<Amenity>();
        }
    }
}