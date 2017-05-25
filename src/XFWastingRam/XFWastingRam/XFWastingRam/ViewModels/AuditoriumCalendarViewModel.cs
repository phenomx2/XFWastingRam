using System;
using System.Collections.Generic;
using ReactiveUI;
using Splat;
using XFWastingRam.Dto;
using XFWastingRam.ViewModels;

namespace XFWastingRam.ViewModels
{
    public class AuditoriumCalendarViewModel : ViewModelBase
    {
        private AuditoriumWeek _auditoriumWeek;
        private ReactiveList<bool> _mondayCells;

        public ReactiveList<bool> MondayCells
        {
            get => _mondayCells;
            set => this.RaiseAndSetIfChanged(ref _mondayCells, value);
        }

        public ReactiveCommand ToBookingDetail { get; set; }


        public AuditoriumWeek AuditoriumWeek
        {
            get => _auditoriumWeek;
            set => this.RaiseAndSetIfChanged(ref _auditoriumWeek,value);
        }
        
        public AuditoriumCalendarViewModel(IScreen hostScreen) : base(hostScreen)
        {
            MondayCells = new ReactiveList<bool>()
            {
                false, false, false,false,false, true, true, false, false, false
                ,false, false,false, true
            };
            AuditoriumWeek = new AuditoriumWeek
            {
                Start = DateTime.Now.Subtract(TimeSpan.FromDays(2)),
                End = DateTime.Now.AddDays(2),
                MondayBusyHours = new List<Tuple<TimeSpan, TimeSpan>>
                {
                    new Tuple<TimeSpan, TimeSpan>(TimeSpan.FromHours(7),TimeSpan.FromHours(9) )
                },
                TuestdayBusyHours = new List<Tuple<TimeSpan, TimeSpan>>
                {
                    new Tuple<TimeSpan, TimeSpan>(TimeSpan.FromHours(11),TimeSpan.FromHours(13) )
                }

            };

            ToBookingDetail = ReactiveCommand.Create(() =>
            {
                var vm = Locator.Current.GetService<AuditoriumBookingDetailViewModel>();
                HostScreen.Router.Navigate.Execute(vm).Subscribe();
            });

    }
    }
}