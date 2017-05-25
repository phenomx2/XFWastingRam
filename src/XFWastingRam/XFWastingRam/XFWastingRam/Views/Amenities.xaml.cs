using ReactiveUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using System.Diagnostics;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using XFWastingRam.Dto;
using XFWastingRam.ViewModels;
using XFWastingRam.Views;

namespace XFWastingRam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Amenities : ContentPageBase<AmenitiesViewModel>
    {
        public Amenities()
        {
            InitializeComponent();
            this.WhenAnyValue(v => v.ViewModel)
                .Where(vm => vm != null)
                .Subscribe(vm =>
                {
                    try
                    {
                        foreach (var otherAmenity in vm.OtherAmenities)
                        {
                            AmenitiesContainer.Children.Add(CreateAmenityGrid(otherAmenity));
                        }
                    }
                    catch (Exception e)
                    {
                        Debugger.Break();
                        throw;
                    }

                });
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, vm => vm.ToAuditorium,
                        v => v.AuditoriumGesture.Command, x => x)
                    .DisposeWith(disposables);
                
            });

        }

        private View CreateAmenityGrid(Amenity otherAmenity)
        {
            var grid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition{ Width = GridLength.Auto},
                    new ColumnDefinition{ Width = GridLength.Auto}
                }
            };
            var image = new Image {Source = ImageSource.FromFile("icon.png")};
            var label = new Label{ Text = otherAmenity.Name, TextColor = Color.Black};
            grid.Children.AddHorizontal(image);
            grid.Children.AddHorizontal(label);
            return grid;
        }
    }
}
