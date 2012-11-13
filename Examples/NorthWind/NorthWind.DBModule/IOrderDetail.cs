using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smark.Data.Mappings;
namespace NorthWind.DBModule
{
    [Table("[Order Details]")]
    public interface IOrderDetail
    {
        [Column]
        int OrderID { get; set; }
        [Column]
        int ProductID { get; set; }
        [Column]
        decimal UnitPrice { get; set; }
        [Column]
        int Quantity { get; set; }
        [Column]
        float Discount { get; set; }
    }
}
