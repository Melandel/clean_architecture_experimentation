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
|-- usecases
    |-- module_A
    |-- module_B
    |-- specs
        |-- module_A
          |-- abstractions
              `-- examples
          |-- behavior
        |-- module_B
          |-- abstractions
              `-- examples
          |-- behavior
|-- name_of_product
    |-- module_A.adapters
        |-- Controllers
        `-- Data
    |-- module_B.adapters
        |-- Controllers
        `-- Data
    |-- startup
    `-- ui
```
