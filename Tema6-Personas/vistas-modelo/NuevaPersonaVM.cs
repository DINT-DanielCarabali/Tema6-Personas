using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Tema6_Personas.servicios;

namespace Tema6_Personas.vistas_modelo
{
    class NuevaPersonaVM : ObservableObject
    {
        private readonly NavegacionService servicioNavegacion;

        public RelayCommand NuevaNacionalidadCommand { get; }
        public RelayCommand AñadirPersonaCommand { get; }

        private ObservableCollection<string> nacionalidades;
        public ObservableCollection<string> Nacionalidades
        {
            get => nacionalidades;
            set => SetProperty(ref nacionalidades, value);
        }

        private string nacionalidadSeleccionada;
        public string NacionalidadSeleccionada
        {
            get => nacionalidadSeleccionada;
            set => SetProperty(ref nacionalidadSeleccionada, value);
        }

        public NuevaPersonaVM()
        {
            servicioNavegacion = new NavegacionService();

            NuevaNacionalidadCommand = new RelayCommand(AñadirNacionalidad);
            AñadirPersonaCommand = new RelayCommand(AñadirPersona);

            Nacionalidades = new ObservableCollection<string> { "Italiana", "Española", "Francesa" };
        }

        public void AñadirNacionalidad() => servicioNavegacion.AbrirDialogo();

        public void AñadirPersona()
        {

        }
    }
}