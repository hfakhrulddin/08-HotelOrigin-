﻿#pragma checksum "..\..\AddReservationWin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "400C386F4E411569097F3AC67C710452"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HotelOrigin;
using HotelOrigin.Core.Repository;
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


namespace HotelOrigin {
    
    
    /// <summary>
    /// AddReservationWin
    /// </summary>
    public partial class AddReservationWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\AddReservationWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubmitReservation;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AddReservationWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox reservation_id_txb;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddReservationWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Customer_cbo;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddReservationWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Room_cbo;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddReservationWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddReservationWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddReservationWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddReservationWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddReservationWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label4;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddReservationWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker ceckin_databox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddReservationWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker ceckout_databox;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelOrigin;component/addreservationwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddReservationWin.xaml"
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
            
            #line 9 "..\..\AddReservationWin.xaml"
            ((HotelOrigin.AddReservationWin)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SubmitReservation = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\AddReservationWin.xaml"
            this.SubmitReservation.Click += new System.Windows.RoutedEventHandler(this.SubmitReservation_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.reservation_id_txb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Customer_cbo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Room_cbo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.label3 = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.label4 = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.ceckin_databox = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 12:
            this.ceckout_databox = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

