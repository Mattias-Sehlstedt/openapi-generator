# org.openapitools.server - Kotlin Server library for Basic polymorphism example with discriminator

## Requires

* Kotlin 1.4.31
* Gradle 6.8.2

## Build

First, create the gradle wrapper script:

```
gradle wrapper
```

Then, run:

```
./gradlew check assemble
```

This runs all tests and packages the library.

## Features/Implementation Notes

* Supports JSON inputs/outputs, File inputs, and Form inputs.
* Supports collection formats for query parameters: csv, tsv, ssv, pipes.
* Some Kotlin and Java types are fully qualified to avoid conflicts with types defined in OpenAPI definitions.

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------


<a id="documentation-for-models"></a>
## Documentation for Models

 - [org.openapitools.server.models.Cat](docs/Cat.md)
 - [org.openapitools.server.models.Dog](docs/Dog.md)
 - [org.openapitools.server.models.Pet](docs/Pet.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization

Endpoints do not require authorization.

