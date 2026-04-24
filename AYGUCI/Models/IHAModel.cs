using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace AYGUCI.ViewModels
{
    public class IHAModel : INotifyPropertyChanged
    {
        public string UavId { get; set; }
        public string Callsign { get; set; }
        public int BatteryPercentage { get; set; }
        public string StatusIcon { get; set; }
        public string BatteryIcon { get; set; }
        public string AltitudeInfo { get; set; }

        public Brush StatusColorBrush { get; set; }
        public Brush AltitudeColorBrush { get; set; }
        public Brush BackgroundColor { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}