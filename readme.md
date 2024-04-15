# Two10.CountryLookup

[![Build status](https://ci.appveyor.com/api/projects/status/jufukg89x92nh5v2?svg=true)](https://ci.appveyor.com/project/richorama/two10-countrylookup)

## Installation

```
> Install-Package Two10.CountryLookup
```

## Usage

```c#
var lookup = new ReverseLookup();

// look up a country by lat / lng
var country = lookup(52.0, 2.0);
Console.WriteLine(country.Name); // "United Kingdon"

var ocean = lookup(0,0);
Console.WriteLine(ocean.Name); // "North Atlantic Ocean"

```

Creating a ReverseLookup object is expensive, so it's worth keeping it as a singleton.

## Note
This is an update to the repo for usage with .NET 8.

## License

MIT
