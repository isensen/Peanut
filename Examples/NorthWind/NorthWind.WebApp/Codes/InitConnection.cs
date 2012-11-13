using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Smark.Data;
namespace NorthWind.WebApp.Codes
{
    public class InitConnection:Peanut.FilterAttribute
    {
        static InitConnection()
        {
            DBContext.SetConnectionString(ConnectionType.Context1,
              string.Format(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source={0}App_Data\Northwind.mdb",
              HttpContext.Current.Request.PhysicalApplicationPath));
        }
        public override void Execute(Peanut.FilterContext context)
        {
            context.Execute();
        }
    }
}