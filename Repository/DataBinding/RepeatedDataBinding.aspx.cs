using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataBinding_RepeatedDataBinding : System.Web.UI.Page
{

	protected void Page_Load(object sender, EventArgs e)
	{
		int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		//Bind ListBox1 to numbers
		ListBox1.DataSource = numbers;

		ListBox1.DataBind();

		//create array list of 10 food and bind to checkbox list control
		ArrayList favFood = new ArrayList();
		favFood.Add("Potatoes");
		favFood.Add("Steak");
		favFood.Add("Bacon");
		favFood.Add("Spam");
		favFood.Add("Baconator");
		favFood.Add("Pizza");
		favFood.Add("Ice Cream");
		favFood.Add("Fries");
		favFood.Add("French Fries");
		favFood.Add("Kabab");

		CheckBoxList1.DataSource = favFood;
		CheckBoxList1.DataBind();

		List<string> bands = new List<string>();
		bands.Add("The Fray");
		bands.Add("Weird Al");
		bands.Add("Dream Theatre");

		RadioButtonList1.DataSource = bands;
		RadioButtonList1.DataBind();

		Dictionary<int, string> months = new Dictionary<int, string>();
		months.Add(1, "January");
		months.Add(2, "February");
		months.Add(3, "March");
		months.Add(4, "April");
		months.Add(5, "May");
		months.Add(6, "June");
		months.Add(7, "July");
		months.Add(8, "August");
		months.Add(9, "September");
		months.Add(10, "October");
		months.Add(11, "November");
		months.Add(12, "December");

		DropDownList1.DataSource = months;
		DropDownList1.DataTextField = "Value";
		DropDownList1.DataValueField = "Key";
		DropDownList1.DataBind();

	}
}