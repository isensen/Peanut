<%@ Page Language="C#" AutoEventWireup="true" %>
<%
    Root.Default view = (Root.Default)WebContext.Current.View;
 %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title></title>
</head>
<body>
   
    <div>
    <form method="post" action="Default.aspx">
    <p>Enter you Name:<input type="text" name="youname" /></p>
    <p><input type="submit" /></p>
   
    </form>
    <p><%=view.Data %></p>
    </div>
    
</body>
</html>
