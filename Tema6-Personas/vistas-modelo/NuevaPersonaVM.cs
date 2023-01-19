using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;
using Tema6_Personas.mensajes;
using Tema6_Personas.modelos;
using Tema6_Personas.servicios;

namespace Tema6_Personas.vistas_modelo
{
    public class NuevaPersonaVM : ObservableObject
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

        private string nombreNuevo;
        public string NombreNuevo
        {
            get => nombreNuevo;
            set => SetProperty(ref nombreNuevo, value);
        }

        private int? edadNueva;
        public int? EdadNueva
        {
            get => edadNueva;
            set => SetProperty(ref edadNueva, value);
        }

        public NuevaPersonaVM()
        {
            servicioNavegacion = new NavegacionService();

            NuevaNacionalidadCommand = new RelayCommand(AñadirNacionalidad);
            AñadirPersonaCommand = new RelayCommand(AñadirPersona);

            Nacionalidades = new ObservableCollection<string> { "Italiana", "Española", "Francesa" };

            WeakReferenceMessenger.Default.Register<NuevaNacionalidadValueChangedMessage>(
                this,
                (_, m) => Nacionalidades.Add(m.Value)
            );
        }

        public void AñadirNacionalidad() => servicioNavegacion.AbrirDialogo();

        public void AñadirPersona()
        {
            Persona nuevaPersona = new Persona(NombreNuevo, EdadNueva, NacionalidadSeleccionada);
            WeakReferenceMessenger.Default.Send(new NuevaPersonaValueChangedMessage(nuevaPersona));
        }
    }
}