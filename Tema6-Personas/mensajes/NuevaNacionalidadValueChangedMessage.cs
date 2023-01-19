using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Tema6_Personas.mensajes
{
    public class NuevaNacionalidadValueChangedMessage : ValueChangedMessage<string>
    {
        public NuevaNacionalidadValueChangedMessage(string nacionalidad) : base(nacionalidad){}
    }
}