<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <%
        Root.Categories view = (Root.Categories)WebContext.Current.View;
    %>
   
    <fieldset  style="width:400px;"> <legend>Category</legend>
    <p><label>Name:</label><%=HtmlHelper.Input(InputType.text,"").Value(view.Item.CategoryName) %></p>
    <p><label>Description:</label><%=HtmlHelper.Input(InputType.text,"").Value(view.Item.Description) %></p>
    <div style="height:400px;overflow:scroll;">
        <fieldset style="width:350px;" ><legend>Products</legend>
    <%HtmlHelper.Each<Product>(view.Products, (i, item) => {%>
      <p><label>Product Name:</label><%=HtmlHelper.Input(InputType.text,"").Value(item.ProductName) %></p>
      <p><label>Quantity Per Unit:</label><%=HtmlHelper.Input(InputType.text,"").Value(item.QuantityPerUnit) %></p>
      <p><label>Discontinued:</label><%=HtmlHelper.Input(InputType.checkbox,"").Checked(item.Discontinued) %></p>
      <p><label>Unit Price:</label><%=HtmlHelper.Input(InputType.text,"").Value(item.UnitPrice) %></p>
      <hr />
      <%}); %>
      </fieldset>
      </div>
    </fieldset>


    <% HtmlHelper.Include(this, "~/webcontrol/pagebar.ascx"); %>
</asp:Content>
