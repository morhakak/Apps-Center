﻿#pragma checksum "..\..\..\..\..\Apps\CurrencyConverter\CurrencyConverterView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FA9F4C8EA6F8FB74E821B64ED470618BF58605AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AppsCenter.Apps.CurrencyConverter;
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


namespace AppsCenter.Apps.CurrencyConverter {
    
    
    /// <summary>
    /// CurrencyConverterView
    /// </summary>
    public partial class CurrencyConverterView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\Apps\CurrencyConverter\CurrencyConverterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AmountTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\Apps\CurrencyConverter\CurrencyConverterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FromCurrencyComboBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Apps\CurrencyConverter\CurrencyConverterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ToCurrencyComboBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Apps\CurrencyConverter\CurrencyConverterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConvert;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Apps\CurrencyConverter\CurrencyConverterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtResult;
        
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
            System.Uri resourceLocater = new System.Uri("/AppsCenter;V1.0.0.0;component/apps/currencyconverter/currencyconverterview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Apps\CurrencyConverter\CurrencyConverterView.xaml"
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
            this.AmountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.FromCurrencyComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ToCurrencyComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.btnConvert = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\Apps\CurrencyConverter\CurrencyConverterView.xaml"
            this.btnConvert.Click += new System.Windows.RoutedEventHandler(this.BtnConvert_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtResult = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

