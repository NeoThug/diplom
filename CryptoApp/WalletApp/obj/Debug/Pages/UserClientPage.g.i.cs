﻿#pragma checksum "..\..\..\Pages\UserClientPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "136C55CEC8DD0BBB0CD41D351C482D1C8FC58400EFF6F35DE2D9B9B7318E3DDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WalletApp.Pages;


namespace WalletApp.Pages {
    
    
    /// <summary>
    /// UserClientPage
    /// </summary>
    public partial class UserClientPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\UserClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboPrice;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\UserClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbSearchNick;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\UserClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LWUsers;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Pages\UserClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
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
            System.Uri resourceLocater = new System.Uri("/WalletApp;component/pages/userclientpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\UserClientPage.xaml"
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
            
            #line 9 "..\..\..\Pages\UserClientPage.xaml"
            ((WalletApp.Pages.UserClientPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboPrice = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\Pages\UserClientPage.xaml"
            this.ComboPrice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboPrice_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TbSearchNick = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\Pages\UserClientPage.xaml"
            this.TbSearchNick.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbSearchNick_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LWUsers = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\Pages\UserClientPage.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
