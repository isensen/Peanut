using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smark.Data;
using NorthWind.DBModule;

namespace NorthWind.BusinessLogic
{
    public class SupplierService
    {
        public IList<Supplier> List()
        {
            return new Expression().List<Supplier>();
        }

        public IList<Supplier> List(Smark.Core.DataPage datapage)
        {
            Expression exp = new Expression();
            datapage.RecordCount = exp.Count<Supplier>();
            return exp.List<Supplier>(new Region(datapage.PageIndex, datapage.PageSize));
        }
    }
}
