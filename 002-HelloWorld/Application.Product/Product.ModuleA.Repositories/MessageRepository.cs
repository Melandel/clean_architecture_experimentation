using Application.UseCases.ModuleA.Repositories.Contract;
using Domain.Module1;

namespace Product.ModuleA.Repositories {
	public class MessageRepository : IMessageRepository {
		public Message Get() => Message.Create("Hello World");
	}
}
