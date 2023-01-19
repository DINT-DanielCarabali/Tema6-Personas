using System.Windows.Controls;
using Tema6_Personas.vistas_modelo;

namespace Tema6_Personas.vistas
{
    /// <summary>
    /// Lógica de interacción para ConsultaPersona.xaml
    /// </summary>
    public partial class ConsultaPersona : UserControl
    {
        private readonly ConsultaPersonaVM vm;

        public ConsultaPersona()
        {
            InitializeComponent();
            vm = new ConsultaPersonaVM();
            DataContext = vm;
        }
    }
}