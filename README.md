A project where I try to apply best practices about clean architecture, and also experiment a couple of things that are important to me but seem neglected almost everywhere.

## Clean Architecture
>[![the clean architecture, also known as hexagonal architecture](README.clean_architecture.png)](https://youtu.be/WpkDN78P884?t=420)

Some resources about this architecture:
* [conference](https://youtu.be/WpkDN78P884?t=420)
* [article](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
* [book](https://www.google.com/search?q=clean+architecture+book)
* it is also known as the hexagonal architecture 

## Specification & Implementation Assemblies
One of my ideas is that there would be two kinds of assemblies:
* "Specification" assemblies
* "Implementation" assemblies

### "Specification" assemblies
>![Specification assembly](README.specification_assembly.svg)

A few notes about this concept:
* if Project Owners were developers, here is where they'd write user stories, in the shape of interfaces to implement and blackbox tests to pass.
* you could rewrite a new, functional project from scratch if you had only these assemblies
* these assemblies give the developer a binary answer to whether their job is good enough or not through the tests

### "Implementation" assemblies
>![Implementation assembly](README.implementation_assembly.svg)

A few notes about this concept:
* you wouldn't be able to understand the functional part of the project if you had only these assemblies
* yes, I know, that's mixing test code with production code, there are dependencies to the unit testing framework all over the place. I'm experimenting whether the pros beat the cons. Get over it.

## Architecture Decision Log
I also believe in [Architecture Decision Log](https://github.com/joelparkerhenderson/architecture_decision_record) and want to experiment with it.

Too often have I stumbled on a piece of code then wondered:
* "Why the hell was this piece of code designed that way?
* "Has the developers thought about doing this _that_ way instead? Or couldn't he at that time?"

I'll be using the [MADR template](https://github.com/adr/madr):
```markdown
# Use Markdown Architectural Decision Records

## Context and Problem Statement

We want to record architectural decisions made in this project.
Which format and structure should these records follow?

## Considered Options

* [MADR](https://adr.github.io/madr/) 2.1.0 - The Markdown Architectural Decision Records
* [Michael Nygard's template](http://thinkrelevance.com/blog/2011/11/15/documenting-architecture-decisions) - The first incarnation of the term "ADR"
* [Sustainable Architectural Decisions](https://www.infoq.com/articles/sustainable-architectural-design-decisions) - The Y-Statements
* Other templates listed at <https://github.com/joelparkerhenderson/architecture_decision_record>
* Formless - No conventions for file format and structure

## Decision Outcome

Chosen option: "MADR 2.1.0", because

* Implicit assumptions should be made explicit.
  Design documentation is important to enable people understanding the decisions later on.
		  See also [A rational design process: How and why to fake it](https://doi.org/10.1109/TSE.1986.6312940).
				* The MADR format is lean and fits our development style.
				* The MADR structure is comprehensible and facilitates usage & maintenance.
				* The MADR project is vivid.
				* Version 2.1.0 is the latest one available when starting to document ADRs.
```

## Problems solved by the projects
One step that has been very hard to me was to find a business need in order to build projects. I'm currently using katas from [the coding dojo KataCatalogue](https://codingdojo.org/KataCatalogue/) in order to create my projects.
