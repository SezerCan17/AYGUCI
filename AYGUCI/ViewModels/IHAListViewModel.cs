using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media;

namespace AYGUCI.ViewModels
{
    public class IHAListViewModel
    {
        public ObservableCollection<IHAModel> IHAList { get; set; }


        public IHAListViewModel()
        {
            IHAList = new ObservableCollection<IHAModel>();

            IHAList.Add(new IHAModel
            {
                UavId = "DRONE-01",
                Callsign = "ALPHA",
                StatusIcon = "&#xE8CB;",
                StatusColorBrush = (SolidColorBrush)new BrushConverter().ConvertFromString("#4CAF50"),// SuccessGreen
                BatteryPercentage = 78,
                BatteryIcon = "&#xE8CB;",
                AltitudeInfo = "120 m",
                AltitudeColorBrush = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFFFFF"), // TextMain
                BackgroundColor = (SolidColorBrush)new BrushConverter().ConvertFromString("#15202B")
            });

            IHAList.Add(new IHAModel
            {
                UavId = "DRONE-05",
                Callsign = "ECHO",
                StatusIcon = "&#xE8CB;",
                StatusColorBrush = (SolidColorBrush)new BrushConverter().ConvertFromString("#F44336"), // CriticalRed
                BatteryPercentage = 18,
                BatteryIcon = "&#xE8CB;",
                AltitudeInfo = "85 m",
                AltitudeColorBrush = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFFFFF"), // TextMain
                BackgroundColor = Brushes.Transparent
            });


        }
    }
}
