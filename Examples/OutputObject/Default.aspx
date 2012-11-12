<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
</head>
<body>
    <div>
        <p>
            UserName:<input id="UserName" type="text" name="UserName" value="" /></p>
        <p>
            Gender:<select name="Gender" id="Gender">
                <option value="Female" selected="selected">Female</option>
                <option value="Male">Male</option>
            </select></p>
        <p>
            PassWord:<input id="PassWord" type="text" name="PassWord" value="" /></p>
        <p>
            Email:<input id="Email" type="text" name="Email" value="" /></p>
        <p>
            <input type="button" onclick="PostData('xml')" value="Xml" /><input value="Json"
                type="button" onclick="PostData('josn')" /></p>
    </div>
    <div id="result">
    </div>
    <script>
        function PostData(type) {
            var data = {
                UserName: $('#UserName').val(),
                Gender: $('#Gender').val(),
                PassWord: $('#PassWord').val(),
                Email: $('#Email').val(),
                OutpuType:type
            }
            $.ajax({
                type: 'POST',
                url: 'Register.aspx',
                data: data,
                success: function (result) {
                    alert(result);
                }

            });
        }
    </script>
</body>
</html>
