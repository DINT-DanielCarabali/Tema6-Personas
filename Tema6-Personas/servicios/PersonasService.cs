using System.Collections.ObjectModel;
using Tema6_Personas.modelos;

namespace Tema6_Personas.servicios
{
    public class PersonasService
    {
        public ObservableCollection<Persona> GetSamples()
        {
            return new ObservableCollection<Persona>
            {
                new Persona("Pietro", 30, "Italiana"),
                new Persona("Julia", 25, "Española"),
                new Persona("Sophie", 35, "Francesa")
            };
        }
    }
}