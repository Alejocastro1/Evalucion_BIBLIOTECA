// Updated by XamlIntelliSenseFileGenerator 06/06/2024 07:28:19 p. m.
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "937E4D838E086340FA846459ED049A41AE0F4853"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace BibliotecaApp
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 55 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvLibros;

#line default
#line hidden


#line 64 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBuscarTitulo;

#line default
#line hidden


#line 76 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvUsuarios;

#line default
#line hidden


#line 85 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBuscarNombreUsuario;

#line default
#line hidden


#line 101 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvPrestamos;

#line default
#line hidden


#line 112 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBuscarPrestamoLibro;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BibliotecaApp;V1.0.0.0;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.lvLibros = ((System.Windows.Controls.ListView)(target));
                    return;
                case 2:
                    this.txtBuscarTitulo = ((System.Windows.Controls.TextBox)(target));

#line 64 "..\..\..\MainWindow.xaml"
                    this.txtBuscarTitulo.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);

#line default
#line hidden

#line 64 "..\..\..\MainWindow.xaml"
                    this.txtBuscarTitulo.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);

#line default
#line hidden
                    return;
                case 3:
                    this.txtBuscarAutor = ((System.Windows.Controls.TextBox)(target));

#line 66 "..\..\..\MainWindow.xaml"
                    this.txtBuscarAutor.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);

#line default
#line hidden

#line 66 "..\..\..\MainWindow.xaml"
                    this.txtBuscarAutor.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);

#line default
#line hidden
                    return;
                case 4:
                    this.btnCapturarLibro = ((System.Windows.Controls.Button)(target));

#line 67 "..\..\..\MainWindow.xaml"
                    this.btnCapturarLibro.Click += new System.Windows.RoutedEventHandler(this.btnCapturarLibro_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.btnListarLibro = ((System.Windows.Controls.Button)(target));

#line 68 "..\..\..\MainWindow.xaml"
                    this.btnListarLibro.Click += new System.Windows.RoutedEventHandler(this.btnListarLibro_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.btnBuscarLibro = ((System.Windows.Controls.Button)(target));

#line 71 "..\..\..\MainWindow.xaml"
                    this.btnBuscarLibro.Click += new System.Windows.RoutedEventHandler(this.btnBuscarLibro_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.lvUsuarios = ((System.Windows.Controls.ListView)(target));
                    return;
                case 8:
                    this.txtBuscarNombreUsuario = ((System.Windows.Controls.TextBox)(target));

#line 85 "..\..\..\MainWindow.xaml"
                    this.txtBuscarNombreUsuario.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);

#line default
#line hidden

#line 85 "..\..\..\MainWindow.xaml"
                    this.txtBuscarNombreUsuario.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);

#line default
#line hidden
                    return;
                case 9:
                    this.txtBuscarEmailUsuario = ((System.Windows.Controls.TextBox)(target));

#line 87 "..\..\..\MainWindow.xaml"
                    this.txtBuscarEmailUsuario.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);

#line default
#line hidden

#line 87 "..\..\..\MainWindow.xaml"
                    this.txtBuscarEmailUsuario.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);

#line default
#line hidden
                    return;
                case 10:
                    this.btnCapturarUsuario = ((System.Windows.Controls.Button)(target));

#line 88 "..\..\..\MainWindow.xaml"
                    this.btnCapturarUsuario.Click += new System.Windows.RoutedEventHandler(this.btnCapturarUsuario_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.btnListarUsuario = ((System.Windows.Controls.Button)(target));

#line 89 "..\..\..\MainWindow.xaml"
                    this.btnListarUsuario.Click += new System.Windows.RoutedEventHandler(this.btnListarUsuario_Click);

#line default
#line hidden
                    return;
                case 12:
                    this.btnBuscarUsuario = ((System.Windows.Controls.Button)(target));

#line 91 "..\..\..\MainWindow.xaml"
                    this.btnBuscarUsuario.Click += new System.Windows.RoutedEventHandler(this.btnBuscarUsuario_Click);

#line default
#line hidden
                    return;
                case 13:
                    this.lvPrestamos = ((System.Windows.Controls.ListView)(target));
                    return;
                case 14:
                    this.txtBuscarPrestamoLibro = ((System.Windows.Controls.TextBox)(target));

#line 112 "..\..\..\MainWindow.xaml"
                    this.txtBuscarPrestamoLibro.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);

#line default
#line hidden

#line 112 "..\..\..\MainWindow.xaml"
                    this.txtBuscarPrestamoLibro.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);

#line default
#line hidden
                    return;
                case 15:
                    this.txtFechaPrestamo = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 16:
                    this.txtFechaDevolucion = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 17:
                    this.btnCapturarPrestamo = ((System.Windows.Controls.Button)(target));

#line 117 "..\..\..\MainWindow.xaml"
                    this.btnCapturarPrestamo.Click += new System.Windows.RoutedEventHandler(this.btnCapturarPrestamo_Click);

#line default
#line hidden
                    return;
                case 18:
                    this.btnListarPrestamo = ((System.Windows.Controls.Button)(target));

#line 118 "..\..\..\MainWindow.xaml"
                    this.btnListarPrestamo.Click += new System.Windows.RoutedEventHandler(this.btnListarPrestamo_Click);

#line default
#line hidden
                    return;
                case 19:
                    this.btnBuscarPrestamo = ((System.Windows.Controls.Button)(target));

#line 119 "..\..\..\MainWindow.xaml"
                    this.btnBuscarPrestamo.Click += new System.Windows.RoutedEventHandler(this.btnBuscarPrestamo_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

