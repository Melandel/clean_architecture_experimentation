using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld
{
	public static class IServiceCollectionExtensions
	{
		public static IServiceCollection ConfigureModule_UI(this IServiceCollection collection)
		{
			return collection
				.AddSingleton<UserInterface, UserInterfaceImpl>();
		}
	}
}
