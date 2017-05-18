<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignOut.aspx.cs" Inherits="password.UI.SignOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater runat="server" ID="childSites">
                <ItemTemplate>
                    <iframe src="<%#Eval("Url") %>"></iframe>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>


