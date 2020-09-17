# 001-HelloWorld

## Context and Problem Statement

Write a console application that displays "Hello World"
* The source code should contain the architectural layers one can find in a [clean architecture](https://melandel.github.io/resources/clean_architecture/article.html)
* The source code should contain an [ADL](https://melandel.github.io/resources/doc/architecture/architecture_decision_log.html)
* The commits should be an example of a good iterative approach

## Impressions after completion

* It should be possible to still have all the feature changes from a single `git log` through a folder instead of an assembly:
```
specs
|-- the abstractions
|-- the behavior tests
`-- the examples (for mocking, documentation, pedagogy and error message purposes)
```

* that way, we're not mixing test code with production code
* I like having a `details` folder for anything that isn't `entities` (domain) or `usecase` (interactor):
```
details
|-- startup
|-- module_X.Controllers
|-- module_X.Data
`-- ui
```
* One thing I could try would be the following:
```
|-- domain
    |-- bounded_context_I
    `-- bounded_context_II
|-- application_1
    |-- usecases
        |-- module_A
            |-- gateways.specs
                |-- abstractions
                    `-- abstractions.csproj
                `-- behavior
                    `-- behavior.csproj
            |-- implementation
                `-- implementation.csproj
            `-- tests
                `-- tests.csproj
        |-- module_B
            |-- gateways.specs
                |-- abstractions
                `-- behavior
            |-- implementation
            `-- tests
        |-- specs
            |-- module_A
              |-- abstractions
                  `-- abstractions.csproj
              `-- behavior
                  `-- behavior.csproj
            `-- module_B
              |-- abstractions
              `-- behavior
    |-- name_of_product
        |-- module_A
            |-- controllers
                |-- implementation
                    `-- implementation.csproj
                `-- tests
                    `-- tests.csproj
            |-- gateways
                |-- implementation
                    `-- implementation.csproj
                `-- tests
                    `-- tests.csproj
            `-- presenters
                |-- implementation
                    `-- implementation.csproj
                `-- tests
                    `-- tests.csproj
        |-- module_B
            |-- controllers
                |-- implementation
                `-- tests
            |-- gateways
                |-- implementation
                `-- tests
            `-- presenters
                |-- implementation
                `-- tests
        |-- specs
            |-- module_A
                |-- controllers
                    |-- abstractions
                        `-- abstractions.csproj
                    `-- behavior
                        `-- behavior.csproj
                `-- presenters
                    |-- abstractions
                        `-- abstractions.csproj
                    `-- behavior
                        `-- behavior.csproj
            `-- module_B
                |-- controllers
                    |-- abstractions
                    `-- behavior
                `-- presenters
                    |-- abstractions
                    `-- behavior
        |-- startup
            `-- startup.csproj
        `-- ui
            `-- ui.csproj
|-- application_2
    |-- usecases
        |-- module_A
            |-- gateways.specs
            |-- implementation
            `-- tests
        |-- module_B
            |-- gateways.specs
            |-- implementation
            `-- tests
        |-- specs
            |-- module_A
              |-- abstractions
              `-- behavior
            `-- module_B
              |-- abstractions
              `-- behavior
    |-- name_of_product
        |-- module_A
            |-- controllers
                |-- implementation
                `-- tests
            |-- gateways
                |-- implementation
                `-- tests
            `-- presenters
                |-- implementation
                `-- tests
        |-- module_B
            |-- controllers
                |-- implementation
                `-- tests
            |-- gateways
                |-- implementation
                `-- tests
            `-- presenters
                |-- implementation
                `-- tests
        |-- specs
            |-- module_A
                |-- controllers
                    |-- abstractions
                    `-- behavior
                `-- presenters
                    |-- abstractions
                    `-- behavior
            `-- module_B
                |-- controllers
                    |-- abstractions
                    `-- behavior
                `-- presenters
                    |-- abstractions
                    `-- behavior
        |-- startup
        `-- ui
    |-- ...
```

* `implementation` projects would have a `/extensions/IServiceCollectionExtensions.cs` to configure dependency injection
* `abstractions` projects would have a `/examples` folder to store examples that are meaningful for the business
* `abstractions` projects would also have a folder for each kind of test double: `/Stubs`, `/Mocks`, `/Spies`, `/Fakes` and `/Dummies`
* `behavior` projects would have a `/utils` folder in order to host `TestInputBuilder` classes that wrap the building process of the otherwise immutable input dtos, with default values matching items from `abstractions/examples`
