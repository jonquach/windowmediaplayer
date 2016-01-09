using FirstFloor.ModernUI.Windows;
using Microsoft.Win32;
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
using FirstFloor.ModernUI.Windows.Navigation;
using System.Runtime.InteropServices;
using System.Timers;
using FirstFloor.ModernUI.Presentation;
using System.IO;
using System.Xml.Serialization;

namespace WindowMediaPlayer
{
    /// <summary>
    /// Interaction logic for VideoPlayer.xaml
    /// </summary>
    public partial class VideoPlayer : UserControl
    {
        private bool isDragging = false;
        private TimeSpan fullDuration;
        private List<string> listVid = new List<string>();
        private DispatcherTimer timer = new DispatcherTimer();
        public VideoLibrary videoLibrary = new VideoLibrary();
        
        public VideoPlayer()
        {
            InitializeComponent();
            DeserializeXML();
            LoadMyVideos();
            All_Videos.ItemsSource = videoLibrary.videos;
            btnPlayPause.IsEnabled = false;
            mediaElement.Play();
            mediaElement.Stop();
            mediaElement.MediaOpened += MediaElement_MediaOpened;

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
       
        private void LoadMyVideos()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            string[] videos = Directory.GetFiles(path, "*.avi").Union(Directory.GetFiles(path, "*.wmv")).Union(Directory.GetFiles(path, "*.mp4")).ToArray();

            foreach (string v in videos)
            {
                Videos vid = new Videos(v);
                if (!listVid.Contains(vid.Title))
                {
                    listVid.Add(vid.Title);
                    videoLibrary.videos.Add(vid);
                }
            }
        }

        private void DeserializeXML()
        {
            try
            {
                XmlSerializer reader = new XmlSerializer(videoLibrary.GetType());
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//videos.xml";

                if (File.Exists(path))
                {
                    FileStream file = new FileStream(path, FileMode.Open);
                    videoLibrary = (VideoLibrary)reader.Deserialize(file);
                    foreach (Videos v in videoLibrary.videos)
                    {
                        listVid.Add(v.Title);
                    }
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
                XmlSerializer writer = new XmlSerializer(videoLibrary.GetType());
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//videos.xml";

                FileStream file = File.Create(path);
                writer.Serialize(file, videoLibrary);
                file.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void MediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            btnPlayPause.IsEnabled = true;
            if (mediaElement.NaturalDuration.HasTimeSpan)
            {
                VideoFullTimer.Text = mediaElement.NaturalDuration.TimeSpan.ToString(@"hh\:mm\:ss");
                fullDuration = mediaElement.NaturalDuration.TimeSpan;
                btnPlayPause.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
        }

        private void HandleMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
                mediaElement.Volume += 0.1;
            else
                mediaElement.Volume -= 0.1;
        }

        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) // Spacebar press
            {
                btnPlayPause.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Debug.WriteLine(mediaElement.Source == null);
            //Debug.WriteLine("isDrag " + isDragging + " timeSpan " + mediaElement.NaturalDuration.HasTimeSpan);
            if (isDragging == false &&
                mediaElement.Source != null &&
                mediaElement.NaturalDuration.HasTimeSpan)
            {
                SliderProgress.Minimum = 0;
                SliderProgress.Maximum = mediaElement.NaturalDuration.TimeSpan.TotalSeconds;
                SliderProgress.Value = mediaElement.Position.TotalSeconds;
            }
        }

        private void Slider_DragStarted(object sender, DragStartedEventArgs e)
        {
            isDragging = true;
        }

        private void Slider_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            isDragging = false;
            mediaElement.Position = TimeSpan.FromSeconds(SliderProgress.Value);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TextTimer.Text = TimeSpan.FromSeconds(SliderProgress.Value).ToString(@"hh\:mm\:ss");

            if (mediaElement.Position.TotalSeconds == fullDuration.TotalSeconds)
            {
                btnPlayPause.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Video Files (*.avi;*.wmv;*.mp4)|*.avi;*.wmv;*.mp4|All Files (*.*)|*.*";

            bool? result = fileDialog.ShowDialog();

            if (result == true && !listVid.Contains(fileDialog.FileName))
            {
                mediaElement.Source = new Uri(fileDialog.FileName);
                listVid.Add(fileDialog.FileName);
                btnPlayPause.IsEnabled = true;
                Videos video = new Videos(fileDialog.FileName);
                videoLibrary.videos.Add(video);
                All_Videos.Items.Refresh();
                SerializeToXML();
            }
        }

        private void btnPlayPause_Click(object sender, RoutedEventArgs e)
        {
            if (btnPlayPause.Content == this.Resources["Play"])
            {
                btnPlayPause.Content = this.Resources["Pause"];
                mediaElement.Play();
            }
            else
            {
                btnPlayPause.Content = this.Resources["Play"];
                mediaElement.Pause();
            }
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = ItemsControl.ContainerFromElement((DataGrid)sender, e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                Videos video = (Videos)row.Item;

                if (mediaElement.Source != null && btnPlayPause.Content == Resources["Play"])
                    btnPlayPause.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                if (File.Exists(video.PathUri.LocalPath))
                {
                    mediaElement.Position = TimeSpan.FromSeconds(0);
                    SliderProgress.Value = 0;
                    mediaElement.Source = video.PathUri;
                }
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
            this.MouseWheel -= HandleMouseWheel;
            this.PreviewKeyDown -= HandleKeyPress;
            this.Focusable = false;
        }
    }
}
