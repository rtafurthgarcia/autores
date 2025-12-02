using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoResCore.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial ObservableCollection<WindowsDisplayAPI.Display> DisplayMonitors { get; set; }

        [ObservableProperty]
        public partial WindowsDisplayAPI.Display SelectedDisplay { get; set; }
        public MainViewModel() {
            DisplayMonitors = new(WindowsDisplayAPI.Display.GetDisplays());
        }
    }
}
