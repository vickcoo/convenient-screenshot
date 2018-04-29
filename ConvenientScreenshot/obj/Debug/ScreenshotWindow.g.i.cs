﻿#pragma checksum "..\..\ScreenshotWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BDCA242BBF1F752A5F7B50BB105A3BB787B00E4C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ConvenientScreenshot;
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


namespace ConvenientScreenshot {
    
    
    /// <summary>
    /// ScreenshotWindow
    /// </summary>
    public partial class ScreenshotWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border toolbar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid button_copyToClipboard;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid button_addToReviewAndHistory;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid button_abandonScreenshot;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border infobar;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock label_RectSize;
        
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
            System.Uri resourceLocater = new System.Uri("/ConvenientScreenshot;component/screenshotwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ScreenshotWindow.xaml"
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
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 10 "..\..\ScreenshotWindow.xaml"
            this.canvas.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_MouseDown);
            
            #line default
            #line hidden
            
            #line 10 "..\..\ScreenshotWindow.xaml"
            this.canvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.Canvas_MouseMove);
            
            #line default
            #line hidden
            
            #line 10 "..\..\ScreenshotWindow.xaml"
            this.canvas.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.toolbar = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.button_copyToClipboard = ((System.Windows.Controls.Grid)(target));
            
            #line 17 "..\..\ScreenshotWindow.xaml"
            this.button_copyToClipboard.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MouseDown_CopyToClipboard);
            
            #line default
            #line hidden
            
            #line 17 "..\..\ScreenshotWindow.xaml"
            this.button_copyToClipboard.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnter_FinishToolButton);
            
            #line default
            #line hidden
            
            #line 17 "..\..\ScreenshotWindow.xaml"
            this.button_copyToClipboard.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseLeave_FinishToolButton);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_addToReviewAndHistory = ((System.Windows.Controls.Grid)(target));
            
            #line 20 "..\..\ScreenshotWindow.xaml"
            this.button_addToReviewAndHistory.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MouseDown_AddToReviewAndHistory);
            
            #line default
            #line hidden
            
            #line 20 "..\..\ScreenshotWindow.xaml"
            this.button_addToReviewAndHistory.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnter_FinishToolButton);
            
            #line default
            #line hidden
            
            #line 20 "..\..\ScreenshotWindow.xaml"
            this.button_addToReviewAndHistory.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseLeave_FinishToolButton);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_abandonScreenshot = ((System.Windows.Controls.Grid)(target));
            
            #line 23 "..\..\ScreenshotWindow.xaml"
            this.button_abandonScreenshot.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MouseDown_AbandonScreenshot);
            
            #line default
            #line hidden
            
            #line 23 "..\..\ScreenshotWindow.xaml"
            this.button_abandonScreenshot.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnter_FinishToolButton);
            
            #line default
            #line hidden
            
            #line 23 "..\..\ScreenshotWindow.xaml"
            this.button_abandonScreenshot.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseLeave_FinishToolButton);
            
            #line default
            #line hidden
            return;
            case 6:
            this.infobar = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            
            #line 31 "..\..\ScreenshotWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MouseDown_CopyToClipboard);
            
            #line default
            #line hidden
            return;
            case 8:
            this.label_RectSize = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

