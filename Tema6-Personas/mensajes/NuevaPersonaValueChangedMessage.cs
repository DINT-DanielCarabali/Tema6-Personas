using CommunityToolkit.Mvvm.Messaging.Messages;
using Tema6_Personas.modelos;

namespace Tema6_Personas.mensajes
{
    public class NuevaPersonaValueChangedMessage : ValueChangedMessage<Persona>
    {
        public NuevaPersonaValueChangedMessage(Persona persona) : base(persona){}
    }
}