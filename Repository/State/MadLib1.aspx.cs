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

public partial class State_MadLib1 : System.Web.UI.Page
{
	//Create 9 public properties to give access to the text boxes in madlib2
	public string noun1 { get { return txtNoun1.Text; } }
	public string noun2 { get { return txtNoun2.Text; } }
	public string noun3 { get { return txtNoun3.Text; } }
	public string noun4 { get { return txtNoun4.Text; } }
	public string noun5 { get { return txtNoun5.Text; } }
	public string noun6 { get { return txtNoun6.Text; } }
	public string noun7 { get { return txtNoun7.Text; } }
	public string noun8 { get { return txtNoun8.Text; } }
	public string noun9 { get { return txtNoun9.Text; } }

	protected void Page_Load(object sender, EventArgs e)
    {

    }
}
