<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SoapFarm.aspx.cs" Inherits="ConsumingWebService.SoapFarm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="FirstNumber" runat="server"></asp:TextBox>
        </div>
          <div>
           <asp:TextBox ID="SecondNumber" runat="server"></asp:TextBox>
        </div>
          <div>
           <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Total"></asp:Label>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
    
</body>
</html>
