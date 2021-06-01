using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.FeatureManagement;

[assembly: FunctionsStartup(typeof(FunctionApp.Startup))]

namespace FunctionApp
{
    class Startup : FunctionsStartup
    {
        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
            // Add Azure App Configuration as additional configuration source
            // builder.ConfigurationBuilder.AddAzureAppConfiguration(options =>
            // {
            //     options.Connect(Environment.GetEnvironmentVariable("ConfigConnectionString"))
            //            // Configure to reload configuration if the registered 'Sentinel' key is modified
            //            .ConfigureRefresh(refreshOptions =>
            //                 refreshOptions.Register("MockAPI:Sentinel", refreshAll: true)
            //             )
            //            .UseFeatureFlags();
            // });
            builder.ConfigurationBuilder.AddAzureAppConfiguration(options =>
            {
                options.Connect("Endpoint=https://mock-api-cfg.azconfig.io;Id=ro9L-lw-s0:He18bA4nn1Dr5Re2mvYa;Secret=WcmgiE/H1nUPnUNEkcwyFII0Z8J+xbUXMGEuBpGppSU=")
                       // Configure to reload configuration if the registered 'Sentinel' key is modified
                       .ConfigureRefresh(refreshOptions =>
                            refreshOptions.Register("MockAPI:Sentinel", refreshAll: true)
                        )
                       .UseFeatureFlags();
            });
        }

        public override void Configure(IFunctionsHostBuilder builder)
        {
            // Make Azure App Configuration services and feature manager available through dependency injection
            builder.Services.AddAzureAppConfiguration();
            builder.Services.AddFeatureManagement();
        }
    }
}