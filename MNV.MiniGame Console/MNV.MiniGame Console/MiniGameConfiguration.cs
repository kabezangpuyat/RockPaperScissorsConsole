using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MNV.MiniGame.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MNV.MiniGame_Console
{
    public abstract class  MiniGameConfiguration
    {
        public IConfiguration _config;

        public static IScissorRockPaperService GameService
        {
            get
            {
				return ConfigureServices().GetService<IScissorRockPaperService>();
			}
        }

		#region Setup
		private static IConfiguration ConfigBuilderSetup()
		{
			var builder = new ConfigurationBuilder();

			IConfiguration config = builder.Build();
			return config;
		}

		private static ServiceProvider ConfigureServices()
		{
			var serviceProvider = new ServiceCollection()
					 //.AddLogging()
					 .AddTransient<IScissorRockPaperService, ScissorRockPaperService>()
					 .BuildServiceProvider();

			return serviceProvider;
		}
		#endregion
	}
}
