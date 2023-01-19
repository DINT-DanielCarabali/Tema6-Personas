using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;
using Tema6_Personas.mensajes;
using Tema6_Personas.modelos;

namespace Tema6_Personas.vistas_modelo
{
    public class ListadoPersonasVM : ObservableObject
    {
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
            Personas = new ObservableCollection<Persona>
            {
                new Persona("Pietro", 30, "Italiana"),
                new Persona("Julia", 25, "Española"),
                new Persona("Sophie", 35, "Francesa")
            };

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