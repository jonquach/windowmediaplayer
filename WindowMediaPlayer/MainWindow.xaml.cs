using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowMediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        private bool fullscreen = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ModernWindow_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine(e.Key);
            if (e.Key == Key.F5)
            {
                if (!fullscreen)
                {
                    ResizeMode = ResizeMode.NoResize;
                    WindowStyle = WindowStyle.None;
                    WindowState = WindowState.Maximized;
                }
                else
                {
                    ResizeMode = ResizeMode.CanResize;
                    WindowStyle = WindowStyle.SingleBorderWindow;
                    WindowState = WindowState.Normal;
                }
                fullscreen = !fullscreen;
            }
        }
    }
}
