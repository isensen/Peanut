using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthWind.DBModule;
using Smark.Data;
namespace NorthWind.BusinessLogic
{
    public class CategoryService
    {
        public IList<Category> List()
        {
            return new Expression().List<Category>();
        }
        public IList<Category> List(Smark.Core.DataPage datapage)
        {
            Expression exp = new Expression();
            datapage.RecordCount = exp.Count<Category>();
            return exp.List<Category>(new Region(datapage.PageIndex, datapage.PageSize));
        }
        public Category Load(int id)
        {
           
            return id.Load<Category>();
        }


    }
}
