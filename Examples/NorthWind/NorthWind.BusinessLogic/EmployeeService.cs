using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smark.Data;
using NorthWind.DBModule;
namespace NorthWind.BusinessLogic
{
    public class EmployeeService
    {
        public IList<Employee> List()
        {
            return new Expression().List<Employee>();
        }
    }
}
