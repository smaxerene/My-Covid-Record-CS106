﻿#pragma checksum "..\..\..\Views\Certificate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4CB5EFCC74CD9201B1056F9BC6A9E3DE1364F85E923944F0AA151051577F33EB"
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
using WpfApp1.Views;


namespace WpfApp1.Views {
    
    
    /// <summary>
    /// Certificate
    /// </summary>
    public partial class Certificate : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 219 "..\..\..\Views\Certificate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeButton;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\..\Views\Certificate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTermTextBox;
        
        #line default
        #line hidden
        
        
        #line 225 "..\..\..\Views\Certificate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 249 "..\..\..\Views\Certificate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowPopup;
        
        #line default
        #line hidden
        
        
        #line 258 "..\..\..\Views\Certificate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup myPopup;
        
        #line default
        #line hidden
        
        
        #line 307 "..\..\..\Views\Certificate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border myCertificate;
        
        #line default
        #line hidden
        
        
        #line 357 "..\..\..\Views\Certificate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 364 "..\..\..\Views\Certificate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Birthday;
        
        #line default
        #line hidden
        
        
        #line 373 "..\..\..\Views\Certificate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Address;
        
        #line default
        #line hidden
        
        
        #line 393 "..\..\..\Views\Certificate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RandomNumberTextBlock;
        
        #line default
        #line hidden
        
        
        #line 410 "..\..\..\Views\Certificate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid VaccineData;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/views/certificate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Certificate.xaml"
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
            this.HomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 219 "..\..\..\Views\Certificate.xaml"
            this.HomeButton.Click += new System.Windows.RoutedEventHandler(this.Home_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchTermTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btnShowPopup = ((System.Windows.Controls.Button)(target));
            
            #line 250 "..\..\..\Views\Certificate.xaml"
            this.btnShowPopup.Click += new System.Windows.RoutedEventHandler(this.btnShowPopup_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.myPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 6:
            
            #line 279 "..\..\..\Views\Certificate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PersonalDeets_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 280 "..\..\..\Views\Certificate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GenerateQR_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 281 "..\..\..\Views\Certificate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Certificate_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 282 "..\..\..\Views\Certificate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Notif_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 283 "..\..\..\Views\Certificate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Report_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 287 "..\..\..\Views\Certificate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnClosePopup_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 290 "..\..\..\Views\Certificate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnClosePopup_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.myCertificate = ((System.Windows.Controls.Border)(target));
            return;
            case 14:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.Birthday = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.Address = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.RandomNumberTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 18:
            this.VaccineData = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 19:
            
            #line 439 "..\..\..\Views\Certificate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 450 "..\..\..\Views\Certificate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 461 "..\..\..\Views\Certificate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditPage_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 473 "..\..\..\Views\Certificate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Download_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

