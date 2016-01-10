﻿#pragma checksum "..\..\..\Tabs\PlaylistTab.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "413E5BFE26714CEBFE9BF199E51FB10F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace WindowMediaPlayer.Tabs {
    
    
    /// <summary>
    /// PlaylistTab
    /// </summary>
    public partial class PlaylistTab : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\Tabs\PlaylistTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid All_Playlists;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Tabs\PlaylistTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Playlist_Content;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Tabs\PlaylistTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBackward;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Tabs\PlaylistTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlayPause;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Tabs\PlaylistTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnForward;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Tabs\PlaylistTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar Volume;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Tabs\PlaylistTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoop;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Tabs\PlaylistTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MusicTimer;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Tabs\PlaylistTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MusicFullDuration;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Tabs\PlaylistTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Slider_Music;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WindowMediaPlayer;component/tabs/playlisttab.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Tabs\PlaylistTab.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\Tabs\PlaylistTab.xaml"
            ((WindowMediaPlayer.Tabs.PlaylistTab)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Tabs\PlaylistTab.xaml"
            ((WindowMediaPlayer.Tabs.PlaylistTab)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.UserControl_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 30 "..\..\..\Tabs\PlaylistTab.xaml"
            ((FirstFloor.ModernUI.Windows.Controls.ModernButton)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddPlaylist);
            
            #line default
            #line hidden
            return;
            case 3:
            this.All_Playlists = ((System.Windows.Controls.DataGrid)(target));
            
            #line 34 "..\..\..\Tabs\PlaylistTab.xaml"
            this.All_Playlists.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Row_DoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Playlist_Content = ((System.Windows.Controls.DataGrid)(target));
            
            #line 39 "..\..\..\Tabs\PlaylistTab.xaml"
            this.Playlist_Content.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Music_DoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnBackward = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Tabs\PlaylistTab.xaml"
            this.btnBackward.Click += new System.Windows.RoutedEventHandler(this.btnBackward_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnPlayPause = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Tabs\PlaylistTab.xaml"
            this.btnPlayPause.Click += new System.Windows.RoutedEventHandler(this.btnPlayPause_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnForward = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Tabs\PlaylistTab.xaml"
            this.btnForward.Click += new System.Windows.RoutedEventHandler(this.btnForward_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Volume = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 9:
            this.btnLoop = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Tabs\PlaylistTab.xaml"
            this.btnLoop.Click += new System.Windows.RoutedEventHandler(this.btnLoop_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MusicTimer = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.MusicFullDuration = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.Slider_Music = ((System.Windows.Controls.Slider)(target));
            
            #line 72 "..\..\..\Tabs\PlaylistTab.xaml"
            this.Slider_Music.AddHandler(System.Windows.Controls.Primitives.Thumb.DragStartedEvent, new System.Windows.Controls.Primitives.DragStartedEventHandler(this.Slider_DragStarted));
            
            #line default
            #line hidden
            
            #line 72 "..\..\..\Tabs\PlaylistTab.xaml"
            this.Slider_Music.AddHandler(System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.Slider_DragCompleted));
            
            #line default
            #line hidden
            
            #line 72 "..\..\..\Tabs\PlaylistTab.xaml"
            this.Slider_Music.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

