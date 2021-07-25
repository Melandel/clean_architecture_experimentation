using System;
using Application.UseCases.ModuleA.Contract;
using Application.UseCases.ModuleA.Implementation;
using Application.UseCases.ModuleA.Repositories.Contract;
using Microsoft.Extensions.DependencyInjection;
using Product.ModuleA.Repositories;

namespace Product
{
	class Program
	{
		public static void Main(string[] args)
		{
			var serviceProvider = BuildServiceProvider();

			var obj = serviceProvider.GetService<IGetMessage>();
			var input = new IGetMessage.Input();
			var output = obj.Process(input);

			Console.WriteLine(output.Message);
		}

		private static ServiceProvider BuildServiceProvider()
		{
			var serviceProvider = new ServiceCollection()
				.AddSingleton<IGetMessage, GetMessage>()
				.AddSingleton<IMessageRepository, MessageRepository>()
				.BuildServiceProvider();
			return serviceProvider;
		}
	}
}
