using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Nancy.Demo.Hosting.Kestrel;

namespace dnca
{
    public class SampleModule : Nancy.NancyModule
    {
        public SampleModule()
        {
            Get("/", _ => "Hello World!");
        }
    }

    class Program
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