using Application.UseCases.ModuleA.Contract;
using Application.UseCases.ModuleA.Repositories.Contract;
#if COMPILE_TESTS
using Application.UseCases.ModuleA.Contract.Fixtures;
using Application.UseCases.ModuleA.Implementation.Fixtures;
#endif

namespace Application.UseCases.ModuleA.Implementation
{
	public class GetMessage : IGetMessage {
		private readonly IMessageRepository _messageRepository;
		public GetMessage(IMessageRepository messageRepository) {
			_messageRepository = messageRepository;
		}

		public IGetMessage.Output Process(IGetMessage.Input request) => new(_messageRepository.Get().Value);


#if COMPILE_TESTS
		public class Should : IGetMessage.Behavior { public override Fixture<IGetMessage> HappyPathFixture => new HappyPathFixture(); }
#endif
	}
}
