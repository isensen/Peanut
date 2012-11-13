using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smark.Data.Mappings;
namespace NorthWind.DBModule
{
    [Table("Employees")]
    public interface IEmployee
    {
        [ID]
        [IDENTITY]
        int EmployeeID { get; set; }
        [Column]
        string LastName { get; set; }
        [Column]
        string FirstName { get; set; }
        [Column]
        string Title { get; set; }
        [Column]
        string TitleOfCourtesy { get; set; }
        [Column]
        DateTime BirthDate { get; set; }
        [Column]
        DateTime HireDate { get; set; }
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
        string HomePhone { get; set; }
        [Column]
        string Extension { get; set; }
        [Column]
        string Photo { get; set; }
        [Column]
        string Notes { get; set; }
        [Column]
        int ReportsTo { get; set; }
        
    }
}
