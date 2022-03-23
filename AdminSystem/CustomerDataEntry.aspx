<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 382px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDate" runat="server" Text="date added"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblID" runat="server" Text="id"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblName" runat="server" Text="name"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPass" runat="server" Text="pass"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="email"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="checkExist" runat="server" Text="Account Exists" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
