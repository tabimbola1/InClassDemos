using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region additonal namespaces 
using eRestaurantSystem.BLL;

#endregion

public partial class UserControls_DateTimeMarker : System.Web.UI.UserControl
{
    //create properties that will allow external users 
    //of this control ro have access to the data 
    //(date and time) on this control 

    public DateTime MockDate
    {
        get
        {
      //set u a variable to hold the data 
        // this variable will be innitalized to the defualt 
            DateTime date = DateTime.MinValue;

            //possible overribe the deufalut date wih the 
            //contents of the web control SearchDate 

            DateTime.TryParse(SearchDate.Text, out date);

            //return date value.
            return date;
        }
        set
        {
            SearchDate.Text = value.ToString("yyyy-MM-dd");

        }
    }


    public TimeSpan MockTime
    {
        get
        {
            //set u a variable to hold the data 
            // this variable will be innitalized to the defualt 
            TimeSpan time = TimeSpan.MinValue;

            //possible overribe the deufalut date wih the 
            //contents of the web control SearchDate 

            TimeSpan.TryParse(SearchTime.Text, out time);

            //return date value.
            return time;
        }
        set
        {
            SearchTime.Text = DateTime.Today.Add(value).ToString("HH:mm:ss");

        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void MockLastBillingDateTime_Click(object sender, EventArgs e)
    {
        AdminController sysmgr = new AdminController();
        DateTime info = sysmgr.GetLastBillDateTime();
        SearchDate.Text = info.ToString("yyyy-MM-dd");
        SearchTime.Text = info.ToString("HH:mm");

    }
}