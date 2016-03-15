<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RepeatedDataBinding.aspx.cs" Inherits="DataBinding_RepeatedDataBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Repeated Data Binding</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<h2>ListBox of 10 ints</h2>
		<asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
		<h2>Array List of our favorite foods</h2>
		<asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>
		<h2>Generic List of Bands</h2>
		<asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
		<h2>Dictionary of Months</h2>
		<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    </div>
    </form>
</body>
</html>
