# Two10.CountryLookup

[![Build status](https://ci.appveyor.com/api/projects/status/jufukg89x92nh5v2?svg=true)](https://ci.appveyor.com/project/richorama/two10-countrylookup)

## Installation

```
> Install-Package Two10.CountryLookup
```

## Usage

```c#
var lookup = new ReverseLookup();

var country = lookup.Lookup(55.3781f, -3.4360f);
Console.WriteLine(country.Name);
var ocean = lookup.Lookup(0.0f, 0.0f);
Console.WriteLine(ocean.Name);

```

Creating a ReverseLookup object is expensive, so it's worth keeping it as a singleton.

## Note
This is an update to the repo for usage with .NET 8.

## License

MIT
