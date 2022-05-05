<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
            margin-left: 40px;
        }
    </style>
</head>
<body>
    Order entry page
    <form id="form1" runat="server">
        <div class="auto-style1">
            
        
            <asp:CheckBox ID="cbIsDelivered" runat="server" Text="Is Delivered" />
            <br />
            <br />
            <asp:Label ID="LblOrderID" runat="server" Text="Order ID" width="128px"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" OnTextChanged="txtOrderID_TextChanged"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" />
            <br />
            <br />
            <asp:Label ID="lblOrderNo" runat="server" Text="Order Number" width="128px"></asp:Label>
            <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="128px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDatePurchased" runat="server" Text="Date Purchased" width="128px"></asp:Label>
            <asp:TextBox ID="txtDatePurchased" runat="server" OnTextChanged="txtDatePurchased_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" width="128px"></asp:Label>
            <asp:TextBox ID="txtTotalPrice" runat="server" style="margin-bottom: 0px"></asp:TextBox>
&nbsp;<br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]" width="57px"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click"  />
            <br />
            
        
        </div>
        
    </form>
</body>
</html>
