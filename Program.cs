using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IWriter>(w =>
                {
                    var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();

                    var factory = new WriterFactory();
                    return factory.GetWriter(config["writer"]);
                })
                .AddSingleton<IApi,Api>()
                .BuildServiceProvider();

            var api = serviceProvider.GetService<IApi>();
            api.Write();
        }
    }
}
