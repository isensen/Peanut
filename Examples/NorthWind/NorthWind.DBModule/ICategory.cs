using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smark.Data.Mappings;
namespace NorthWind.DBModule
{
    [Table("Categories")]
    public interface ICategory
    {
        [ID]
        [IDENTITY]
        int CategoryID { get; set; }

        [Column]
        string CategoryName { get; set; }

        [Column]
        string Description { get; set; }

        [Column]
        byte[] Picture { get; set; }
    }
}
