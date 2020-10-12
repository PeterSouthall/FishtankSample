/***************************************************************************\
File Name:  SettingsHelper.cs
Project:      FishTank
Copyright (c) 2020
\***************************************************************************/

namespace FishtankSample.Settings
{
    using System;
    using System.IO;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// A simple utility class to help with reading from appsettings.json.
    /// </summary>
    public class SettingsHelper
    {
        /// <summary>
        /// The configuration.
        /// </summary>
        private static IConfigurationRoot _configuration;

        /// <summary>
        /// Reads a setting with the specified key from the appsettings.json configuration file.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSetting(string key)
        {
            if (_configuration == null)
            {
                ConfigureServices();
            }

            return _configuration[key];
        }

        /// <summary>
        /// Builds the configuration and initialises the service provider.
        /// </summary>
        private static void ConfigureServices()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            // Build configuration
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();

            // Add access to the configuration
            serviceCollection.AddSingleton<IConfigurationRoot>(_configuration);

            // Build the service provider
            serviceCollection.BuildServiceProvider();
        }
    }
}
