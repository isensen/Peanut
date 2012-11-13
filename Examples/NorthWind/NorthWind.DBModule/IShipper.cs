using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smark.Data.Mappings;
namespace NorthWind.DBModule
{
    [Table("Shippers")]
    public interface IShipper
    {
        [ID]
        [IDENTITY]
        int ShipperID { get; set; }
        [Column]
        string CompanyName { get; set; }
        [Column]
        string Phone { get; set; }
    }
}
