using System.Windows.Controls;
using Tema6_Personas.vistas_modelo;

namespace Tema6_Personas.vistas
{
    /// <summary>
    /// Lógica de interacción para NuevaPersona.xaml
    /// </summary>
    public partial class NuevaPersona : UserControl
    {
        private NuevaPersonaVM vm;

        public NuevaPersona()
        {
            InitializeComponent();
            vm = new NuevaPersonaVM();
            DataContext = vm;
        }
    }
}