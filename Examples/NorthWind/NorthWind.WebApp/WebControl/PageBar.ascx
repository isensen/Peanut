<%@ Control Language="C#" AutoEventWireup="true"  %>
<%
    Smark.Core.DataPage dp = (Smark.Core.DataPage) WebContext.Current["datapage"];
    if (dp == null)
        dp = new DataPage(); 
                                    
     %>
     
<div class="pagebar">

<a class="ui-icon ui-icon-seek-start pagebarButton" href="<%=HtmlHelper.WriteDataPage(dp,"",0) %>" type="button"></a>
<a class="ui-icon ui-icon-seek-prev pagebarButton" type="button" href="<%=HtmlHelper.WriteDataPage(dp,"",dp.PageIndex-1) %>" ></a>
<input type="text" onfocus="$(this).val(pageindex)" onblur="changeOnBlur(this)" class="pagebarInput" value="Current:<%=dp.PageIndex+1 %>[All:<%=dp.PageCount%>]" />
<a class="ui-icon ui-icon-seek-next pagebarButton" href="<%=HtmlHelper.WriteDataPage(dp,"",dp.PageIndex+1) %>" type="button"></a>
<a class="ui-icon ui-icon-seek-end pagebarButton" type="button" href="<%= HtmlHelper.WriteDataPage(dp,"",dp.PageCount-1) %>"></a>

</div>
<script>
    function changeOnBlur(control)
    {
        if($(control).val()== pageindex)
        {
            $(control).val('Current:'+pageindex+'[All:'+pagecount+']')
        }
        else{
            window.location.href=page+"?pageindex=" +($(control).val()-1);
        }
    }
    var page ='<%=Request.FilePath %>';
    var pageindex=<%=dp.PageIndex+1 %>;
    var pagecount = <%=dp.PageCount %>;
    $(function () {
        $("a")
            .button();
    });
    </script>