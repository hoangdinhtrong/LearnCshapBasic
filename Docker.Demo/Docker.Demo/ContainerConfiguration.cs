using Autofac;
using Autofac.Extensions.DependencyInjection;
using Docker.Demo.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Docker.Demo
{
    internal static class ContainerConfiguration
    {
        #region Microsoft.Extensions.DependencyInjection
        //public static ServiceProvider Configure()
        //{
        //    return new ServiceCollection()
        //        .AddLogging(l => l.AddConsole())
        //        .Configure<LoggerFilterOptions>(c => c.MinLevel = LogLevel.Trace)
        //        .AddSingleton<IPrintSettingsProvider, PrintSettingsProvider>()
        //        .AddSingleton<IConsolePrinter, ConsolePrinter>()
        //        .AddSingleton<ContinuousRunningProcessor>()
        //        .BuildServiceProvider();
        //}
        #endregion

        #region Autofac
        public static IServiceProvider Configure()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(l => l.AddConsole())
                .Configure<LoggerFilterOptions>(c => c.MinLevel = LogLevel.Trace);

            var containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(serviceCollection);

            containerBuilder.RegisterType<PrintSettingsProvider>().As<IPrintSettingsProvider>().SingleInstance();
            containerBuilder.RegisterType<ConsolePrinter>().As<IConsolePrinter>().SingleInstance();
            containerBuilder.RegisterType<ContinuousRunningProcessor>().SingleInstance();

            var container = containerBuilder.Build();

            return new AutofacServiceProvider(container);
        }
        #endregion
    }
}
