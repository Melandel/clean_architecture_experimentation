namespace Application.ArchitecturalConcepts {
	public abstract class UseCaseBehavior<TSut, TFixture> where TFixture:UseCaseFixture<TSut> {
			public abstract TFixture HappyPathFixture { get; }
	}
}

