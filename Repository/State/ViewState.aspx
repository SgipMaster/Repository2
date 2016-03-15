<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewState.aspx.cs" Inherits="State_ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View State</title>
</head>
<body style="height: 352px">
    <form id="form1" runat="server">
    <div>
		<asp:Label ID="Label1" runat="server" Text="Hello" EnableViewState="false"/>
		
    </div>
    	<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Change the Text of the Label" />
		<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Change the ForeColor" />
		<p>
		<asp:TextBox ID="TextBox1" runat="server" Text="World!" EnableViewState="false"/>
		</p>
		<p>
			<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Change Text of the TextBox" />
			<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Change ReadOnly" />
		</p>
		<p>
		<asp:DropDownList ID="DropDownList1" runat="server" EnableViewState="false">
			<asp:ListItem Value="0" Text="Hello" />
			<asp:ListItem Value="1" Text="World" />
			<asp:ListItem Value="2" Text="!" />
		</asp:DropDownList>
		
    	</p>
    	<p>
			<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Change the Selected Index of the Dropdown List" />
			<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Change the Back Color" />
		
    	</p>
		<p>
			<asp:Button ID="Button3" runat="server" Text="PostBack the Page" OnClick="Button3_Click" />
		</p>
		<p>
			<asp:Label ID="lblCounter" runat="server"	></asp:Label>
		</p>
		<p>
			&nbsp;</p>
		<p>
			&nbsp;</p>
    </form>
</body>
</html>
