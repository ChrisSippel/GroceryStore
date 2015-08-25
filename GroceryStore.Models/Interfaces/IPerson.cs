using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models.Interfaces
{
    /// <summary>
    /// The absolute base interface of all people that can be found in the system.
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// The unique identifier of the person.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// The first name of the person.
        /// </summary>
        string FirstName { get; }

        /// <summary>
        /// The middle name of the person.
        /// </summary>
        string MiddleName { get; }

        /// <summary>
        /// The last name of the person.
        /// </summary>
        string LastName { get; }
    }
}