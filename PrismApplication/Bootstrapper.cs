using Microsoft.Practices.ServiceLocation;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace $safeprojectname$
{
    internal class Bootstrapper: UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<MainWindow>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            // Modules defined in code
            return new ModuleCatalog();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            // Add your modules here
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();

            // Register your types in container here            
        }
    }
}
