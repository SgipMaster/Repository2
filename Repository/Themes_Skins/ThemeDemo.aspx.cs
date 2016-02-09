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
	private string themename;

    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

	protected void Page_PreInit(object sender, EventArgs e)
	{
		string theme;
		theme = Request.QueryString[themename];
		if (theme != "None")
			Page.Theme = theme;
	}

	protected void Change_Theme(object sender, EventArgs e)
	{
		themename = e.ToString();
	}
}
