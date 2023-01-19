using System.Windows.Controls;
using Tema6_Personas.vistas;

namespace Tema6_Personas.servicios
{
    public class NavegacionService
    {
        private readonly UserControl listadoPersonasUC;

        public NavegacionService() => listadoPersonasUC = new ListadoPersonas();

        public bool? AbrirDialogo()
        {
            NuevaNacionalidad dialogo = new NuevaNacionalidad();
            return dialogo.ShowDialog();
        }

        public UserControl AbrirUC(string nombreUC)
        {
            UserControl uc = null;
            switch (nombreUC.ToUpper())
            {
                case "NUEVA PERSONA":
                    uc = new NuevaPersona();
                    break;
                case "LISTADO PERSONAS":
                    uc = listadoPersonasUC;
                    break;
                case "CONSULTA PERSONA":
                    uc = new ConsultaPersona();
                    break;
            }

            return uc;
        }
    }
}