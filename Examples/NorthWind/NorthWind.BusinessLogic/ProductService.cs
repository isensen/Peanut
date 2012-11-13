using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthWind.DBModule;
using Smark.Data;
namespace NorthWind.BusinessLogic
{
    public class ProductService
    {
        public IList<Product> List()
        {
            return new Expression().List<Product>();
        }
        public IList<Product> List(Smark.Core.DataPage datapage)
        {
            Expression exp = new Expression();
            datapage.RecordCount = exp.Count<Product>();
            return exp.List<Product>(new Region(datapage.PageIndex, datapage.PageSize));
        }
        public IList<Product> ListAtCategory(int category)
        {
            return (Product.categoryID == category).List<Product>();
        }

    }
}
