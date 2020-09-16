using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld
{
	public static class IServiceCollectionExtensions
	{
		public static IServiceCollection ConfigureModule_GetMessage(this IServiceCollection collection)
		{
			return collection
				.AddSingleton<GetMessage, GetMessageImpl>();
		}
	}
}
