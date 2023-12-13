﻿#pragma checksum "..\..\..\AppsPresentationView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "225FABB99A0381E7E8C4EB07CC54E9FF31C8F685"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AppsCenter;
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


namespace AppsCenter {
    
    
    /// <summary>
    /// AppsPresentationView
    /// </summary>
    public partial class AppsPresentationView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\AppsPresentationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label user;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\AppsPresentationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label appTitle;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\AppsPresentationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label date;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\AppsPresentationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image appImage;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\AppsPresentationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock appDescription;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\AppsPresentationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock technologies;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\AppsPresentationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Footer;
        
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
            System.Uri resourceLocater = new System.Uri("/AppsCenter;component/appspresentationview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AppsPresentationView.xaml"
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
            this.user = ((System.Windows.Controls.Label)(target));
            
            #line 37 "..\..\..\AppsPresentationView.xaml"
            this.user.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.GoBack);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\AppsPresentationView.xaml"
            this.user.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Mouse_Enter);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\AppsPresentationView.xaml"
            this.user.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Mouse_Leave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.appTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.date = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.appImage = ((System.Windows.Controls.Image)(target));
            
            #line 82 "..\..\..\AppsPresentationView.xaml"
            this.appImage.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OpenApp);
            
            #line default
            #line hidden
            
            #line 83 "..\..\..\AppsPresentationView.xaml"
            this.appImage.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Mouse_Enter);
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\AppsPresentationView.xaml"
            this.appImage.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Mouse_Leave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.appDescription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.technologies = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 111 "..\..\..\AppsPresentationView.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.GoBack);
            
            #line default
            #line hidden
            
            #line 113 "..\..\..\AppsPresentationView.xaml"
            ((System.Windows.Controls.Label)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Mouse_Enter);
            
            #line default
            #line hidden
            
            #line 114 "..\..\..\AppsPresentationView.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Mouse_Leave);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 121 "..\..\..\AppsPresentationView.xaml"
            ((System.Windows.Controls.Label)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Mouse_Enter);
            
            #line default
            #line hidden
            
            #line 122 "..\..\..\AppsPresentationView.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Mouse_Leave);
            
            #line default
            #line hidden
            
            #line 124 "..\..\..\AppsPresentationView.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OpenApp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Footer = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

