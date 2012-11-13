using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smark.Data;
namespace NorthWind.BusinessLogic
{
    public class CustomerService
    {
        public IList<DBModule.Customer> List()
        {
            return new Expression().List<DBModule.Customer>();
        }
    }
}
