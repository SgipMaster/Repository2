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

public partial class State_MadLib2 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

		//check to se if we arrived at this page via a cross-page post from madlib1
		if (this.PreviousPage != null)
		{
			//access the nouns using the previous page property
			Session["Noun1"] = this.PreviousPage.noun1;
			Session["Noun2"] = this.PreviousPage.noun2;
			Session["Noun3"] = this.PreviousPage.noun3;
			Session["Noun4"] = this.PreviousPage.noun4;
			Session["Noun5"] = this.PreviousPage.noun5;
			Session["Noun6"] = this.PreviousPage.noun6;
			Session["Noun7"] = this.PreviousPage.noun7;
			Session["Noun8"] = this.PreviousPage.noun8;
			Session["Noun9"] = this.PreviousPage.noun9;
		}
		else
		{
			if (!this.IsPostBack)
				Response.Redirect("MadLib1.aspx");
		}
    }

	protected void btnNext_Click(object sender, EventArgs e)
	{
		//create a Query String parameter and pass theis to Madlib3.aspx
		string url = "MadLib3.aspx?";
		url += "adj1=" + txtAdj1.Text + "&";
		url += "adj2=" + txtAdj2.Text + "&";
		url += "adj3=" + txtAdj3.Text + "&";
		url += "adj4=" + txtAdj4.Text;

		Response.Redirect(url);
	}
}
