﻿#pragma checksum "..\..\..\QuestionWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B79AF0DAF99BADA2AA868FB7A8EE685B6EDAE4C3"
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
using _2ora;


namespace _2ora {
    
    
    /// <summary>
    /// QuestionWindow
    /// </summary>
    public partial class QuestionWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\QuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sp;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\QuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l_timer;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\QuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l_question;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\QuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_answer_1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\QuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_answer_2;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\QuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_answer_3;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\QuestionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_answer_4;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuizApp;component/questionwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\QuestionWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\QuestionWindow.xaml"
            ((_2ora.QuestionWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\QuestionWindow.xaml"
            ((_2ora.QuestionWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sp = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.l_timer = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.l_question = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.b_answer_1 = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\QuestionWindow.xaml"
            this.b_answer_1.Click += new System.Windows.RoutedEventHandler(this.b_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.b_answer_2 = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\QuestionWindow.xaml"
            this.b_answer_2.Click += new System.Windows.RoutedEventHandler(this.b_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.b_answer_3 = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\QuestionWindow.xaml"
            this.b_answer_3.Click += new System.Windows.RoutedEventHandler(this.b_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.b_answer_4 = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\QuestionWindow.xaml"
            this.b_answer_4.Click += new System.Windows.RoutedEventHandler(this.b_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

