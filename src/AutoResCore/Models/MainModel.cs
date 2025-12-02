using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections;
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AutoResCore.Models
{
    public partial class MainModel: ObservableObject
    {
        public ObservableCollection<WindowsDisplayAPI.Display> DisplayMonitors { get; set; } = new();
    }
}
