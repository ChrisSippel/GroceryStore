using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryStore.Models.Interfaces;

namespace GroceryStore.Models.Implementations
{
    /// <summary>
    /// A full time employee at Walmart
    /// </summary>
    public class WalmartFullTimeEmployee : IFullTimeEmployee
    {
        #region Properties

        /// <inheritdoc />
        public uint Salary
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public Guid EmployeeId
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public string SocialInsuranceNumber
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

        /// <inheritdoc />
        public string FirstName
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public string MiddleName
        {
            get;
            private set;
        }

        /// <inheritdoc />
        public string LastName
        {
            get;
            private set;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs a new <see cref="WalmartFullTimeEmployee"/> object.
        /// </summary>
        /// <param name="salary">The salary of the employee.</param>
        /// <param name="socialInsuranceNumber">The social insurance number of the employee.</param>
        /// <param name="firstName">The first name of the employee.</param>
        /// <param name="middleName">The middle name of the employee.</param>
        /// <param name="lastName">The last name of the employee.</param>
        public WalmartFullTimeEmployee(uint salary,
                                       string socialInsuranceNumber,
                                       string firstName,
                                       string middleName,
                                       string lastName)
        {
            Salary = salary;
            SocialInsuranceNumber = socialInsuranceNumber;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Id = new Guid();
            EmployeeId = new Guid();
        }

        #endregion
    }
}
