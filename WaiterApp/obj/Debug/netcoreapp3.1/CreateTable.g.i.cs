﻿#pragma checksum "..\..\..\CreateTable.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9B0C0A483BAD39C97582E8C1EC9DB998CB67F913"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using WaiterApp;


namespace WaiterApp {
    
    
    /// <summary>
    /// CreateTable
    /// </summary>
    public partial class CreateTable : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\CreateTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_czas_otwarcia;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\CreateTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_id_kelnera;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\CreateTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_nr_stolika;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\CreateTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_ilosc_gosci;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\CreateTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox priorytet;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\CreateTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button anuluj;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\CreateTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zatwierdz;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WaiterApp;component/createtable.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CreateTable.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lb_czas_otwarcia = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lb_id_kelnera = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.tb_nr_stolika = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\CreateTable.xaml"
            this.tb_nr_stolika.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Tb_check_input);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tb_ilosc_gosci = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\CreateTable.xaml"
            this.tb_ilosc_gosci.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Tb_check_input);
            
            #line default
            #line hidden
            return;
            case 5:
            this.priorytet = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.anuluj = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\CreateTable.xaml"
            this.anuluj.Click += new System.Windows.RoutedEventHandler(this.Click_anuluj);
            
            #line default
            #line hidden
            return;
            case 7:
            this.zatwierdz = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\CreateTable.xaml"
            this.zatwierdz.Click += new System.Windows.RoutedEventHandler(this.Click_zatwierdz);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

