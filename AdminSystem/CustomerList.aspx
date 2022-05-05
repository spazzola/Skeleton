<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" Height="152px" Width="223px"></asp:ListBox>
        <p>
            <asp:Button ID="AddBtn" runat="server" OnClick="Button1_Click" Text="Add" />
            <asp:Button ID="EditBtn" runat="server" Text="Edit" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
    </form>
</body>
</html>
