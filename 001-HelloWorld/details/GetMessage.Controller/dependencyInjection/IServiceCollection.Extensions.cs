using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld
{
	public static class IServiceCollectionExtensions
	{
		public static IServiceCollection ConfigureModule_GetMessageController(this IServiceCollection collection)
		{
			return collection
				.AddSingleton<GetHelloWorldController, GetHelloWorldControllerImpl>();
		}
	}
}
