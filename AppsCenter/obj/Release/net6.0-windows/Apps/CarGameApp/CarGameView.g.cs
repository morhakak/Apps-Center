﻿#pragma checksum "..\..\..\..\..\Apps\CarGameApp\CarGameView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "613938CB2DDBCF6CE3A07B9B62C30E8A0FBF64D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AppsCenter.Apps.CarGameApp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace AppsCenter.Apps.CarGameApp {
    
    
    /// <summary>
    /// CarGameView
    /// </summary>
    public partial class CarGameView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\Apps\CarGameApp\CarGameView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement BackgroundVideo;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\Apps\CarGameApp\CarGameView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas gameCanvas;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Apps\CarGameApp\CarGameView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image playerCarImage;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\Apps\CarGameApp\CarGameView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock score;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AppsCenter;component/apps/cargameapp/cargameview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Apps\CarGameApp\CarGameView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BackgroundVideo = ((System.Windows.Controls.MediaElement)(target));
            
            #line 13 "..\..\..\..\..\Apps\CarGameApp\CarGameView.xaml"
            this.BackgroundVideo.MediaEnded += new System.Windows.RoutedEventHandler(this.BackgroundVideo_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gameCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.playerCarImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.score = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

