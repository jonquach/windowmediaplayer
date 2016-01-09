using FirstFloor.ModernUI.Windows;
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
using FirstFloor.ModernUI.Windows.Navigation;
using System.Xml.Serialization;

namespace WindowMediaPlayer.Tabs
{
    /// <summary>
    /// Interaction logic for BasicPage1.xaml
    /// </summary>
    public partial class MusicTab : UserControl
    {
        //private List<Music> musics = new List<Music>();
        public MusicLibrary musicLibrary = new MusicLibrary();
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private List<string> musicList = new List<string>();
        private bool isDragging = false;
        private TimeSpan fullDuration;
        private int index;

        public MusicTab()
        {
            InitializeComponent();
            DeserializeXML();
            LoadMyMusic();
            MusicTimer.Text = "00:00";
            MusicFullDuration.Text = "00:00";
            mediaPlayer.MediaOpened += MediaPlayer_MediaOpened;
            All_Musics.ItemsSource = musicLibrary.musics;
            if (All_Musics.Items.Count == 0)
                btnPlayPause.IsEnabled = false;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void DeserializeXML()
        {
            try
            {
                XmlSerializer reader = new XmlSerializer(musicLibrary.GetType());
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//musics.xml";

                if (File.Exists(path))
                {
                    FileStream file = new FileStream(path, FileMode.Open);
                    musicLibrary = (MusicLibrary)reader.Deserialize(file);
                    foreach (Music m in musicLibrary.musics)
                        musicList.Add(m.Title);
                    file.Close();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void SerializeToXML()
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(musicLibrary.GetType());
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//musics.xml";

                FileStream file = File.Create(path);
                writer.Serialize(file, musicLibrary);
                file.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void LoadMyMusic()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string[] music = Directory.GetFiles(path, "*.mp3");

            foreach (string m in music)
            {
                Music song = new Music(m);
                if (!musicList.Contains(song.Title))
                {
                    musicList.Add(song.Title);
                    musicLibrary.musics.Add(song);
                }
            }
        }

        private void MediaPlayer_MediaOpened(object sender, EventArgs e)
        {
            btnPlayPause.IsEnabled = true;
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                MusicFullDuration.Text = mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss");
                fullDuration = mediaPlayer.NaturalDuration.TimeSpan;
                Slider_Music.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                btnPlayPause.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Debug.WriteLine(mediaPlayer.Source == null);
            //Debug.WriteLine("isDrag " + isDragging + " timeSpan " + mediaPlayer.NaturalDuration.HasTimeSpan);
            if (isDragging == false &&
                mediaPlayer.Source != null &&
                mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                Slider_Music.Value = mediaPlayer.Position.TotalSeconds;
            }
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
                        if (!musicList.Contains(music.Title))
                        {
                            musicLibrary.musics.Add(music);
                            musicList.Add(music.Title);
                            SerializeToXML();
                        }
                    }
                }
                All_Musics.Items.Refresh();
            }
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = ItemsControl.ContainerFromElement((DataGrid)sender, e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                Music music = row.Item as Music;
                index = ((DataGrid)sender).SelectedIndex;

                if (mediaPlayer.Source != null && btnPlayPause.Content == Resources["Play"])
                    btnPlayPause.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                if (File.Exists(music.PathUri.LocalPath))
                {
                    mediaPlayer.Open(music.PathUri);
                    Volume.Value = mediaPlayer.Volume;
                }
            }
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
                Debug.WriteLine("end of music");
                btnPlayPause.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                DataGridRow row = (DataGridRow)All_Musics.ItemContainerGenerator.ContainerFromIndex(index + 1);

                if (row != null)
                {
                    Music next = (Music)row.Item;

                    ++index;
                    All_Musics.SelectedIndex = index;
                    mediaPlayer.Open(next.PathUri);
                }
                else
                {
                    All_Musics.SelectedIndex = -1;
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
