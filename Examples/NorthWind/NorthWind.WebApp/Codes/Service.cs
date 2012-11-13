using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthWind.WebApp.Codes
{
    public class Service
    {
        public static BusinessLogic.CategoryService Category = new BusinessLogic.CategoryService();

        public static BusinessLogic.ProductService Product = new BusinessLogic.ProductService();

        public static BusinessLogic.SupplierService Supplier = new BusinessLogic.SupplierService();

        public static BusinessLogic.OrderService Order = new BusinessLogic.OrderService();

        public static BusinessLogic.CustomerService Customer = new BusinessLogic.CustomerService();

        public static BusinessLogic.EmployeeService Employee = new BusinessLogic.EmployeeService();
    }
}