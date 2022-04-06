<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 382px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblID" runat="server" Text="id" width="68px"></asp:Label>
            <asp:TextBox ID="idTxtBox" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <br />
        <asp:Label ID="lblDate" runat="server" Text="date added"></asp:Label>
        <asp:TextBox ID="dateTxtBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <p>
            <asp:Label ID="lblName" runat="server" Text="name" width="68px"></asp:Label>
            <asp:TextBox ID="nameTxtBox" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="lblPass" runat="server" Text="pass" width="68px"></asp:Label>
        <asp:TextBox ID="passTxtBox" runat="server" OnTextChanged="passTxtBox_TextChanged"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="email" width="68px"></asp:Label>
            <asp:TextBox ID="mailTxtBox" runat="server" OnTextChanged="mailTxtBox_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="checkExist" runat="server" Text="Account Exists" OnCheckedChanged="checkExist_CheckedChanged" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
