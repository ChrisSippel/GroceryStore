using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryStore.Models.Implementations;
using Xunit;

namespace GroceryStore.Model.UnitTests
{
    public class WalmartUnitTests
    {
        [Fact]
        public void Walmart_Construct_Success()
        {
            const string STREET = "Fake St.";
            const int ADDRESS_NUMBER = 123;
            const string CITY = "Springfield";
            const string PROVINCE = "Ontario";
            const string CONTINENT = "North America";
            const decimal LATITUDE = 45.123456M;
            const decimal LONGITUDE = 95.789132M;

            var walmart = new Walmart(STREET, ADDRESS_NUMBER, CITY, PROVINCE, CONTINENT, LATITUDE, LONGITUDE);
            Assert.Equal(walmart.Street, STREET);
            Assert.Equal(walmart.AddressNumber, ADDRESS_NUMBER);
            Assert.Equal(walmart.City, CITY);
            Assert.Equal(walmart.Province, PROVINCE);
            Assert.Equal(walmart.Continent, CONTINENT);
            Assert.Equal(walmart.Latitude, LATITUDE);
            Assert.Equal(walmart.Longitude, LONGITUDE);
            Assert.Equal(walmart.Name, "Walmart");
        }
    }
}
