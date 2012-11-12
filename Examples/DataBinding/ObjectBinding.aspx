<%@ Page Language="C#" AutoEventWireup="true" %>

<%
    Root.ObjectBinding view = (Root.ObjectBinding)WebContext.Current.View;
%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form action="ObjectBinding.aspx" method="post">
    <div>
        <p>
            UserName:<input type="text" name="UserName" value="" /></p>
        <p>
            Gender:<select name="Gender">
                <option value="Female" selected="selected">Female</option>
                <option value="Male">Male</option>
            </select></p>
        <p>
            PassWord:<input type="text" name="PassWord" value="" /></p>
        <p>
            Email:<input type="text" name="Email" value="" /></p>
        <p>
            <input type="submit" /></p>
    </div>
    </form>
    <%if (WebContext.Current.RequestType == RequestType.POST)
      { %>
    <p>
        UserName:<%=view.User.UserName %></p>
    <p>
        Gender:<%=view.User.Gender%></p>
    <p>
        PassWord:<%=view.User.PassWord%></p>
    <p>
        Email:<%=view.User.Email%></p>
    <%} %>
</body>
</html>
