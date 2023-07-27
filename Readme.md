# ShouldlyFluentExtension

ShouldlyFluentExtension is a powerful and expressive fluent API designed to streamline writing unit tests with ease and readability. It provides a concise and natural language syntax for making assertions, eliminating the need for explicit variable declarations, and enhancing code maintainability.

## Features

- **Fluent API**: Easily chain multiple assertions on the same object without the need to assign variables manually. This results in clean and concise test code that is more maintainable and less error-prone.
- **Eliminate Repetition**: By removing the need for repetitive variable declarations, your test code becomes more compact and focused, reducing the chances of copy-paste errors and code duplication.
- **Readable Assertions**: The expressive syntax of ShouldlyFluentExtension enables you to write self-explanatory assertions, making it easier for other team members to understand the intent of each test case.
- **Integration with NUnit**: Seamless integration with the NUnit testing framework, allowing you to leverage the full power of NUnit's test runners and reporting capabilities.

## Example Usage

With ShouldlyFluentExtension, writing unit tests becomes more elegant and efficient. Say goodbye to boilerplate variable declarations and embrace the clarity and productivity provided by this lightweight, yet feature-rich library.

```csharp
Find(1)
    .ShouldBe(x => x.Id, 1)
    .ShouldBe(x => x.Name, "Num");
```

Full example:

```csharp
using ShouldlyFluentExtension;

Item Find(int i) => new Item(i, "Num");

Find(1)
    .ShouldBe(x => x.Id, 1)
    .ShouldBe(x => x.Name, "Num");

Console.WriteLine("Hello, World!");

record Item(int Id, string Name);
```

## Getting Started

1. Install the ShouldlyFluentExtension NuGet package in your test project.
2. Use the provided fluent syntax to write expressive assertions in your unit tests.
3. Enjoy more readable and maintainable test code that empowers your testing efforts.

## Installation

Use NuGet Package Manager to install ShouldlyFluentExtension:

```cmd
Install-Package JNet.Util.ShouldlyFluentExtension
```

## Documentation and Contribution

For the latest updates, documentation, and contribution guidelines, visit our GitHub repository: [ShouldlyFluentExtension](https://github.com/jaider/ShouldlyFluentExtension).