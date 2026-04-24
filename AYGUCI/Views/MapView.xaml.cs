using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GMap.NET;
using GMap.NET.MapProviders;

namespace AYGUCI.Views
{
    /// <summary>
    /// Interaction logic for MapView.xaml
    /// </summary>
    public partial class MapView : UserControl
    {
        public MapView()
        {
            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap()
        {
            // Harita Modu (Sadece internetten, sadece cache'den veya her ikisi)
            MainMap.MapProvider = GMapProviders.BingHybridMap; // Askeri görünüme en yakın hibrit harita

            // Başlangıç Koordinatı (Örn: Ankara)
            MainMap.Position = new PointLatLng(39.9334, 32.8597);

            // Mouse ile haritayı sürükleme (Sol tık ile kaydırma)
            MainMap.DragButton = System.Windows.Input.MouseButton.Left;

            // Gereksiz cache hatalarını önlemek için manager yüklenmeli
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
        }
    }
}
