﻿#pragma checksum "..\..\Window1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A252CD96CA0A555C581A9DC9DD01C82A16A6CDDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FilaPedido;
using Microsoft.Windows.Themes;
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


namespace FilaPedido {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboItem;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEntrada;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPreparacao;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSaida;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border gridItem;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgItem;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem opNovo;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem opPreparar;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem opExibir;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Pedido;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Descricao;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Quantidade;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Tipo;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFechar;
        
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
            System.Uri resourceLocater = new System.Uri("/FilaPedido;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
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
            
            #line 9 "..\..\Window1.xaml"
            ((FilaPedido.Window1)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboItem = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.lblEntrada = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblPreparacao = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblSaida = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.gridItem = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.dgItem = ((System.Windows.Controls.DataGrid)(target));
            
            #line 32 "..\..\Window1.xaml"
            this.dgItem.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DgItem_LoadingRow);
            
            #line default
            #line hidden
            
            #line 32 "..\..\Window1.xaml"
            this.dgItem.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgItem_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 34 "..\..\Window1.xaml"
            ((System.Windows.Controls.ContextMenu)(target)).Opened += new System.Windows.RoutedEventHandler(this.ContextMenu_Opened);
            
            #line default
            #line hidden
            return;
            case 9:
            this.opNovo = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 10:
            this.opPreparar = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 11:
            this.opExibir = ((System.Windows.Controls.MenuItem)(target));
            
            #line 37 "..\..\Window1.xaml"
            this.opExibir.Click += new System.Windows.RoutedEventHandler(this.OpExibir_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Pedido = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 13:
            this.Descricao = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 14:
            this.Quantidade = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 15:
            this.Tipo = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 16:
            this.btnFechar = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\Window1.xaml"
            this.btnFechar.Click += new System.Windows.RoutedEventHandler(this.BtnFechar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

