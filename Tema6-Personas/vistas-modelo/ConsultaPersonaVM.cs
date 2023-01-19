using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Tema6_Personas.mensajes;
using Tema6_Personas.modelos;

namespace Tema6_Personas.vistas_modelo
{
    public class ConsultaPersonaVM : ObservableRecipient
    {
        private Persona personaActual;
        public Persona PersonaActual
        {
            get => personaActual;
            set => SetProperty(ref personaActual, value);
        }

        public ConsultaPersonaVM() => PersonaActual = WeakReferenceMessenger.Default.Send<PersonaActualRequestMessage>();
    }
}