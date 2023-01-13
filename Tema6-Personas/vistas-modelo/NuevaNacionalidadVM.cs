using CommunityToolkit.Mvvm.ComponentModel;

namespace Tema6_Personas.vistas_modelo
{
    class NuevaNacionalidadVM : ObservableObject
    {
        private string nacionalidadNueva;
        public string NacionalidadNueva
        {
            get => nacionalidadNueva;
            set => SetProperty(ref nacionalidadNueva, value);
        }
    }
}