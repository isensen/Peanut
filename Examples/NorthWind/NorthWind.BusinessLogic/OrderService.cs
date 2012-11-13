using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smark.Data;
using Smark.Core;
namespace NorthWind.BusinessLogic
{
    public class OrderService
    {
        public IList<DBModule.Order> List()
        {
            return new Expression().List<DBModule.Order>();
        }
        public IList<DBModule.Order> List(IDataPage datapage)
        {
            Expression exp = new Expression();
            datapage.RecordCount = exp.Count<DBModule.Order>();
            return exp.List<DBModule.Order>(new Region(datapage.PageIndex, datapage.PageSize));

        }
        public IList<DBModule.Views.OrderDetail> GetDetail(int orderid)
        {
            return (DBModule.OrderDetail.orderID == orderid).List<DBModule.Views.OrderDetail>();
        }
    }
}
