using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using System.Buffers;
using System.Linq;
using Windows.UI.Shell;
using WinUIEx;
using WinUIEx.Messaging;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AutoResWinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : WindowEx
    {
        // those are DIP!!
        // basically, the modern App SDK has device-independant pixels so that all apps may appear the same no matter the resolution
        // more info here: https://ben.stolovitz.com/posts/resize_winui_window_part_0_dpi/
        const int WINDOW_WIDTH = 320;
        const int WINDOW_HEIGHT = 640;
        const int BORDER = 8;

        public MainWindow() 
        {
            InitializeComponent();

            this.AppWindow.SetTaskbarIcon("Assets/modern-tv.ico");
            //this.AppWindow.SetTitleBarIcon("Assets/modern-tv.ico");
            this.AppWindow.SetIcon("Assets/modern-tv.ico");

            var windowManager = WindowManager.Get(this);
            windowManager.IsVisibleInTray = true;
            
            this.VisibilityChanged += MainWindow_VisibilityChanged;
        }

        // from https://ben.stolovitz.com/posts/resize_winui_window_part_2_resize/
        private static int DipToPhysical(double dip, uint dpi)
        {
            return (int)(dip * dpi / 96.0);
        }

        private void MainWindow_VisibilityChanged(object sender, WindowVisibilityChangedEventArgs args)
        {
            if (args.Visible)
            {
                var dpi = this.GetDpiForWindow();
                var displayArea = DisplayArea.Primary.WorkArea;

                this.MoveAndResize(
                    displayArea.Width - DipToPhysical(WINDOW_WIDTH + BORDER, dpi),
                    displayArea.Height - DipToPhysical(WINDOW_HEIGHT + BORDER, dpi),
                    WINDOW_WIDTH,
                    WINDOW_HEIGHT
                );
                
            }
        }
    }
}
