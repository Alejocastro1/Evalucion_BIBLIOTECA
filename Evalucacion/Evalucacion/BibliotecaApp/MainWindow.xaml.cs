using Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace BibliotecaApp
{
    public partial class MainWindow : Window
    {
        private Repositorio<Libro> repositorioLibros = new Repositorio<Libro>();
        private Repositorio<Usuario> repositorioUsuarios = new Repositorio<Usuario>();
        private Repositorio<Prestamo> repositorioPrestamos = new Repositorio<Prestamo>();

        public MainWindow()
        {
            InitializeComponent();
            InicializarDatos();
        }

        private void InicializarDatos()
        {
            // Inicializar listas con datos de ejemplo para evitar excepciones por listas vacías
            var autorEjemplo = new Autor("Autor Ejemplo", "autor@example.com");
            var libroEjemplo = new Libro("Libro Ejemplo", autorEjemplo);
            repositorioLibros.Agregar(libroEjemplo);

            var usuarioEjemplo = new Usuario("Usuario Ejemplo", "usuario@example.com");
            repositorioUsuarios.Agregar(usuarioEjemplo);

            var prestamoEjemplo = new Prestamo(libroEjemplo, usuarioEjemplo, DateTime.Now, DateTime.Now.AddDays(14));
            repositorioPrestamos.Agregar(prestamoEjemplo);

            ActualizarListaLibros();
            ActualizarListaUsuarios();
            ActualizarListaPrestamos();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && textBox.Foreground == Brushes.Gray)
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void btnCapturarLibro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string titulo = txtBuscarTitulo.Text;
                string nombreAutor = txtBuscarAutor.Text;

                Autor autor = new Autor(nombreAutor, "autor@example.com");
                Libro libro = new Libro(titulo, autor);
                repositorioLibros.Agregar(libro);

                ActualizarListaLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al capturar libro: {ex.Message}");
            }
        }

        private void btnListarLibro_Click(object sender, RoutedEventArgs e)
        {
            ActualizarListaLibros();
        }

        private void btnBuscarLibro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string titulo = txtBuscarTitulo.Text;
                var libros = repositorioLibros.Buscar(l => l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase));
                lvLibros.ItemsSource = libros;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar libro: {ex.Message}");
            }
        }

        private void ActualizarListaLibros()
        {
            lvLibros.ItemsSource = repositorioLibros.Buscar(l => true);
        }

        private void btnCapturarUsuario_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombre = txtBuscarNombreUsuario.Text;
                string email = txtBuscarEmailUsuario.Text;

                Usuario usuario = new Usuario(nombre, email);
                repositorioUsuarios.Agregar(usuario);

                ActualizarListaUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al capturar usuario: {ex.Message}");
            }
        }

        private void btnListarUsuario_Click(object sender, RoutedEventArgs e)
        {
            ActualizarListaUsuarios();
        }

        private void btnBuscarUsuario_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombre = txtBuscarNombreUsuario.Text;
                var usuarios = repositorioUsuarios.Buscar(u => u.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase));
                lvUsuarios.ItemsSource = usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar usuario: {ex.Message}");
            }
        }

        private void ActualizarListaUsuarios()
        {
            lvUsuarios.ItemsSource = repositorioUsuarios.Buscar(u => true);
        }

        private void btnCapturarPrestamo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string tituloLibro = txtBuscarPrestamoLibro.Text;
                string nombreUsuario = txtBuscarNombreUsuario.Text;

                var libro = repositorioLibros.Buscar(l => l.Titulo.Equals(tituloLibro, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                var usuario = repositorioUsuarios.Buscar(u => u.Nombre.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

                if (libro != null && usuario != null)
                {
                    DateTime fechaPrestamo = DateTime.Now;
                    DateTime fechaDevolucion = Utilidades.CalcularFechaDevolucion(fechaPrestamo, 14);

                    Prestamo prestamo = new Prestamo(libro, usuario, fechaPrestamo, fechaDevolucion);
                    repositorioPrestamos.Agregar(prestamo);

                    ActualizarListaPrestamos();
                }
                else
                {
                    MessageBox.Show("Libro o Usuario no encontrados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al capturar préstamo: {ex.Message}");
            }
        }

        private void btnListarPrestamo_Click(object sender, RoutedEventArgs e)
        {
            ActualizarListaPrestamos();
        }

        private void btnBuscarPrestamo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string tituloLibro = txtBuscarPrestamoLibro.Text;
                var prestamos = repositorioPrestamos.Buscar(p => p.Libro.Titulo.Contains(tituloLibro, StringComparison.OrdinalIgnoreCase));
                lvPrestamos.ItemsSource = prestamos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar préstamo: {ex.Message}");
            }
        }

        private void ActualizarListaPrestamos()
        {
            lvPrestamos.ItemsSource = repositorioPrestamos.Buscar(p => true);
        }
    }
}