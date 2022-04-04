<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    Order entry page
    <form id="form1" runat="server">
        <div>
            
        
            <asp:CheckBox ID="cbIsDelivered" runat="server" Text="Is Delivered" />
            <br />
            <br />
            OrderID<asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderNo" runat="server" Text="Order Number"></asp:Label>
            <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" />
            <br />
            <br />
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="160px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDatePurchased" runat="server" Text="Date Purchased" width="160px"></asp:Label>
            <asp:TextBox ID="txtDatePurchased" runat="server" OnTextChanged="txtDatePurchased_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" width="160px"></asp:Label>
&nbsp;<asp:Label ID="lblTotalPriceOutput" runat="server" Text="lblTotalPriceOutput"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel"  />
            <br />
            
        
        </div>
        
    </form>
</body>
</html>
