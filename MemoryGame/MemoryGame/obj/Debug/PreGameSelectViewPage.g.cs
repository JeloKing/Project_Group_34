﻿#pragma checksum "..\..\PreGameSelectViewPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2064E872C02B519823CB9CEBD0F004EA2E798C35"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MemoryGame;
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


namespace MemoryGame {
    
    
    /// <summary>
    /// PreGameSelectViewPage
    /// </summary>
    public partial class PreGameSelectViewPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\PreGameSelectViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PreGameSelectViewPageMainGrid;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\PreGameSelectViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PlayerNames;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\PreGameSelectViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox player1;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\PreGameSelectViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox player2;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\PreGameSelectViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridSelect;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\PreGameSelectViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PreGameSelectView;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\PreGameSelectViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SelectedTheme;
        
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
            System.Uri resourceLocater = new System.Uri("/MemoryGame;component/pregameselectviewpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PreGameSelectViewPage.xaml"
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
            this.PreGameSelectViewPageMainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.PlayerNames = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.player1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.player2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.GridSelect = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            
            #line 36 "..\..\PreGameSelectViewPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Play_Game_Grid4);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 44 "..\..\PreGameSelectViewPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Play_Game_Grid5);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 52 "..\..\PreGameSelectViewPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Play_Game_Grid6);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PreGameSelectView = ((System.Windows.Controls.Frame)(target));
            return;
            case 10:
            this.SelectedTheme = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

