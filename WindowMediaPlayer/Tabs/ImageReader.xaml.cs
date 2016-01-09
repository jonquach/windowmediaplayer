using FirstFloor.ModernUI.Windows.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace WindowMediaPlayer.Tabs
{
    /// <summary>
    /// Interaction logic for ImageReader.xaml
    /// </summary>
    public partial class ImageReader : UserControl
    {
        public ImageReader()
        {
            InitializeComponent();
        }

        private void AddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Multiselect = true;
            fileDialog.Filter = "Images Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";

            bool? result = fileDialog.ShowDialog();

            if (result == true)
            {
                try
                {
                    ImageElement.Source = new BitmapImage(new Uri(fileDialog.FileName));
                }
                catch (NotSupportedException ex)
                {
                    ModernDialog info = new ModernDialog();
                    info.Title = "Error";
                    info.Content = "Can't open image : " + ex.Message;
                    info.ShowDialog();
                }
            }
        }
    }
}
