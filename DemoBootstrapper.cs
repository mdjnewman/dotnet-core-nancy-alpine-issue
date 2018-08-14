using Nancy.TinyIoc;

namespace Nancy.Demo.Hosting.Kestrel
{
    public class DemoBootstrapper : DefaultNancyBootstrapper
    {
        private readonly IAppConfiguration appConfig;

        public DemoBootstrapper()
        {
        }
        
        public DemoBootstrapper(IAppConfiguration appConfig)
        {
            this.appConfig = appConfig;
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            container.Register<IAppConfiguration>(appConfig);
        }
    }
}