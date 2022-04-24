<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #CAEEFF">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstSupplierList" runat="server" Height="256px" Width="320px" BackColor="#FFCC99" ForeColor="Black"></asp:ListBox>
        &nbsp;
        <p>
            <asp:Button ID="btnAdd" runat="server" Height="24px" OnClick="btnAdd_Click" Text="Add" Width="30px" ForeColor="#008040" />
            &nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="Button1_Click" Text="Edit" />
            &nbsp;&nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" ForeColor="#CC3300" Height="27px" Width="42px" />
        </p>
        <p>
            Enter a Name <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" Text="Apply" ForeColor="#008040" OnClick="btnApply_Click" />
&nbsp;<asp:Button ID="btnClear" runat="server" Text="Clear" ForeColor="#CC3300" OnClick="btnC_Click" />
        </p>
        <asp:Label runat="server" ID="lblError"></asp:Label>
    </form>
</body>
</html>
