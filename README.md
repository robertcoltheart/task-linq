# TaskLinq

[![NuGet](https://img.shields.io/nuget/v/TaskLinq?style=for-the-badge)](https://www.nuget.org/packages/TaskLinq) [![License](https://img.shields.io/github/license/robertcoltheart/task-linq?style=for-the-badge)](https://github.com/robertcoltheart/task-linq/blob/master/LICENSE)

`TaskLinq` enables you to use method-chaining of LINQ methods when returning enumerable objects from an async method.

`IEnumerable<T>`, `List<T>`, and `T[]` are all supported natively. For other enumerable types, you can call `AsEnumerableAsync()` to continue using the chained methods.

## Usage
Install the package from NuGet with `dotnet add package TaskLinq`.

Instead of doing this:

```csharp
var values = (await GetValuesAsync()).ToArray();
```

you can do this:

```csharp
var values = await GetValuesAsync().ToArrayAsync();
```

You can also chain LINQ methods together and `await` the entire chain:

```csharp
var values = await GetValuesAsync()
    .WhereAsync(x => x > 1)
    .OrderByAsync(x => x)
    .ToArrayAsync();
```

For a custom type inheriting `IEnumerable<T>`, you can use `AsEnumerableAsync` and continue method-chaining:

```csharp
var values = await GetMyCustomCollection()
    .AsEnumerableAsync()
    .ToArrayAsync();
```

## Get in touch
Raise an [issue](https://github.com/robertcoltheart/task-linq/issues).

## Contributing
Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on how to contribute to this project.

## License
TaskLinq is released under the [MIT License](LICENSE)
