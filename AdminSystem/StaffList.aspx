<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="338px" Width="589px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblFullName" runat="server" Text="Enter a full name"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="Button1_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="Button2_Click" Text="Clear" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
