<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffId" runat="server" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <asp:Label ID="lblFullName" runat="server" Text="Staff Full Name"></asp:Label>
        <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSalary" runat="server" Text="Salary" width="202px"></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblLogin" runat="server" Text="Login" width="202px"></asp:Label>
        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password" width="202px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:Label ID="lblLastLogged" runat="server" Text="Last Logged"></asp:Label>
            <asp:TextBox ID="txtLastLogged" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:CheckBox ID="chkIsAdmin" runat="server" Text="Is an Admin" width="202px" />
        </p>
        <p style="margin-bottom: 172px">
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p style="margin-bottom: 172px">
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
