﻿#pragma checksum "..\..\..\Tabs\MusicTab.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E9D9049E8705E59CB9B6D705689555C7"
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
    /// MusicTab
    /// </summary>
    public partial class MusicTab : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\Tabs\MusicTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid All_Musics;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Tabs\MusicTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBackward;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Tabs\MusicTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlayPause;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Tabs\MusicTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnForward;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Tabs\MusicTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar Volume;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Tabs\MusicTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoop;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Tabs\MusicTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MusicTimer;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Tabs\MusicTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MusicFullDuration;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Tabs\MusicTab.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WindowMediaPlayer;component/tabs/musictab.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Tabs\MusicTab.xaml"
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
            
            #line 8 "..\..\..\Tabs\MusicTab.xaml"
            ((WindowMediaPlayer.Tabs.MusicTab)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Tabs\MusicTab.xaml"
            ((WindowMediaPlayer.Tabs.MusicTab)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.UserControl_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 30 "..\..\..\Tabs\MusicTab.xaml"
            ((FirstFloor.ModernUI.Windows.Controls.ModernButton)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddMusics);
            
            #line default
            #line hidden
            return;
            case 3:
            this.All_Musics = ((System.Windows.Controls.DataGrid)(target));
            
            #line 34 "..\..\..\Tabs\MusicTab.xaml"
            this.All_Musics.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Row_DoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnBackward = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Tabs\MusicTab.xaml"
            this.btnBackward.Click += new System.Windows.RoutedEventHandler(this.btnBackward_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnPlayPause = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Tabs\MusicTab.xaml"
            this.btnPlayPause.Click += new System.Windows.RoutedEventHandler(this.btnPlayPause_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnForward = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Tabs\MusicTab.xaml"
            this.btnForward.Click += new System.Windows.RoutedEventHandler(this.btnForward_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Volume = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 8:
            this.btnLoop = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Tabs\MusicTab.xaml"
            this.btnLoop.Click += new System.Windows.RoutedEventHandler(this.btnLoop_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MusicTimer = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.MusicFullDuration = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.Slider_Music = ((System.Windows.Controls.Slider)(target));
            
            #line 67 "..\..\..\Tabs\MusicTab.xaml"
            this.Slider_Music.AddHandler(System.Windows.Controls.Primitives.Thumb.DragStartedEvent, new System.Windows.Controls.Primitives.DragStartedEventHandler(this.Slider_DragStarted));
            
            #line default
            #line hidden
            
            #line 67 "..\..\..\Tabs\MusicTab.xaml"
            this.Slider_Music.AddHandler(System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.Slider_DragCompleted));
            
            #line default
            #line hidden
            
            #line 67 "..\..\..\Tabs\MusicTab.xaml"
            this.Slider_Music.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
