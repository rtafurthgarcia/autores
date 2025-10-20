using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AutoResCore.Core
{
    public partial class MainViewModel: ObservableObject
    {
        

        [ObservableProperty]
        public partial bool AutoRestart { get; set; }

        [RelayCommand]
        public void displayWindow()
        {
            throw new NotImplementedException();
        }

        [RelayCommand]
        public void hideWindow()
        {
            throw new NotImplementedException();
        }
    }
}
