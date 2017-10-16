<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Show.aspx.cs" Inherits="Show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <h1>商品详情</h1>
 <button><a href ='over.aspx'>结算</a></button>
      <div id="my" runat="server">
          <%=strrHTML%>                                                                           <!--razor -->                                                                  
      </div>

    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="加入购物车" />
    </form>
</body>
</html>
