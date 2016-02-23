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

	//Add a private string variable here that will hold the connection string from Web.Config
	//See Page 451
	private string connectionString = WebConfigurationManager.ConnectionStrings["Pubs"].ConnectionString;

	protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            FillAuthorList();
        }
    }

    private void FillAuthorList()
    {
        //This method should populate the lstAuthor DropDownList with the authors in the pubs database
        //Author names are shown as the text for each ListItem and author IDs are stored as the values
        //See Pages 451-452
		lstAuthor.Items.Clear();

		DataTable table = AuthorAccess.GetAllAuthorNames();

		foreach (DataRow row in table.Rows)
		{
			ListItem newItem = new ListItem();
			newItem.Text = row["au_lname"] + ", " + row["au_fname"];
			newItem.Value = row["au_id"].ToString();
			lstAuthor.Items.Add(newItem);
		}
    }

    protected void lstAuthor_SelectedIndexChanged(object sender, EventArgs e)
    {
		//This method retrieves all of the attributes of the selected author from the database and
		//populates the controls with these values
		//See page 455
		string selectSQL;
		selectSQL = "Select * FROM Authors ";
		selectSQL += "WHERE au_id='" + lstAuthor.SelectedItem.Value + "'";
		SqlConnection con = new SqlConnection(connectionString);
		SqlCommand cmd = new SqlCommand(selectSQL, con);
		SqlDataReader reader;

		try
		{
			con.Open();
			reader = cmd.ExecuteReader();
			reader.Read();

			txtID.Text = reader["au_id"].ToString();
			txtFirstName.Text = reader["au_fname"].ToString();
			txtLastName.Text = reader["au_lname"].ToString();
			txtPhone.Text = reader["phone"].ToString();
			txtAddress.Text = reader["address"].ToString();
			txtCity.Text = reader["city"].ToString();
			txtState.Text = reader["state"].ToString();
			txtZip.Text = reader["zip"].ToString();
			chkContract.Checked = (bool)reader["contract"];
			reader.Close();
			lblResults	.Text = "";
		}
		catch (Exception err)
		{
			lblResults.Text = "Error getting author. ";
			lblResults.Text += err.Message;
		}
		finally
		{
			con.Close();
		}
        
        
    }
    protected void cmdNew_Click(object sender, EventArgs e)
    {
		//This method clears the values in the controls so that a new author can be added
		//See page 456
		txtID.Text = "";
		txtFirstName.Text = "";
		txtLastName.Text = "";
		txtPhone.Text = "";
		txtAddress.Text = "";
		txtCity.Text = "";
		txtState.Text = "";
		txtZip.Text = "";
		chkContract.Checked = false;

		lblResults.Text = "Click Insert New to add the completed record.";

    }
    protected void cmdInsert_Click(object sender, EventArgs e)
    {
        //This method uses a paramaterized sql statement to insert a new author into the database
        //See pages 459-460
		if (txtID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "")
		{
			lblResults.Text = "Records require an ID, first name, and last name.";
			return;
		}


		int added = 0;
		try
		{
			added = AuthorAccess.InsertAuthor(txtID.Text, txtLastName.Text, txtFirstName.Text, txtPhone.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZip.Text, chkContract.Checked);
			lblResults.Text = added.ToString() + " record inserted.";
		}
		catch (Exception err)
		{
			lblResults.Text = "Error instering record. ";
			lblResults.Text += err.Message;
		}
	
		if (added > 0)
			FillAuthorList();
	}

    protected void cmdUpdate_Click(object sender, EventArgs e)
    {
		//This method uses a paramaterized sql statement to update author attributes in the database
		//See pages 460-461

		int updated = 0;

		try
		{
		
			updated = AuthorAccess.UpdateAuthor(lstAuthor.SelectedItem.Value, txtLastName.Text, txtFirstName.Text, txtPhone.Text, txtAddress.Text , txtCity.Text, txtState.Text, txtZip.Text, chkContract.Checked);
			lblResults.Text = updated.ToString() + " record updated";
		}
		catch (Exception err)
		{
			lblResults.Text = "Error updating author. ";
			lblResults.Text += err.Message;
		}

	}

    protected void cmdDelete_Click(object sender, EventArgs e)
    {
		//This method uses a paramaterized sql statement to delete an author from the database
		//See page 462

		int deleted = 0;

		try
		{
			deleted = AuthorAccess.DeleteAuthor(lstAuthor.SelectedItem.Value);
			lblResults.Text = deleted.ToString() + " record deleted";
		}
		catch (Exception err)
		{
			lblResults.Text = "Error deleting author. ";
			lblResults.Text += err.Message;
		}


		if (deleted > 0)
			FillAuthorList();
    }
}
