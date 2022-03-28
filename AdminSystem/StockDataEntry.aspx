<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblID" runat="server" Text="ID" width="100px"></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <p>
            <asp:Label ID="lblItemDesc" runat="server" Text="Item Description" width="100px"></asp:Label>
            <asp:TextBox ID="txtItemDesc" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblItemPrice" runat="server" Text="Item Price" width="100px"></asp:Label>
        <asp:TextBox ID="txtItemPrice" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblItemAmount" runat="server" Text="Item Amount" width="100px"></asp:Label>
            <asp:TextBox ID="txtItemAmount" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblNextShipment" runat="server" Text="Next Shipment" width="100px"></asp:Label>
            <asp:TextBox ID="txtNextShipment" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
