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
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Serialization;

namespace WindowMediaPlayer.Tabs
{
    /// <summary>
    /// Interaction logic for PlaylistTab.xaml
    /// </summary>
    public partial class PlaylistTab : UserControl
    {
        public PlaylistLib playlistLib = new PlaylistLib();
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private List<Music> musicList = new List<Music>();
        private bool isDragging = false;
        private TimeSpan fullDuration;
        private Music currentSong;
        ModernDialog1 dialog;
        private int index;

        public PlaylistTab()
        {
            InitializeComponent();
            DeserializeXML();
            MusicTimer.Text = "00:00";
            MusicFullDuration.Text = "00:00";
            All_Playlists.ItemsSource = playlistLib.nameList;
            mediaPlayer.MediaOpened += MediaPlayer_MediaOpened;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void MediaPlayer_MediaOpened(object sender, EventArgs e)
        {
            btnPlayPause.IsEnabled = true;
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                MusicFullDuration.Text = mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss");
                fullDuration = mediaPlayer.NaturalDuration.TimeSpan;
                Slider_Music.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                btnPlayPause.Content = Resources["Pause"];
                mediaPlayer.Play();
                Volume.Value = mediaPlayer.Volume;
            }
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

        private void DeserializeXML()
        {
            try
            {
                XmlSerializer reader = new XmlSerializer(playlistLib.GetType());
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//playlists.xml";

                if (File.Exists(path))
                {
                    FileStream file = new FileStream(path, FileMode.Open);
                    playlistLib = (PlaylistLib)reader.Deserialize(file);
                    file.Close();
                }
            }
            catch (IOException e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void SerializeToXML()
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(playlistLib.GetType());
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//playlists.xml";

                FileStream file = File.Create(path);
                writer.Serialize(file, playlistLib);
                file.Close();
            }
            catch (IOException e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void btnAddPlaylist(object sender, RoutedEventArgs e)
        {
            dialog = new ModernDialog1();
            dialog.OkButton.Click += OkButton_Click;
            dialog.ShowDialog();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(dialog.textbox.Text))
            {
                ModernDialog diag = new ModernDialog();

                diag.Title = "Error";
                diag.Content = "Error please put a name";
                diag.ShowDialog();
                return;
            }
            SendPlaylist();
        }

        private void SendPlaylist()
        {
            Playlist p = new Playlist(dialog.textbox.Text, dialog.musicLibrary.musics);

            playlistLib.playlist.Add(p);
            playlistLib.RefreshNameList();
            SerializeToXML();
            All_Playlists.Items.Refresh();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = ItemsControl.ContainerFromElement((DataGrid)sender, e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                string name = row.Item as string;
                int i = playlistLib.nameList.IndexOf(name);
                musicList = playlistLib.playlist[i].MusicList;
                
                if (musicList != null)
                {
                    Playlist_Content.ItemsSource = musicList;
                    Playlist_Content.Items.Refresh();
                }
            }
        }

        private void Music_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = ItemsControl.ContainerFromElement((DataGrid)sender, e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                Music music = row.Item as Music;
                index = ((DataGrid)sender).SelectedIndex;
                
                if (File.Exists(music.PathUri.LocalPath))
                {
                    currentSong = music;
                    mediaPlayer.Open(music.PathUri);
                    Volume.Value = mediaPlayer.Volume;
                }
            }
        }

        private void btnPlayPause_Click(object sender, RoutedEventArgs e)
        {
            if (currentSong == null)
            {
                currentSong = (Music)Playlist_Content.SelectedItem;
                if (currentSong != null)
                {
                    index = Playlist_Content.SelectedIndex;
                    mediaPlayer.Open(currentSong.PathUri);
                }
                return;
            }
            else
            {
                Music music = (Music)Playlist_Content.SelectedItem;
                if (music != currentSong && music != null)
                {
                    currentSong = music;
                    btnPlayPause.Content = this.Resources["Play"];
                    mediaPlayer.Stop();
                    mediaPlayer.Open(currentSong.PathUri);
                    index = Playlist_Content.SelectedIndex;
                    return;
                }
            }

            if (btnPlayPause.Content == this.Resources["Pause"])
            {
                btnPlayPause.Content = this.Resources["Play"];
                mediaPlayer.Pause();
            }
            else if (btnPlayPause.Content == Resources["Play"])
            {
                btnPlayPause.Content = this.Resources["Pause"];
                mediaPlayer.Play();
            }
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
                btnPlayPause.Content = Resources["Play"];
                DataGridRow row = (DataGridRow)Playlist_Content.ItemContainerGenerator.ContainerFromIndex(index + 1);

                if (row != null)
                {
                    Music next = (Music)row.Item;

                    ++index;
                    Playlist_Content.SelectedIndex = index;
                    currentSong = next;
                    mediaPlayer.Open(next.PathUri);
                }
                else if (row == null && btnLoop.Content == Resources["LoopActive"])
                {
                    row = (DataGridRow)Playlist_Content.ItemContainerGenerator.ContainerFromIndex(0);

                    Music next = (Music)row.Item;
                    index = 0;
                    Playlist_Content.SelectedIndex = index;
                    currentSong = next;
                    mediaPlayer.Open(next.PathUri);
                }
                else
                {
                    Playlist_Content.SelectedIndex = -1;
                    mediaPlayer.Position = TimeSpan.FromSeconds(0.0);
                }
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

        private void btnBackward_Click(object sender, RoutedEventArgs e)
        {
            if (index == 0)
                return;

            DataGridRow row = (DataGridRow)Playlist_Content.ItemContainerGenerator.ContainerFromIndex(index - 1);

            if (row != null)
            {
                Music prev = (Music)row.Item;

                --index;
                currentSong = prev;
                Playlist_Content.SelectedIndex = index;
                mediaPlayer.Open(prev.PathUri);
            }
            else
            {
                Playlist_Content.SelectedIndex = -1;
                mediaPlayer.Position = TimeSpan.FromSeconds(0.0);
            }
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow row = (DataGridRow)Playlist_Content.ItemContainerGenerator.ContainerFromIndex(index + 1);

            if (row != null)
            {
                Music prev = (Music)row.Item;

                ++index;
                currentSong = prev;
                Playlist_Content.SelectedIndex = index;
                mediaPlayer.Open(prev.PathUri);
            }
            else
            {
                Playlist_Content.SelectedIndex = -1;
                mediaPlayer.Position = TimeSpan.FromSeconds(0.0);
            }
        }

        private void btnLoop_Click(object sender, RoutedEventArgs e)
        {
            if (btnLoop.Content == this.Resources["Loop"])
                btnLoop.Content = this.Resources["LoopActive"];
            else
                btnLoop.Content = this.Resources["Loop"];
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
