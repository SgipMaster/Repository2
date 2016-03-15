<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SingleDataBinding.aspx.cs" Inherits="DataBinding_SingleDataBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Single Data Binding</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<asp:Label ID="Time" runat="server" Text="<%# DateTime.Now.ToLongTimeString() %>"></asp:Label><br /><br />
		<asp:Label ID="Label1" runat="server" Text="<%# URL %>"></asp:Label><br /><br />
		<asp:CheckBox ID="CheckBox1" runat="server" Text="<%# URL %>"/><br /><br />
		<asp:HyperLink ID="HyperLink1" runat="server" Text="Click here it's not a trick" NavigateUrl="<%# URL %>"></asp:HyperLink><br /><br />
		<asp:Image ID="Image1" runat="server" ImageUrl="<%# URL %>"/>
    </div>
    </form>
</body>
</html>
