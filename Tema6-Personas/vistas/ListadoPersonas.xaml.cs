using System.Windows.Controls;
using Tema6_Personas.vistas_modelo;

namespace Tema6_Personas.vistas
{
    /// <summary>
    /// Lógica de interacción para ListadoPersonas.xaml
    /// </summary>
    public partial class ListadoPersonas : UserControl
    {
        private ListadoPersonasVM vm;

        public ListadoPersonas()
        {
            InitializeComponent();
            vm = new ListadoPersonasVM();
            DataContext = vm;
        }
    }
}