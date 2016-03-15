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

public partial class State_MadLibFinal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		//retrieve values of nouns
		lblNoun1.Text = Session["Noun1"].ToString();
		lblNoun2.Text = Session["Noun2"].ToString();
		lblNoun3.Text = Session["Noun3"].ToString();
		lblNoun4.Text = Session["Noun4"].ToString();
		lblNoun5.Text = Session["Noun5"].ToString();
		lblNoun6.Text = Session["Noun6"].ToString();
		lblNoun7.Text = Session["Noun7"].ToString();
		lblNoun8.Text = Session["Noun8"].ToString();
		lblNoun9.Text = Session["Noun9"].ToString();

		//Retrieve values of adjectives
		lblAdj1.Text = Session["Adj1"].ToString();
		lblAdj2.Text = Session["Adj2"].ToString();
		lblAdj3.Text = Session["Adj3"].ToString();
		lblAdj4.Text = Session["Adj4"].ToString();
	
		//Retrieve Values of verbs from cookie
		HttpCookie cookie = Request.Cookies["Verbs"];
		lblVerb1.Text = cookie["Verb1"];
		lblVerb2.Text = cookie["Verb2"];
		lblVerb3.Text = cookie["Verb3"];
		lblVerb4.Text = cookie["Verb4"];
		lblVerb5.Text = cookie["Verb5"];
		lblVerb6.Text = cookie["Verb6"];
		lblVerb7.Text = cookie["Verb7"];
		lblVerb8.Text = cookie["Verb8"];
	}


	protected void btnStartOver_Click(object sender, EventArgs e)
	{
		Session.Abandon();
		Response.Redirect("~/State/MadLib1.aspx");
	}
}
