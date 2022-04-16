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
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <p class="auto-style1">
            <asp:Label ID="lblSupplier" runat="server" Text="SupplierId"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtId" runat="server" height="35px" style="z-index: 2; left: 409px; top: 80px; position: absolute; margin-left: 13px; margin-top: 0px" width="308px"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" Text="Name" width="105px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server" height="35px" style="z-index: 2; left: 382px; top: 182px; position: absolute; margin-left: 43px; margin-top: 0px" width="308px"></asp:TextBox>
        <p class="auto-style1">
            <asp:Label runat="server" Text="Email" width="105px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server" height="35px" style="z-index: 2; left: 357px; top: 254px; position: absolute; margin-left: 71px; margin-top: 0px" width="308px"></asp:TextBox>
&nbsp;&nbsp;
        </p>
        <p class="auto-style1">
            <asp:Label ID="Label2" runat="server" Text="ProductDescription" width="105px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProductDescription" runat="server" style="z-index: 2; left: 352px; top: 310px; position: absolute; margin-left: 70px; margin-top: 0px; height: 35px; width: 308px; margin-bottom: 26px;"></asp:TextBox>
        </p>
        <p class="auto-style1" style="width: 105px; height: 31px">
            Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuantity" runat="server" height="35px" style="z-index: 2; left: 208px; top: 396px; position: absolute; margin-left: 214px; margin-top: 0px" width="308px"></asp:TextBox>
        </p>
        <br />
        <asp:Label ID="Label3" runat="server" Text="DateAvailable"></asp:Label>
        <asp:TextBox ID="txtDateAvailable" runat="server" height="41px" style="z-index: 1; margin-left: 396px; margin-top: 0px" width="230px"></asp:TextBox>
        <p id="Availability">
            <asp:CheckBox ID="chkAvailability" runat="server" Text="Availability" width="105px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <asp:Label ID="lblError" runat="server" Text="Label" width="105px"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" Height="74px" style="margin-left: 222px; margin-top: 59px" Text="Cancel" width="217px" />
            <asp:Button ID="btnOk" runat="server" Height="66px" OnClick="btnOk_Click" style="margin-left: 448px" Text="Ok" Width="172px" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
