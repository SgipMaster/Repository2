<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewState.aspx.cs" Inherits="State_ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<asp:Label ID="Label1" runat="server" Text="Hello" EnableViewState="false"/>
		<asp:TextBox ID="TextBox1" runat="server" Text="World!" EnableViewState="false"/>
		<asp:DropDownList ID="DropDownList1" runat="server" EnableViewState="false"/>
			<asp:ListItem 
    </div>
    </form>
</body>
</html>
