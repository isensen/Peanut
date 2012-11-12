<%@ Page Language="C#" AutoEventWireup="true" %>

<%
    Root.FileBinding view = (Root.FileBinding)WebContext.Current.View;  
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <form enctype="multipart/form-data" action="FileBinding.aspx" method="post">
    <p>
        <input type="file" name="file1" /></p>
    <p>
        <input type="file" name="file2" /></p>
    <p>
        <input type="file" name="file3" /></p>
    <p>
        <input type="file" name="file4" /></p>
    <p>
        <input type="submit" /></p>
    </form>
    <%if (WebContext.Current.RequestType == RequestType.POST) {
          foreach (Peanut.Binding.PostFile item in view.Files) { 
          %>
          <div>
          <p>Name:<%=item.FileName %></p>
          <p>Size:<%=item.Length %></p>
          </div>
          <%
          }
      } %>
</body>
</html>
