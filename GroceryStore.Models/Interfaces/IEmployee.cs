using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Models.Interfaces
{
    /// <summary>
    /// The base interface for all employees in the system.
    /// </summary>
    public interface IEmployee : IPerson
    {
        /// <summary>
        /// The unique identifier of the employee.
        /// </summary>
        Guid EmployeeId { get; }

        /// <summary>
        /// The social insurance number of the employee.
        /// </summary>
        string SocialInsuranceNumber { get; }
    }
}
