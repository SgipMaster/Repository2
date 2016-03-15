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
	protected void Page_PreRender(object sender, EventArgs e)
    {
		DropDownList1.SelectedValue = (string)Session["Theme"];
	}

	protected void Page_PreInit(object sender, EventArgs e)
	{
		if (Session["Theme"] == null || Session["Theme"].ToString() == "None")
			Page.Theme = "";
		else
			Page.Theme = Session["Theme"].ToString();
			
	}
	
	protected void SelectedIndex_Change(object sender, EventArgs e)
	{
		Session["Theme"] = DropDownList1.SelectedValue;
		Response.Redirect(Request.Path);
	}
}
