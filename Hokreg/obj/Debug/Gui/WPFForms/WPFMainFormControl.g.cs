﻿#pragma checksum "..\..\..\..\Gui\WPFForms\WPFMainFormControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "432C791A639AF037171185F2032A65D5"
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
using Uniso.InStat.Gui;
using Uniso.InStat.Gui.WPF_Forms;
using Uniso.InStat.Gui.WPF_Forms.MVVM;
using Uniso.InStat.StreamPlayer;


namespace Uniso.InStat.Gui.WPFForms {
    
    
    /// <summary>
    /// WPFMainFormControl
    /// </summary>
    public partial class WPFMainFormControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\..\Gui\WPFForms\WPFMainFormControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DirtyTimeTextBlock;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Gui\WPFForms\WPFMainFormControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Uniso.InStat.StreamPlayer.StreamVideoPlayerWpf streamVideoPlayerWpf;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Gui\WPFForms\WPFMainFormControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TestButton;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Gui\WPFForms\WPFMainFormControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider VideoRateSlider;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\Gui\WPFForms\WPFMainFormControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider VolumeSlider;
        
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
            System.Uri resourceLocater = new System.Uri("/hokreg;component/gui/wpfforms/wpfmainformcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Gui\WPFForms\WPFMainFormControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 33 "..\..\..\..\Gui\WPFForms\WPFMainFormControl.xaml"
            ((System.Windows.Controls.Grid)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.UIElement_OnKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 47 "..\..\..\..\Gui\WPFForms\WPFMainFormControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DirtyTimeTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.streamVideoPlayerWpf = ((Uniso.InStat.StreamPlayer.StreamVideoPlayerWpf)(target));
            return;
            case 5:
            this.TestButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Gui\WPFForms\WPFMainFormControl.xaml"
            this.TestButton.Click += new System.Windows.RoutedEventHandler(this.TestClickCommand);
            
            #line default
            #line hidden
            return;
            case 6:
            this.VideoRateSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 103 "..\..\..\..\Gui\WPFForms\WPFMainFormControl.xaml"
            this.VideoRateSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.VideoRateSlider_OnValueChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.VolumeSlider = ((System.Windows.Controls.Slider)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

