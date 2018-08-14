namespace Nancy.Demo.Hosting.Kestrel
{
    public class AppConfiguration : IAppConfiguration
    {
        public Logging Logging { get; set; }
        public Smtp Smtp { get; set; }
    }
}