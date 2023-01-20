using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;
using Tema6_Personas.mensajes;
using Tema6_Personas.modelos;
using Tema6_Personas.servicios;

namespace Tema6_Personas.vistas_modelo
{
    public class ListadoPersonasVM : ObservableObject
    {
        private readonly PersonasService servicioPersonas;

        private ObservableCollection<Persona> personas;
        public ObservableCollection<Persona> Personas
        {
            get => personas;
            set => SetProperty(ref personas, value);
        }

        private Persona personaSeleccionada;
        public Persona PersonaSeleccionada
        {
            get => personaSeleccionada;
            set => SetProperty(ref personaSeleccionada, value);
        }

        public ListadoPersonasVM()
        {
            servicioPersonas = new PersonasService();

            Personas = servicioPersonas.GetSamples();

            WeakReferenceMessenger.Default.Register<NuevaPersonaValueChangedMessage>(
                this,
                (_, m) => Personas.Add(m.Value)
            );

            WeakReferenceMessenger.Default.Register<ListadoPersonasVM, PersonaActualRequestMessage>(
                this,
                (_, m) => {
                    if (!m.HasReceivedResponse && PersonaSeleccionada != null) {
                        m.Reply(PersonaSeleccionada);
                    }
                }
            );
        }
    }
}