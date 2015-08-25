using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryStore.Models.Implementations;
using Xunit;

namespace GroceryStore.Model.UnitTests
{
    public class WalmartFullTimeEmployeeUnitTests
    {
        [Fact]
        public void WalmartFullTimeEmployeeUnitTests_Construct_Success()
        {
            const uint SALARY = 10;
            const string SIN = "123abc";
            const string FIRST_NAME = "Bob";
            const string MIDDLE_NAME = "Rum";
            const string LAST_NAME = "Doyle";
            var fullTimeEmployee = new WalmartFullTimeEmployee(SALARY, SIN, FIRST_NAME, MIDDLE_NAME, LAST_NAME);
            Assert.Equal(SALARY, fullTimeEmployee.Salary);
            Assert.Equal(SIN, fullTimeEmployee.SocialInsuranceNumber);
            Assert.Equal(FIRST_NAME, fullTimeEmployee.FirstName);
            Assert.Equal(MIDDLE_NAME, fullTimeEmployee.MiddleName);
            Assert.Equal(LAST_NAME, fullTimeEmployee.LastName);
        }
    }
}
