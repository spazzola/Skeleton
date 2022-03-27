<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body style="height: 423px; width: 1485px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p class="auto-style1">
            <asp:Label ID="tblSupplierId" runat="server" Text="Supplier Id"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSupplier" runat="server" height="35px" style="z-index: 1; left: 139px; top: 61px; position: absolute; margin-left: 13px; margin-top: 0px" width="308px"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" Text="Name" width="105px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server" height="35px" style="z-index: 1; left: 157px; top: 107px; position: absolute; margin-left: 43px; margin-top: 0px" width="308px"></asp:TextBox>
        <p class="auto-style1">
            <asp:Label runat="server" Text="Email" width="105px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server" height="35px" style="z-index: 1; left: 151px; top: 153px; position: absolute; margin-left: 71px; margin-top: 0px" width="308px"></asp:TextBox>
&nbsp;&nbsp;
        </p>
        <p class="auto-style1">
            <asp:Label ID="Label2" runat="server" Text="ProductDescription" width="105px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProductDescription" runat="server" height="29px" style="z-index: 1; left: 151px; top: 199px; position: absolute; margin-left: 70px; margin-top: 0px" width="230px"></asp:TextBox>
        </p>
        <p class="auto-style1" style="width: 105px; height: 31px">
            Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuantity" runat="server" height="35px" style="z-index: 1; left: 10px; top: 272px; position: absolute; margin-left: 214px; margin-top: 0px" width="308px"></asp:TextBox>
            <asp:Button ID="btnCancel" runat="server" Height="74px" style="margin-left: 222px; margin-top: 59px" Text="Cancel" width="217px" />
        </p>
        <p>
            <asp:CheckBox ID="chkAvailability" runat="server" Text="Availability" width="105px" />
            <asp:Button ID="btnOk" runat="server" Height="66px" OnClick="btnOk_Click" style="margin-left: 448px" Text="Ok" Width="327px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <asp:Label ID="lblError" runat="server" Text="Label" width="105px"></asp:Label>
        <br />
&nbsp;&nbsp;
    </form>
</body>
</html>
