using System;
using System.Collections.Generic;

namespace Domain.ArchitecturalConcepts {
	public abstract class Entity<TEntityIdentifier> {
		TEntityIdentifier Id { get; }

		public sealed override bool Equals(object obj) {
			return obj is Entity<TEntityIdentifier> entity &&
				EqualityComparer<TEntityIdentifier>.Default.Equals(Id, entity.Id);
		}

		public sealed override int GetHashCode() {
			return HashCode.Combine(Id);
		}
	}
}

