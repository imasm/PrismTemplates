using Prism.Modularity;
using Prism.Regions;
using Microsoft.Practices.Unity;

namespace $safeprojectname$
{
	public class Module: IModule
    {
        private readonly IUnityContainer theContainer;
        private readonly IRegionManager theRegionManager;

        public Module(IUnityContainer container, IRegionManager regionManager)
        {
            theContainer = container;
            theRegionManager = regionManager;
        }

        public void Initialize()
        {
            // Register types
            // ex: theContainer.RegisterInstance<interface, type>();

            // Register views
            // ex: theRegionManager.Regions.RegisterViewWithRegion(regions.Name, typeof(MyView));
        }
    }
}
