﻿#pragma checksum "..\..\FormSeance.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C75B4A55EAD1D8E8F684A92EBA7C4ADFF3B99DBBB5EC0DFE65C77505F0DB6010"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GestionEcole;
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


namespace GestionEcole {
    
    
    /// <summary>
    /// FormSeance
    /// </summary>
    public partial class FormSeance : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\FormSeance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\FormSeance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox idPromo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\FormSeance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox idModule;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\FormSeance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox jour;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\FormSeance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox duree;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\FormSeance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nbseance;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\FormSeance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox notevalid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\FormSeance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\FormSeance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox heuredebut;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\FormSeance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox heurefin;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\FormSeance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ajouter;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\FormSeance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid;
        
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
            System.Uri resourceLocater = new System.Uri("/GestionEcole;component/formseance.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FormSeance.xaml"
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
            this.save = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\FormSeance.xaml"
            this.save.Click += new System.Windows.RoutedEventHandler(this.save_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.idPromo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\FormSeance.xaml"
            this.idPromo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.idPromo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.idModule = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\FormSeance.xaml"
            this.idModule.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.idModule_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.jour = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.duree = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.nbseance = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.notevalid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.date = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.heuredebut = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.heurefin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.ajouter = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\FormSeance.xaml"
            this.ajouter.Click += new System.Windows.RoutedEventHandler(this.ajouter_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.datagrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

