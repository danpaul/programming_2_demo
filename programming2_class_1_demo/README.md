## About

This repo contains sample code for the main topics covered in week 1 of Programming 2.

## Projects and topics

### `./class_review`

This project contains code relevant to a review of classes, properties and methods:

- `Player.cs` shows a simple class with fields, overloaded constructors and use of `this` to call one constructor from another.
- `PlayerPrimary.cs` shows the use of a primary constructor, accessing primary constructor parameters in a method and the need to call the primary constructor from any other constructors that are created.
- `MyMath.cs` show the use of static class methods and fields

### `./to_string`

Contains example code showing how to define and override `ToString()` method on a class. This ca be useful when, for instance, we want to output a standard string representation of an object.

### `./srp_book_example`

Examples classes relevant to the separation of concerns principle (SRP). The first shows an example book class which violates SRP by combining the responsibilities of data structuring and persistence into a single class. The second set of classes break these into separate classes to handle enforce handling of a single responsibility per class.

### `./srp_invoices`

This project contains additional examples of applying SRP. An invoice systems with multiple functions and responsibilities is separated into multiple classes which each handle a single responsibility.

### `./soc_log`

Contains a simple logging application which adhered to the separation of concerns (SOC) principle by organizing the code into a view and data persistence layer.

### `./soc_todo`

A simple todo application demonstrating the use of the SOC principle.
