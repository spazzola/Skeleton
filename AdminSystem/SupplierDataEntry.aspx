<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
        }
        #form1 {
            height: 430px;
            width: 325px;
        }
        .auto-style3 {
            font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
        }
    </style>
</head>
<body style="height: 935px; width: 1485px; font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; font-style: italic;">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" height="25px" style="background-color: #3399FF" width="70px" />
        </div>
        <p>
            <asp:Label ID="lblSupplierId" runat="server" Text="SupplierId" height="16px" width="100px" CssClass="auto-style3" style=""></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSupplierId" runat="server" height="22px" width="144px"></asp:TextBox>
        </p>
        <asp:Label ID="lblName" runat="server" Text="Name" width="125px" height="16px" CssClass="auto-style3" style=""></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server" height="22px" width="144px"></asp:TextBox>
        <p>
            <asp:Label runat="server" Text="Email" width="125px" height="16px" ID="lblEmail" CssClass="auto-style3" style=""></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server" height="16px" width="136px"></asp:TextBox>
            <asp:TextBox ID="txtProductDescription" runat="server" style="z-index: 2; left: 95px; top: 195px; position: absolute; margin-left: 70px; margin-top: 0px; height: 22px; width: 144px; margin-bottom: 26px;"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblProductDescription" runat="server" Text="ProductDescription" width="125px" Height="16px" CssClass="auto-style3" style=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblQuantity" runat="server" height="16px" Text="Quantity" width="125px" CssClass="auto-style3" style=""></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 165px; top: 255px; position: absolute; height: 22px;" width="144px"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateAvailable" runat="server" Text="DateAvailable" height="16px" width="125px" CssClass="auto-style3" style=""></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p id="Availability">
            <asp:CheckBox ID="chkAvailability" runat="server" Text="Availability" width="125px" height="16px" CssClass="auto-style3" style="" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDateAvailable" runat="server" style="z-index: 1; left: 160px; top: 295px; position: absolute; height: 22px;" width="144px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="btnOk_Click" height="24px" width="50px" />
&nbsp;
&nbsp;<asp:Button ID="btnCancel" runat="server" Height="26px" Text="Cancel" Width="48px" />
        </p>
        <asp:Label ID="lblError" runat="server" width="125px" CssClass="auto-style2" height="16px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
