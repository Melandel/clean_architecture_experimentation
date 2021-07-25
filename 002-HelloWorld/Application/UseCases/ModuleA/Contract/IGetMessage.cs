#if COMPILE_TESTS
using Xunit;
#endif

using Application.ArchitecturalConcepts;
using Application.UseCases.ModuleA.Contract.Fixtures;

namespace Application.UseCases.ModuleA.Contract
{
	public interface IGetMessage : IApplicationCallableUnit<IGetMessage.Input, IGetMessage.Output>
	{
		public record Input : ApplicationInput;
		public record Output(string Message) : ApplicationOutput;

#if COMPILE_TESTS
		public abstract class Behavior: UseCaseBehavior<IGetMessage, Fixture<IGetMessage>> {
			[Fact]
			protected virtual void ReturnTheMessage() {
				var fixture = HappyPathFixture;
				var result = fixture.SystemUnderTest.Process(new());
				Assert.Equal(HappyPathFixture.MessageInsideRepository, result.Message);
			}

			[Fact]
			protected virtual void ReturnEmptyString_WhenMessageIsNull() {
				var fixture = HappyPathFixture with {
					MessageInsideRepository = null
				};
				var result = fixture.SystemUnderTest.Process(new());
				Assert.Equal("", result.Message);
			}
		}
#endif
	}
}
