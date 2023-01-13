using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using Tema6_Personas.modelos;

namespace Tema6_Personas.vistas_modelo
{
    class ListadoPersonasVM : ObservableObject
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
        }
    }
}