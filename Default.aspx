<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        *{margin:0;border:0;list-style:none;}
        .center{
            text-align:center
        }
        .auto-style1 {
            margin-top: 0;
        }
        #logo{
            width:1180px;
            height:125px;
            margin:0 auto;
            text-align:center;
            
        }
        .logo{
            display:flex;
        }

        .auto-style2 {
            height: 251px;
            width: 244px;
        }
        #my {
            width:1190px;
            text-align:center;
            margin:20px auto 0 auto;
            float:left;
        }
        #ImageButton1{
            display:inline-block;
            top:0px;
        }
        #ImageButton2{
            display:inline-block;
            top:0px;
        }
        #ImageButton3{
            display:inline-block;
            top:0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            
    </div>
      
       <div class="center">   <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="280px" BorderColor="#FF3300" BorderWidth="1px" Font-Size="Large" OnTextChanged="TextBox1_TextChanged" Wrap="False"></asp:TextBox>    
           <asp:Button ID="Button1" runat="server" BackColor="#FF3300" BorderColor="White" CssClass="auto-style1" Font-Names="Arial Black" Font-Size="Large" ForeColor="White" Height="29px" OnClick="Button1_Click" Text="搜索" Width="67px" />
           <button><a href ='over.aspx'>结算</a></button>
        </div>
         
        <div id="logo" class="auto-style2"> 
          
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/apple.jpg" OnClick="ImageButton1_Click" />
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/samsung.png" OnClick="ImageButton2_Click" />
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/xiaomi.png" OnClick="ImageButton3_Click" />
          
            <br />
            <br />
          
         </div>

  
         
    </form>
      
      <div id="my" runat="server">
          <%=strHTML%>                                                                           <!--razor -->                                                                  
      </div>
</body>
</html>
