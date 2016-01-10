using FirstFloor.ModernUI.Windows.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Interaction logic for ModernDialog1.xaml
    /// </summary>
    public partial class ModernDialog1 : ModernDialog
    {
        public MusicLibrary musicLibrary = new MusicLibrary();
        public string name { get; set; }

        public ModernDialog1()
        {
            InitializeComponent();
            All_PlaylistMusics.ItemsSource = musicLibrary.musics;

            // define the dialog buttons
            this.Buttons = new Button[] { this.OkButton, this.CancelButton };
        }
        
        private void btnAddMusics(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Filter = "Music Files (*.mp3;*.wav)|*.mp3;*.wav|All Files (*.*)|*.*";

            bool? result = fileDialog.ShowDialog();

            if (result == true)
            {
                foreach (string musicPath in fileDialog.FileNames)
                {
                    if (File.Exists(musicPath))
                    {
                        Music music = new Music(musicPath);
                        musicLibrary.musics.Add(music);
                    }
                }
                All_PlaylistMusics.Items.Refresh();
            }
        }
    }
}
