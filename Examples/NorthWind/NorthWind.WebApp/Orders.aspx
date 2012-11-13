<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <%
        Root.Orders view = (Root.Orders)WebContext.Current.View;
        Customer ordercustomer = new Customer();
    %>
    <fieldset style="width: 560px">
        <legend>Product</legend>
        <fieldset style="float: left; width: 260px">
            <legend>Bill To</legend>
            <p>
                <label>
                </label>
                <select>
                    <%HtmlHelper.Each<Customer>(view.Customers, (i, c) =>
                      {
                          if (c.CustomerID == view.Item.CustomerID)
                              ordercustomer = c;
                    %>
                    <%=HtmlHelper.Option(c.CompanyName,c.CustomerID.ToString(),c.CustomerID == view.Item.CustomerID) %>
                    <%}); %>
                </select>
            </p>
            <p>
                <label>
                    Address:</label>
                <%=HtmlHelper.Input(InputType.text,null).Value(ordercustomer.Address) %></p>
            <p>
                <label>
                    City:</label><%=HtmlHelper.Input(InputType.text,null).Value(ordercustomer.City) %></p>
            <p>
                <label>
                    Region:</label><%=HtmlHelper.Input(InputType.text,null).Value(ordercustomer.Region) %></p>
            <p>
                <label>
                    PostalCode:</label><%=HtmlHelper.Input(InputType.text,null).Value(ordercustomer.PostalCode) %></p>
            <p>
                <label>
                    Country:</label>
                <%=HtmlHelper.Input(InputType.text,null).Value(ordercustomer.Country) %></p>
        </fieldset>
        <fieldset style="float: right; width: 260px">
            <legend>Ship To</legend>
            <p>
                <label>
                    Name:</label>
                <%=HtmlHelper.Input(InputType.text,null).Value(view.Item.ShipName) %></p>
            <p>
                <label>
                    Address:</label>
                <%=HtmlHelper.Input(InputType.text,null).Value(view.Item.ShipAddress) %></p>
            <p>
                <label>
                    City:</label><%=HtmlHelper.Input(InputType.text, null).Value(view.Item.ShipCity)%></p>
            <p>
                <label>
                    Region:</label><%=HtmlHelper.Input(InputType.text, null).Value(view.Item.ShipRegion)%></p>
            <p>
                <label>
                    PostalCode:</label><%=HtmlHelper.Input(InputType.text, null).Value(view.Item.ShipPostalCode)%></p>
            <p>
                <label>
                    Country:</label>
                <%=HtmlHelper.Input(InputType.text, null).Value(view.Item.ShipCountry)%></p>
        </fieldset>
        <div style="clear: both;" />
        <fieldset style="width: 544px">
            <p>
                <label>
                    Salesperson:</label>
                <select>
                    <%HtmlHelper.Each<Employee>(view.Employees, (i, c) =>
                      {
                    %>
                    <%=HtmlHelper.Option(c.FirstName+","+c.LastName,c.EmployeeID.ToString(),c.EmployeeID == view.Item.EmployeeID) %>
                    <%}); %>
                </select>
            </p>
            <p>
                <label>
                    OrderID:</label><%=HtmlHelper.Input(InputType.text, null).Value(view.Item.OrderID)%></p>
            <p>
                <label>
                    Order Date:</label><%=HtmlHelper.Input(InputType.text, null).Value(view.Item.OrderDate)%></p>
            <p>
                <label>
                    Required Date:</label><%=HtmlHelper.Input(InputType.text, null).Value(view.Item.RequiredDate)%></p>
            <p>
                <label>
                    Shipped Date:</label><%=HtmlHelper.Input(InputType.text, null).Value(view.Item.ShippedDate)%></p>
        </fieldset>
        <fieldset style="width: 544px">
            <legend>Detail</legend>
            <table>
            <tr><th>Product</th><th>Unit Price</th><th>Quantity</th><th>Discount</th><th>Extended Price</th></tr>
            <%HtmlHelper.Each<NorthWind.DBModule.Views.OrderDetail>(view.Details, (i, d) => { 
            %>
            <tr><td><%=d.ProductName %></td><td><%=d.UnitPrice %></td><td><%=d.Quantity %></td><td><%=d.Discount %></td><td><%=(d.UnitPrice*d.Quantity*(decimal)(1-d.Discount)) %></td></tr>
            <%
              }); %>
           
            </table>
        </fieldset>
    </fieldset>
    <% HtmlHelper.Include(this, "~/webcontrol/pagebar.ascx"); %>
</asp:Content>
