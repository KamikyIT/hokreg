﻿#pragma checksum "..\..\..\..\..\Gui\WPFForms\WPFPlayer\StreamVideoPlayerWpf.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "03674E6EB4F63BAD130D50C0FC3BB18A"
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
using System.Windows.Forms.Integration;
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


namespace Uniso.InStat.StreamPlayer {
    
    
    /// <summary>
    /// StreamVideoPlayerWpf
    /// </summary>
    public partial class StreamVideoPlayerWpf : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\..\Gui\WPFForms\WPFPlayer\StreamVideoPlayerWpf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle blackRect;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\Gui\WPFForms\WPFPlayer\StreamVideoPlayerWpf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaElement1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Gui\WPFForms\WPFPlayer\StreamVideoPlayerWpf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaElement2;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Gui\WPFForms\WPFPlayer\StreamVideoPlayerWpf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelError;
        
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
            System.Uri resourceLocater = new System.Uri("/hokreg;component/gui/wpfforms/wpfplayer/streamvideoplayerwpf.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Gui\WPFForms\WPFPlayer\StreamVideoPlayerWpf.xaml"
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
            this.blackRect = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 33 "..\..\..\..\..\Gui\WPFForms\WPFPlayer\StreamVideoPlayerWpf.xaml"
            this.blackRect.SizeChanged += new System.Windows.SizeChangedEventHandler(this.blackRect_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mediaElement1 = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 3:
            this.mediaElement2 = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 4:
            this.labelError = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

