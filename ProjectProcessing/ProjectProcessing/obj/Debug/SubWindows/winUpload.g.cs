﻿#pragma checksum "..\..\..\SubWindows\winUpload.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "326A62834B6E9D211A5D885CCFECDC49"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using ProjectProcessing.SubWindows;
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


namespace ProjectProcessing.SubWindows {
    
    
    /// <summary>
    /// winUpload
    /// </summary>
    public partial class winUpload : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\SubWindows\winUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labSelect;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\SubWindows\winUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labProcess;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\SubWindows\winUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labUpload;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\SubWindows\winUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butUpload;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\SubWindows\winUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butCancel;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\SubWindows\winUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butRestart;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\SubWindows\winUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labSelectStatus;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\SubWindows\winUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labProcessStatus;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\SubWindows\winUpload.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labUploadStatus;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectProcessing;component/subwindows/winupload.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SubWindows\winUpload.xaml"
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
            
            #line 9 "..\..\..\SubWindows\winUpload.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.labSelect = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.labProcess = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.labUpload = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.butUpload = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\SubWindows\winUpload.xaml"
            this.butUpload.Click += new System.Windows.RoutedEventHandler(this.butUpload_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.butCancel = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\SubWindows\winUpload.xaml"
            this.butCancel.Click += new System.Windows.RoutedEventHandler(this.butCancel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.butRestart = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\SubWindows\winUpload.xaml"
            this.butRestart.Click += new System.Windows.RoutedEventHandler(this.butRestart_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.labSelectStatus = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.labProcessStatus = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.labUploadStatus = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

