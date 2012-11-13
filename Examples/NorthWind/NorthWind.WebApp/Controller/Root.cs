using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthWind.BusinessLogic;
using NorthWind.DBModule;
using Smark.Data;
namespace NorthWind.WebApp.Controller
{
    [Peanut.Controller]
    [Codes.InitConnection]
    public class Root
    {
        public class Categories : Peanut.IView
        {

            public Smark.Core.DataPage DataPage
            {
                get;
                set;
            }

            public Category Item
            {
                get;
                set;
            }

            public IList<DBModule.Product> Products
            {
                get;
                set;
            }

            public object Execute(Peanut.RequestType type)
            {
                DataPage.PageSize = 1;
                if (DataPage.PageIndex < 0)
                    DataPage.PageIndex = 0;

                IList<Category> items = Codes.Service.Category.List(DataPage);
                if (items.Count > 0)
                    Item = items[0];
                Products = Codes.Service.Product.ListAtCategory(Item.CategoryID);
                return this;
            }
        }

        public class Orders : Peanut.IView
        {
            public Smark.Core.DataPage DataPage
            {
                get;
                set;
            }

            public Order Item
            {
                get;
                set;
            }

            public IList<Employee> Employees
            {
                get;
                set;
            }

            public IList<Customer> Customers
            {
                get;
                set;
            }

            public IList<DBModule.Views.OrderDetail> Details
            {
                get;
                set;
            }

            public object Execute(Peanut.RequestType type)
            {
                DataPage.PageSize = 1;
                if (DataPage.PageIndex < 0)
                    DataPage.PageIndex = 0;
                IList<DBModule.Order> items = Codes.Service.Order.List(DataPage);
                if (items.Count > 0)
                    Item = items[0];
                Employees = Codes.Service.Employee.List();
                Customers = Codes.Service.Customer.List();
                Details = Codes.Service.Order.GetDetail(Item.OrderID);
                return this;
            }
        }

        public class Product : Peanut.IView
        {
            public Smark.Core.DataPage DataPage
            {
                get;
                set;
            }

            public DBModule.Product Item
            {
                get;
                set;
            }

            public IList<DBModule.Supplier> Suppliers
            {
                get;
                set;
            }

            public IList<DBModule.Category> Categories
            {
                get;
                set;
            }

            public object Execute(Peanut.RequestType type)
            {
                DataPage.PageSize = 1;
                if (DataPage.PageIndex < 0)
                    DataPage.PageIndex = 0;
                IList<DBModule.Product> items = Codes.Service.Product.List(DataPage);
                if (items.Count > 0)
                    Item = items[0];
                Suppliers = Codes.Service.Supplier.List();
                Categories = Codes.Service.Category.List();
                return this;
            }
        }

        public class Suppliers : Peanut.IView
        {
            public Smark.Core.DataPage DataPage
            {
                get;
                set;
            }
            
            public DBModule.Supplier Item
            {
                get;
                set;
            }

            public object Execute(Peanut.RequestType type)
            {
                DataPage.PageSize = 1;
                if (DataPage.PageIndex < 0)
                    DataPage.PageIndex = 0;
                IList<DBModule.Supplier> items = Codes.Service.Supplier.List(DataPage);
                if (items.Count > 0)
                    Item = items[0];
                return this;
            }
        }
    }
}