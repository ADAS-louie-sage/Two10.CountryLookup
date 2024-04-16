using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Two10.CountryLookup.Abstractions;
using Two10.CountryLookup;
using FluentAssertions;

namespace Two10.CountryLookupUpdated.Tests
{
    public class CountryLookUpIntegrationTest
    {
        private readonly IReverseLookup _reverseLookup;

        public CountryLookUpIntegrationTest()
        {
            _reverseLookup = new ReverseLookup();
        }

        [Fact]
        public void TestDataLoad()
        {
            _reverseLookup.Regions.Length.Should().Be(394);

            foreach (var country in _reverseLookup.Regions)
            {
                country.Name.Should().NotBeNullOrEmpty();
                country.Code.Should().NotBeNullOrEmpty();
            }

            _reverseLookup.Regions.Should().Contain(x => x.Name == "United Kingdom");

            var ukResult = _reverseLookup.Lookup(52, 0);
            ukResult.Should().NotBeNull();
            ukResult.Name.Should().Be("United Kingdom");
        }
    }
}
