using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Tema6_Personas.mensajes;

namespace Tema6_Personas.vistas_modelo
{
    public class NuevaNacionalidadVM : ObservableObject
    {
        public RelayCommand AñadirNacionalidadCommand { get; }

        private string nacionalidadNueva;
        public string NacionalidadNueva
        {
            get => nacionalidadNueva;
            set => SetProperty(ref nacionalidadNueva, value);
        }

        public NuevaNacionalidadVM() => AñadirNacionalidadCommand = new RelayCommand(AñadirNacionalidad);

        public void AñadirNacionalidad()
        {
            WeakReferenceMessenger.Default.Send(
                new NuevaNacionalidadValueChangedMessage(
                    NacionalidadNueva
                )
            );
        }
    }
}