[![.NET Pipeline](https://github.com/CharlesWLudwig/charleswludwig-24-graph-bootcamp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/CharlesWLudwig/charleswludwig-24-graph-bootcamp/actions/workflows/dotnet.yml)

= Building Neo4j Applications with .NET

> Learn how to interact with Neo4j from .NET using the Neo4j .NET driver.

This repository accompanies the link:https://graphacademy.neo4j.com/courses/app-dotnet/[Building Neo4j Applications with .NET course^] on link:https://graphacademy.neo4j.com/[Neo4j GraphAcademy^].

For a complete walkthrough of this repository, link:https://graphacademy.neo4j.com/courses/app-dotnet/[enroll now^].

== Setup

. Clone Repository
. Install .NET 6 SDK. link:https://dotnet.microsoft.com/en-us/download/dotnet/6.0/[Microsoft .NET 6.0 installers^].
. Run `dotnet build`

== Connections
Connection details to your neo4j database are located in `Neoflix/appsettings.json`

== A note on comments

you may spot a number of comments in this repository that look like:

[Source, dotnet]
----
// tag::something[]
SomeCode()
// end::something[]
----

We use link:https://asciidoc-py.github.io/index.html[Asciidoc^] to author our courses.
Using these tags means that we can use a macro to include portions of code directly into the course itself.

From the point of view of the course, you can go ahead and ignore them.

== Filtering tests from command line

`dotnet test --logger "console;verbosity=detailed" --filter "Neoflix.Challenges._01_ConnectToNeo4j"`
