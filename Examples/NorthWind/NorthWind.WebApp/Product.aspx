<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <%
        Root.Product view = (Root.Product)WebContext.Current.View;
    %>
    <fieldset style="width: 400px;">
        <legend>Product</legend>
        <p>
            <label>
                ProductID:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.ProductID) %></p>
        <p>
            <label>
                Product Name:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.ProductName) %></p>
        <p>
            <label>
                Supplier:</label>
                <select>
                <%HtmlHelper.Each<Supplier>(view.Suppliers, (i, item) => {%>
                  <%=HtmlHelper.Option(item.CompanyName, item.SupplierID.ToString(), item.SupplierID == view.Item.SupplierID)%>    
                <% }); %>
                </select>
                </p>
        <p>
            <label>
                Category:</label> <select>
                <%HtmlHelper.Each<Category>(view.Categories, (i, item) =>
                  {%>
                  <%=HtmlHelper.Option(item.CategoryName,item.CategoryID.ToString(),item.CategoryID == view.Item.CategoryID) %>
                  <%}); %>
                  </select>
                </p>
        <p>
            <label>
                Quantity Per Unit:</label>
                <%=HtmlHelper.Input(InputType.text,null).Value(view.Item.QuantityPerUnit) %>
                </p>
        <p>
            <label>
                Unit Price:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.UnitPrice) %></p>
        <p>
            <label>
                Units In Stock:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.UnitsInStock) %></p>
        <p>
            <label>
                Units On Order:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.UnitsOnOrder) %></p>
        <p>
            <label>
                Record Level:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.ReorderLevel) %></p>
        <p>
            <label>
                Discontinued:</label><%=HtmlHelper.Input(InputType.checkbox,null).Checked(view.Item.Discontinued) %></p>
    </fieldset>
     <% HtmlHelper.Include(this, "~/webcontrol/pagebar.ascx"); %>
</asp:Content>
