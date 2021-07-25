namespace Application.ArchitecturalConcepts {
	public abstract record UseCaseFixture<T> {
			public abstract T SystemUnderTest { get; }
	}
}

