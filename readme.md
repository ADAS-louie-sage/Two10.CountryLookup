# ADAS.CountryLookup

This is a migrated version of the Two10.CountryLookup package which is compatible with .net 8. The original package can be found here: https://github.com/two10degrees/Two10.CountryLookup

## Usage

```c#
var lookup = new ReverseLookup();

var country = lookup.Lookup(55.3781f, -3.4360f);
Console.WriteLine(country.Name);
var ocean = lookup.Lookup(0.0f, 0.0f);
Console.WriteLine(ocean.Name);

```

## License

MIT
