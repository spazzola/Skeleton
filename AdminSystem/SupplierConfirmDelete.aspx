﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?</div>
        <asp:Button ID="btnYes" runat="server" OnClick="Button1_Click" Text="Yes" />
&nbsp;<asp:Button ID="btnNo" runat="server" Text="No" />
    </form>
</body>
</html>
