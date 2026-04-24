using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using AYGUCI.ViewModels;

namespace AYGUCI.Views
{
    public partial class IHAListView : UserControl
    {
        public IHAListView()
        {
            InitializeComponent();

            DataContext = new IHAListViewModel();
        }   
    }
}
