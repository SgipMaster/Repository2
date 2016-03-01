using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class ThemeDemo : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
    {
		
	}

	protected void Page_PreInit(object sender, EventArgs e)
	{
		string theme;
		theme = (string)Session["Theme"];
		if (theme == "None")
		{
			Page.Theme = "";
		}
		else
			Page.Theme = theme;
	}
	
	protected void SelectedIndex_Change(object sender, EventArgs e)
	{
		Session["Theme"] = DropDownList1.SelectedValue;
	}
}
