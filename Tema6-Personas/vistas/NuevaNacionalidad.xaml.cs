using System.Windows;
using Tema6_Personas.vistas_modelo;

namespace Tema6_Personas.vistas
{
    /// <summary>
    /// Lógica de interacción para NuevaNacionalidad.xaml
    /// </summary>
    public partial class NuevaNacionalidad : Window
    {
        private NuevaNacionalidadVM vm;

        public NuevaNacionalidad()
        {
            InitializeComponent();
            vm = new NuevaNacionalidadVM();
            DataContext = vm;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}