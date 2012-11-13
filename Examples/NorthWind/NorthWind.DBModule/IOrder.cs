using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smark.Data.Mappings;
namespace NorthWind.DBModule
{
    [Table("Orders")]
    public interface IOrder
    {
        [ID]
        [IDENTITY]
        int OrderID { get; set; }
        [Column]
        string CustomerID { get; set; }
        [Column]
        int EmployeeID { get; set; }
        [Column]
        DateTime OrderDate { get; set; }
        [Column]
        DateTime RequiredDate { get; set; }
        [Column]
        DateTime ShippedDate { get; set; }
        [Column]
        long ShipVia { get; set; }
        [Column]
        decimal Freight { get; set; }
        [Column]
        string ShipName { get; set; }
        [Column]
        string ShipAddress { get; set; }
        [Column]
        string ShipCity { get; set; }
        [Column]
        string ShipRegion { get; set; }
        [Column]
        string ShipPostalCode { get; set; }
        [Column]
        string ShipCountry { get; set; }
    }
}
