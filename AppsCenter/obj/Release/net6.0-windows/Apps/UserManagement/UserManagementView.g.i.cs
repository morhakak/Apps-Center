﻿#pragma checksum "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4A4B01C09D9582CBE09E9791FB3685DF439A5959"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AppsCenter.Apps.UserManagement;
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


namespace AppsCenter.Apps.UserManagement {
    
    
    /// <summary>
    /// UserManagementView
    /// </summary>
    public partial class UserManagementView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MainContainer;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_Title;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Input_UserName;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Input_Email;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid1;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Add;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Update;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Delete;
        
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
            System.Uri resourceLocater = new System.Uri("/AppsCenter;component/apps/usermanagement/usermanagementview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
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
            this.MainContainer = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.Label_Title = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Input_UserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Input_Email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DataGrid1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 59 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
            this.DataGrid1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btn_Add = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
            this.Btn_Add.Click += new System.Windows.RoutedEventHandler(this.Btn_Add_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Btn_Update = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
            this.Btn_Update.Click += new System.Windows.RoutedEventHandler(this.Btn_Update_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Btn_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\..\..\Apps\UserManagement\UserManagementView.xaml"
            this.Btn_Delete.Click += new System.Windows.RoutedEventHandler(this.Btn_Remove_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

