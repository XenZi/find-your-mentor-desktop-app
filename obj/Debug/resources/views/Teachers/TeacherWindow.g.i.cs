﻿#pragma checksum "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0042D5500F60893A9175EE8750F535A6ADBC469C3320E81821D49DE37BBD7CC7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SR38_2021_POP2022.resources.views.Teachers;
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


namespace SR38_2021_POP2022.resources.views.Teachers {
    
    
    /// <summary>
    /// TeacherWindow
    /// </summary>
    public partial class TeacherWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker sessionDate;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataSessions;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreateSession;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteSession;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewPersonalInfo;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewStudent;
        
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
            System.Uri resourceLocater = new System.Uri("/SR38-2021-POP2022;component/resources/views/teachers/teacherwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml"
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
            this.sessionDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 11 "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml"
            this.sessionDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.sessionDate_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataSessions = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.btnCreateSession = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml"
            this.btnCreateSession.Click += new System.Windows.RoutedEventHandler(this.btnCreateSession_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDeleteSession = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml"
            this.btnDeleteSession.Click += new System.Windows.RoutedEventHandler(this.btnDeleteSession_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnViewPersonalInfo = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml"
            this.btnViewPersonalInfo.Click += new System.Windows.RoutedEventHandler(this.btnViewPersonalInfo_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnViewStudent = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\..\resources\views\Teachers\TeacherWindow.xaml"
            this.btnViewStudent.Click += new System.Windows.RoutedEventHandler(this.btnViewStudent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

