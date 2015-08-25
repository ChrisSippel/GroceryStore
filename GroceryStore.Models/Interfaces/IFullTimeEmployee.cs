using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models.Interfaces
{
    /// <summary>
    /// The interface that describes a full time employee.
    /// </summary>
    interface IFullTimeEmployee : IEmployee
    {
        /// <summary>
        /// How much money the employee makes a year.
        /// </summary>
        uint Salary { get; }
    }
}
