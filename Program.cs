using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Nancy.Owin;

namespace dnca
{
    public class SampleModule : Nancy.NancyModule
    {
        public SampleModule()
        {
            Get("/", _ => "Hello World!");
        }
    }

    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}