# Use Hexagonal ("Clean") Architecture

| Date       | 
|:-----------|
| 2020-09-09 | 

## Context and Problem Statement

We want to write source code with an architecture that we want to practice. Which type of architecture should we go for?

## Decision Drivers <!-- optional -->

* Complexity

## Considered Options

* [Hexagonal Architecture](https://melandel.github.io/resources/clean_architecture/article.html)
* [CQRS + EventSourcing](https://melandel.github.io/resources/cqrs/article.html)
* No architecture

## Decision Outcome

Chosen option: "Hexagonal Architecture", because it is driven by the communication of the behaviors of the system - topic that has always been important in my experience, and I've been wanting to develop one (even as a toy project) for several years

### Positive Consequences <!-- optional -->

* Low coupling
* Testable
* Not bound to any specific technology or framework
* Delays the choice of a technology or framework as much as possible
* The code is structured so that the behaviors of the system are nicely listed, documented and located.
* The addition, removal, and changes made on the behavior of the system are nicely logged in one folder for a git log

### Negative Consequences <!-- optional -->

* A significant number of layers
* Not going to fit systems that are performance-critical
