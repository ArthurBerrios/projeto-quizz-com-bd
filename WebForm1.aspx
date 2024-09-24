<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PrjQuiz10.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;">
            <asp:Label ID="lblpergunta" runat="server" Text="QUIZZ" Font-Bold="True" Font-Names="Arial" Font-Size="Large"></asp:Label><br /><br />
            <asp:RadioButton ID="rdb1" runat="server"  GroupName="t" Font-Names="Arial"/><br /><br />
            <asp:RadioButton ID="rdb2" runat="server" GroupName="t" Font-Names="Arial"/><br /><br />
            <asp:RadioButton ID="rdb3" runat="server" GroupName="t" Font-Names="Arial"/><br /><br />
            <asp:RadioButton ID="rdb4" runat="server" GroupName="t" Font-Names="Arial"/><br /><br /><br />
            <asp:Button ID="btnEnviar" runat="server" Text="Próximo" OnClick="btnEnviar_Click"  Font-Names="Arial" Font-Bold="False" Height="25px" Width="90px" BackColor="Transparent" BorderColor="White" BorderStyle="None" />
        </div>
    </form>
</body>
</html>
