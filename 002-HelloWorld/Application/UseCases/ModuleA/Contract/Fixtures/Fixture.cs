using Application.ArchitecturalConcepts;

namespace Application.UseCases.ModuleA.Contract.Fixtures
{
	public abstract record Fixture<T> : UseCaseFixture<T> {
		public string MessageInsideRepository { get; init; }
	}
}
