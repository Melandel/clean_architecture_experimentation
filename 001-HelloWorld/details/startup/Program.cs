using HelloWorld;
using Microsoft.Extensions.DependencyInjection;

namespace console
{
	class Program
	{
		static void Main(string[] args)
		{
			var serviceProvider = new ServiceCollection()
				.ConfigureModule_GetMessage()
				.ConfigureModule_GetMessageController()
				.ConfigureModule_GetMessageData()
				.ConfigureModule_UI()
				.BuildServiceProvider();

			serviceProvider.GetService<UserInterface>().Display();
		}
	}
}
