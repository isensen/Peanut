<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <%
        Root.Suppliers view = (Root.Suppliers)WebContext.Current.View;
    %>
    <fieldset style="width: 400px;">
        <legend>Supplier</legend>
        <p>
            <label>
                Supper ID:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.SupplierID) %></p>
        <p>
            <label>
                Company Name:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.CompanyName) %></p>
        <p>
            <label>
                Contact Name:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.ContactName) %></p>
        <p>
            <label>
                Title:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.ContactTitle) %></p>
        <p>
            <label>
                Address:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.Address) %></p>
        <p>
            <label>
                City:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.City) %></p>
        <p>
            <label>
                Region:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.Region) %></p>
        <p>
            <label>
                Post Code:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.PostalCode) %></p>
        <p>
            <label>
                Country:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.Country) %></p>
        <p>
            <label>
                Phone:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.Phone) %></p>
        <p>
            <label>
                Fax:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.Fax) %></p>
        <p>
            <label>
                Home:</label><%=HtmlHelper.Input(InputType.text,null).Value(view.Item.HomePage) %></p>
    </fieldset>
     <% HtmlHelper.Include(this, "~/webcontrol/pagebar.ascx"); %>
</asp:Content>
