using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models.Interfaces
{
    /// <summary>
    /// The interface that describes a part time employee of the system.
    /// </summary>
    interface IPartTimeEmployee : IEmployee
    {
        /// <summary>
        /// How much money the employee makes per hour.
        /// </summary>
        decimal WagePerHour { get; }
    }
}
