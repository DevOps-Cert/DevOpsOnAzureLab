﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MainWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseHealthChecks("/hc")
                .UseApplicationInsights()
                .UseStartup<Startup>()
                .Build();
    }
}
