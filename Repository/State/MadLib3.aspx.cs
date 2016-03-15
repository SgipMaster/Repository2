using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class State_MadLib3 : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (Session != null)
		{
			Session["Adj1"] = Request.QueryString["adj1"];
			Session["Adj2"] = Request.QueryString["adj2"];
			Session["Adj3"] = Request.QueryString["adj3"];
			Session["Adj4"] = Request.QueryString["adj4"];
		}
		
	}

	protected void btnNext_Click(object sender, EventArgs e)
	{
		//create cookie and add values to the cookie
		HttpCookie cookie = new HttpCookie("Verbs");
		cookie["Verb1"] = txtVerb1.Text;
		cookie["Verb2"] = txtVerb2.Text;
		cookie["Verb3"] = txtVerb3.Text;
		cookie["Verb4"] = txtVerb4.Text;
		cookie["Verb5"] = txtVerb5.Text;
		cookie["Verb6"] = txtVerb6.Text;
		cookie["Verb7"] = txtVerb7.Text;
		cookie["Verb8"] = txtVerb8.Text;

		//add cookie to cookies
		Response.Cookies.Add(cookie);
		
		Response.Redirect("~/State/MadLibFinal.aspx");
	}
}
