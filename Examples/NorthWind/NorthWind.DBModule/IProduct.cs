using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smark.Data.Mappings;
namespace NorthWind.DBModule
{
    [Table("Products")]
    public interface IProduct
    {
        [ID]
        [IDENTITY]
        int ProductID { get; set; }
        [Column]
        string ProductName { get; set; }
        [Column]
        int SupplierID { get; set; }
        [Column]
        int CategoryID { get; set; }
        [Column]
        string QuantityPerUnit { get; set; }
        [Column]
        decimal UnitPrice { get; set; }
        [Column]
        int UnitsInStock { get; set; }
        [Column]
        int UnitsOnOrder { get; set; }
        [Column]
        int ReorderLevel { get; set; }
        [Column]
        bool Discontinued { get; set; }
    }
}
