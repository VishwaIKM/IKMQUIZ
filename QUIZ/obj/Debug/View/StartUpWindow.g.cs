﻿#pragma checksum "..\..\..\View\StartUpWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EFD2E142F543610B550BB9422127C1E7C9C582C6739155E25135E08519D144F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using QUIZ.View;
using QUIZ.ViewModel;
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


namespace QUIZ.View {
    
    
    /// <summary>
    /// StartUpWindow
    /// </summary>
    public partial class StartUpWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\View\StartUpWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_CandidateLogin;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\View\StartUpWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AdminLogin;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\View\StartUpWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit_Btn;
        
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
            System.Uri resourceLocater = new System.Uri("/QUIZ;component/view/startupwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\StartUpWindow.xaml"
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
            this.btn_CandidateLogin = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\View\StartUpWindow.xaml"
            this.btn_CandidateLogin.Click += new System.Windows.RoutedEventHandler(this.btn_CandidateLogin_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_AdminLogin = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\View\StartUpWindow.xaml"
            this.btn_AdminLogin.Click += new System.Windows.RoutedEventHandler(this.btn_AdminLogin_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Exit_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\View\StartUpWindow.xaml"
            this.Exit_Btn.Click += new System.Windows.RoutedEventHandler(this.Exit_Btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
