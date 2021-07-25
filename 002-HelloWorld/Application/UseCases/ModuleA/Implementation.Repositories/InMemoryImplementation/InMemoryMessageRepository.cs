using Application.UseCases.ModuleA.Repositories.Contract;
using Domain.Module1;

namespace Application.UseCases.ModuleA.Repositories.InMemoryImplementation {
	public class InMemoryMessageRepository : IMessageRepository {
		public Message Message { get; init; }
		private InMemoryMessageRepository(Message content) {
			Message = content;
		}

		public static InMemoryMessageRepository CreateFromContent(string repositoryContent) => new(Message.Create(repositoryContent));

		Message IMessageRepository.Get() => Message.Create(Message.Value ?? "");
	}
}
