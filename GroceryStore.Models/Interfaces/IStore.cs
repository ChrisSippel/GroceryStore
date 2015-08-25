using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models.Interfaces
{
    /// <summary>
    /// The absolute base of all stores in the system.
    /// </summary>
    interface IStore
    {
        /// <summary>
        /// All of the employees that work at the store.
        /// </summary>
        IEnumerable<IEmployee> Employees { get; }

        /// <summary>
        /// The name of the store.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The street the store is located on.
        /// </summary>
        string Street { get; }

        /// <summary>
        /// The street number of the store.
        /// </summary>
        int AddressNumber { get; }

        /// <summary>
        /// The city the store is in.
        /// </summary>
        string City { get; }

        /// <summary>
        /// The province the store is in.
        /// </summary>
        string Province { get; }

        /// <summary>
        /// The country the store is in.
        /// </summary>
        string Country { get; }

        /// <summary>
        /// The continent the store is in.
        /// </summary>
        string Continent { get; }
        
        /// <summary>
        /// The latitude position of the store.
        /// </summary>
        decimal Latitude { get; }

        /// <summary>
        /// The longitude position of the store.
        /// </summary>
        decimal Longitude { get; }
    }
}
