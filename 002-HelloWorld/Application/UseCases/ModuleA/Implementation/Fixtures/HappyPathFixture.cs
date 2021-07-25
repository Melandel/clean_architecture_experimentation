using Application.UseCases.ModuleA.Contract;
using Application.UseCases.ModuleA.Contract.Fixtures;
using Application.UseCases.ModuleA.Repositories.InMemoryImplementation;

namespace Application.UseCases.ModuleA.Implementation.Fixtures {
		public record HappyPathFixture : Fixture<IGetMessage> {
			public HappyPathFixture() {
				MessageInsideRepository = "foo bar baz";
			}
			public override IGetMessage SystemUnderTest => new GetMessage(InMemoryMessageRepository.CreateFromContent(MessageInsideRepository));
		}
}
