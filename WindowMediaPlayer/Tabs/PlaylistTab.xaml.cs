using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WindowMediaPlayer.Tabs
{
    /// <summary>
    /// Interaction logic for PlaylistTab.xaml
    /// </summary>
    public partial class PlaylistTab : UserControl
    {
        public MusicLibrary musicLibrary = new MusicLibrary();
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private List<string> musicList = new List<string>();
        private bool isDragging = false;
        private TimeSpan fullDuration;
        //private int index;

        public PlaylistTab()
        {
            InitializeComponent();
            MusicTimer.Text = "00:00";
            MusicFullDuration.Text = "00:00";

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (isDragging == false &&
                mediaPlayer.Source != null &&
                mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                Slider_Music.Value = mediaPlayer.Position.TotalSeconds;
            }
        }
        private void btnAddPlaylist(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlayPause_Click(object sender, RoutedEventArgs e)
        {
            if (btnPlayPause.Content == this.Resources["Play"])
            {
                btnPlayPause.Content = this.Resources["Pause"];
                mediaPlayer.Play();
            }
            else
            {
                btnPlayPause.Content = this.Resources["Play"];
                mediaPlayer.Pause();
            }
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
        private void Slider_DragStarted(object sender, DragStartedEventArgs e)
        {
            isDragging = true;
        }

        private void Slider_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            isDragging = false;
            mediaPlayer.Position = TimeSpan.FromSeconds(Slider_Music.Value);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MusicTimer.Text = TimeSpan.FromSeconds(Slider_Music.Value).ToString(@"mm\:ss");
            if (fullDuration.TotalSeconds == mediaPlayer.Position.TotalSeconds)
            {
                //Debug.WriteLine("end of music");
                //btnPlayPause.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                //DataGridRow row = (DataGridRow)All_Musics.ItemContainerGenerator.ContainerFromIndex(index + 1);

                //if (row != null)
                //{
                //    Music next = (Music)row.Item;

                //    ++index;
                //    All_Musics.SelectedIndex = index;
                //    mediaPlayer.Open(next.PathUri);
                //}
                //else
                //{
                //    All_Musics.SelectedIndex = -1;
                //    mediaPlayer.Position = TimeSpan.FromSeconds(0.0);
                //}
            }
        }
        private void HandleMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
                mediaPlayer.Volume += 0.1;
            else
                mediaPlayer.Volume -= 0.1;
            Volume.Value = mediaPlayer.Volume;
        }

        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) // Spacebar press
            {
                btnPlayPause.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.MouseWheel += HandleMouseWheel;
            this.PreviewKeyDown += HandleKeyPress;
            this.Focusable = true;
            this.Focus();
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            this.PreviewKeyDown -= HandleKeyPress;
            this.MouseWheel -= HandleMouseWheel;
            this.Focusable = false;
        }
    }
}
