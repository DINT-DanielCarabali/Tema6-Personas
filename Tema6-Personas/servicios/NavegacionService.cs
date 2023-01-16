using System.Windows.Controls;
using Tema6_Personas.vistas;

namespace Tema6_Personas.servicios
{
    class NavegacionService
    {
        private readonly UserControl uc;

        public NavegacionService() => uc = new ListadoPersonas();

        public bool? AbrirDialogo() => new NuevaNacionalidad().ShowDialog();

        public UserControl AbrirUC(string nombreUC)
        {
            switch (nombreUC.ToUpper())
            {
                case "NUEVA PERSONA":
                    return new NuevaPersona();
                case "LISTADO PERSONAS":
                    return uc;
            }

            return uc;
        }
    }
}