﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "724BFB6A3A95A799BFC88E2EC406805214400DFB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label user;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label appTitle;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label date;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ExistButton;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GameText;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CalcualtorImg;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ToDoImg;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CurrencyConverterImg;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CarGameAppImg;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image TicTacToeImg;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image UserManagementImg;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\MainWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/AppsCenter;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            return;
            case 2:
            this.appTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.date = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ExistButton = ((System.Windows.Controls.Image)(target));
            
            #line 66 "..\..\..\MainWindow.xaml"
            this.ExistButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ExistButton_MouseDown);
            
            #line default
            #line hidden
            
            #line 68 "..\..\..\MainWindow.xaml"
            this.ExistButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ExistButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 68 "..\..\..\MainWindow.xaml"
            this.ExistButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ExistButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GameText = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.CalcualtorImg = ((System.Windows.Controls.Image)(target));
            
            #line 82 "..\..\..\MainWindow.xaml"
            this.CalcualtorImg.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Image_MouseEnter);
            
            #line default
            #line hidden
            
            #line 82 "..\..\..\MainWindow.xaml"
            this.CalcualtorImg.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Image_MouseLeave);
            
            #line default
            #line hidden
            
            #line 82 "..\..\..\MainWindow.xaml"
            this.CalcualtorImg.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Calcualtor_MouseUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ToDoImg = ((System.Windows.Controls.Image)(target));
            
            #line 83 "..\..\..\MainWindow.xaml"
            this.ToDoImg.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Image_MouseEnter);
            
            #line default
            #line hidden
            
            #line 83 "..\..\..\MainWindow.xaml"
            this.ToDoImg.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Image_MouseLeave);
            
            #line default
            #line hidden
            
            #line 83 "..\..\..\MainWindow.xaml"
            this.ToDoImg.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ToDo_MouseUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CurrencyConverterImg = ((System.Windows.Controls.Image)(target));
            
            #line 84 "..\..\..\MainWindow.xaml"
            this.CurrencyConverterImg.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Image_MouseEnter);
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\MainWindow.xaml"
            this.CurrencyConverterImg.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Image_MouseLeave);
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\MainWindow.xaml"
            this.CurrencyConverterImg.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.CurrencyConverter_MouseUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CarGameAppImg = ((System.Windows.Controls.Image)(target));
            
            #line 85 "..\..\..\MainWindow.xaml"
            this.CarGameAppImg.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Image_MouseEnter);
            
            #line default
            #line hidden
            
            #line 85 "..\..\..\MainWindow.xaml"
            this.CarGameAppImg.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Image_MouseLeave);
            
            #line default
            #line hidden
            
            #line 85 "..\..\..\MainWindow.xaml"
            this.CarGameAppImg.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.CarGame_MouseUp);
            
            #line default
            #line hidden
            return;
            case 10:
            this.TicTacToeImg = ((System.Windows.Controls.Image)(target));
            
            #line 86 "..\..\..\MainWindow.xaml"
            this.TicTacToeImg.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Image_MouseEnter);
            
            #line default
            #line hidden
            
            #line 86 "..\..\..\MainWindow.xaml"
            this.TicTacToeImg.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Image_MouseLeave);
            
            #line default
            #line hidden
            
            #line 86 "..\..\..\MainWindow.xaml"
            this.TicTacToeImg.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TicTacToeGame_MouseUp);
            
            #line default
            #line hidden
            return;
            case 11:
            this.UserManagementImg = ((System.Windows.Controls.Image)(target));
            
            #line 87 "..\..\..\MainWindow.xaml"
            this.UserManagementImg.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Image_MouseEnter);
            
            #line default
            #line hidden
            
            #line 87 "..\..\..\MainWindow.xaml"
            this.UserManagementImg.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Image_MouseLeave);
            
            #line default
            #line hidden
            
            #line 87 "..\..\..\MainWindow.xaml"
            this.UserManagementImg.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.UserManagement_MouseUp);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Footer = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

