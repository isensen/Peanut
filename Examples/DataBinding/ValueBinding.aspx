<%@ Page Language="C#" AutoEventWireup="true" %>

<%
    Root.ValueBinding view = (Root.ValueBinding)WebContext.Current.View;  
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <form action="ValueBinding.aspx" method="post">
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
    <%if (WebContext.Current.RequestType == RequestType.POST) { %>
      <p>
            UserName:<%=view.UserName %></p>
        <p>
            Gender:<%=view.Gender %></p>
        <p>
            PassWord:<%=view.PassWord %></p>
        <p>
            Email:<%=view.EMail %></p>
    <%} %>
</body>
</html>
