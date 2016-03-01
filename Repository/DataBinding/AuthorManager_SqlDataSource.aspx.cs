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
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class AuthorManager : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
    {
        
    }

	protected void SqlDataSource2_Updated(object sender, SqlDataSourceStatusEventArgs e)
	{
		//refresh drop down list
		lstAuthor.DataBind();
	}

	protected void SqlDataSource2_Inserted(object sender, SqlDataSourceStatusEventArgs e)
	{
		lstAuthor.DataBind();
	}

	protected void SqlDataSource2_Deleted(object sender, SqlDataSourceStatusEventArgs e)
	{
		lstAuthor.DataBind();
	}
}
