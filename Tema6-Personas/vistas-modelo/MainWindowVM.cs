using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Controls;
using Tema6_Personas.servicios;

namespace Tema6_Personas.vistas_modelo
{
    class MainWindowVM : ObservableObject
    {
        private readonly NavegacionService servicioNavegacion;

        public RelayCommand NuevaPersonaCommand { get; }
        public RelayCommand ListadoPersonasCommand { get; }

        private UserControl contenidoVentana;
        public UserControl ContenidoVentana
        {
            get => contenidoVentana;
            set => SetProperty(ref contenidoVentana, value);
        }

        public MainWindowVM()
        {
            servicioNavegacion = new NavegacionService();

            NuevaPersonaCommand = new RelayCommand(AñadirPersona);
            ListadoPersonasCommand = new RelayCommand(VerListadoPersonas);
        }

        public void AñadirPersona() => ContenidoVentana = servicioNavegacion.AbrirUC("NUEVA PERSONA");

        public void VerListadoPersonas() => ContenidoVentana = servicioNavegacion.AbrirUC("LISTADO PERSONAS");
    }
}