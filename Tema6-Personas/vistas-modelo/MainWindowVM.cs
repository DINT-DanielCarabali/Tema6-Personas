using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Controls;
using Tema6_Personas.servicios;

namespace Tema6_Personas.vistas_modelo
{
    public class MainWindowVM : ObservableObject
    {
        private readonly NavegacionService servicioNavegacion;

        public RelayCommand AbrirUCNuevaPersonaCommand { get; }
        public RelayCommand AbrirUCListadoPersonasCommand { get; }
        public RelayCommand AbrirUCConsultaPersonaCommand { get; }

        private UserControl contenidoVentana;
        public UserControl ContenidoVentana
        {
            get => contenidoVentana;
            set => SetProperty(ref contenidoVentana, value);
        }

        public MainWindowVM()
        {
            servicioNavegacion = new NavegacionService();

            AbrirUCNuevaPersonaCommand = new RelayCommand(AbrirUCAñadirPersona);
            AbrirUCListadoPersonasCommand = new RelayCommand(AbrirUCListadoPersonas);
            AbrirUCConsultaPersonaCommand = new RelayCommand(AbrirUCConsultaPersona);
        }

        public void AbrirUCAñadirPersona() => ContenidoVentana = servicioNavegacion.AbrirUC("NUEVA PERSONA");

        public void AbrirUCListadoPersonas() => ContenidoVentana = servicioNavegacion.AbrirUC("LISTADO PERSONAS");

        public void AbrirUCConsultaPersona() => ContenidoVentana = servicioNavegacion.AbrirUC("CONSULTA PERSONA");
    }
}