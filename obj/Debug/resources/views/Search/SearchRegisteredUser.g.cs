﻿#pragma checksum "..\..\..\..\..\resources\views\Search\SearchRegisteredUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F7F09BF08919EA2115AC9111B86678DFA175555EDA7C76680A78455548CDAC74"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SR38_2021_POP2022.resources.views.Search;
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


namespace SR38_2021_POP2022.resources.views.Search {
    
    
    /// <summary>
    /// SearchRegisteredUser
    /// </summary>
    public partial class SearchRegisteredUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\resources\views\Search\SearchRegisteredUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataUsers;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\resources\views\Search\SearchRegisteredUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFirstName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\resources\views\Search\SearchRegisteredUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLastName;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\resources\views\Search\SearchRegisteredUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMail;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\resources\views\Search\SearchRegisteredUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbType;
        
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
            System.Uri resourceLocater = new System.Uri("/SR38-2021-POP2022;component/resources/views/search/searchregistereduser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\resources\views\Search\SearchRegisteredUser.xaml"
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
            this.dataUsers = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.txtFirstName = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\..\..\resources\views\Search\SearchRegisteredUser.xaml"
            this.txtFirstName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtFirstName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtLastName = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\..\..\resources\views\Search\SearchRegisteredUser.xaml"
            this.txtLastName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtLastName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtMail = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\..\..\resources\views\Search\SearchRegisteredUser.xaml"
            this.txtMail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtMail_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmbType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\..\..\resources\views\Search\SearchRegisteredUser.xaml"
            this.cmbType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

