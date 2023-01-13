using CommunityToolkit.Mvvm.ComponentModel;

namespace Tema6_Personas.modelos
{
    class Persona : ObservableObject
    {
        private string nombre;
        public string Nombre
        {
            get => nombre;
            set => SetProperty(ref nombre, value);
        }

        private int edad;
        public int Edad
        {
            get => edad;
            set => SetProperty(ref edad, value);
        }

        private string nacionalidad;
        public string Nacionalidad
        {
            get => nacionalidad;
            set => SetProperty(ref nacionalidad, value);
        }

        public Persona() { }

        public Persona(string nombre, int edad, string nacionalidad)
        {
            Nombre = nombre;
            Edad = edad;
            Nacionalidad = nacionalidad;
        }
    }
}