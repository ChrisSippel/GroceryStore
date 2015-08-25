using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryStore.Models.Interfaces;

namespace GroceryStore.Models.Implementations
{
    /// <summary>
    /// Walmart, you know, The Walmart.
    /// </summary>
    public class Walmart : IStore
    {
        #region Constructor

        /// <summary>
        /// Constructs a <see cref="Walmart"/> object.
        /// </summary>
        /// <param name="street">The street the Walmart resides on.</param>
        /// <param name="addressNumber">The street number of the Walmart.</param>
        /// <param name="city">The city the Walmart is in.</param>
        /// <param name="province">The province the Walmart is in.</param>
        /// <param name="continent">The continent is in.</param>
        /// <param name="latitude">The latitude of the store.</param>
        /// <param name="longitue">The longitude of the store.</param>
        public Walmart(string street, 
                       int addressNumber, 
                       string city, 
                       string province, 
                       string continent,
                       decimal latitude,
                       decimal longitue)
        {
            Employees = new List<IEmployee>();

            Name = "Walmart";
            Street = street;
            AddressNumber = addressNumber;
            City = city;
            Province = province;
            Continent = continent;
            Latitude = latitude;
            Longitude = longitue;
            Id = new Guid();
        }

        #endregion

        #region Properties

        /// <inheritdoc />
        public IEnumerable<IEmployee> Employees
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public string Name
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public string Street
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public int AddressNumber
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public string City
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public string Province
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public string Country
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public string Continent
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public decimal Latitude
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public decimal Longitude
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public Guid Id
        {
            get;
            private set;
        }

        #endregion
    }
}
