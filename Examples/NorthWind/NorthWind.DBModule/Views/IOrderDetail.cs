using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smark.Data.Mappings;
namespace NorthWind.DBModule.Views
{
    [Table("[Order Details] inner join Products on [Order Details].Productid=Products.ProductID")]
    public interface IOrderDetail
    {
        [Column]
        int OrderID { get; set; }
        [Column("Products.ProductID")]
        int ProductID { get; set; }
        [Column]
        string ProductName { get; set; }
       
        [Column("[Order Details].ProductID")]
        decimal UnitPrice { get; set; }
        [Column]
        int Quantity { get; set; }
        [Column]
        float Discount { get; set; }
    }
}
