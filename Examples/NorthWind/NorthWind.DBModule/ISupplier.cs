﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smark.Data.Mappings;
namespace NorthWind.DBModule
{
    [Table("Suppliers")]
    public interface ISupplier
    {
        [ID]
        [IDENTITY]
        int SupplierID { get; set; }
        [Column]
        string CompanyName { get; set; }
        [Column]
        string ContactName { get; set; }
        [Column]
        string ContactTitle { get; set; }
        [Column]
        string Address { get; set; }
        [Column]
        string City { get; set; }
        [Column]
        string Region { get; set; }
        [Column]
        string PostalCode { get; set; }
        [Column]
        string Country { get; set; }
        [Column]
        string Phone { get; set; }
        [Column]
        string Fax { get; set; }
        [Column]
        string HomePage { get; set; }
    }
}
