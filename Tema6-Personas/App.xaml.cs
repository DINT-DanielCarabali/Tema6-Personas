using System.Windows;

namespace Tema6_Personas
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(
                Tema6_Personas.Properties.Settings.Default.clave
            );
        }
    }
}