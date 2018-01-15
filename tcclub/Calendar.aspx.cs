using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Collections;

public partial class Calendar : System.Web.UI.Page
{
    string[,] holidays = new String[13, 32];
    Hashtable HolidayList;


    protected void Page_Load(object sender, EventArgs e)
    {
        //holidays[1, 1] = "Birthday";
        //holidays[2, 14] = "Anniversary";


        if (!IsPostBack)
        {
            Label1.Text = DateTime.Today.Year.ToString() + ", " + DateTime.Today.ToShortDateString();
        }
        HolidayList = Getholiday(); 

    }

    private Hashtable Getholiday()
    {

        Hashtable holiday = new Hashtable();

        holiday["1/1/2018"] = "New Year";
        holiday["1/15/2018"] = "Martin Luther King Day";
        holiday["1/26/2018"] = "Republic Day (India)";
        holiday["2/14/2018"] = "Valentine's Day";
        holiday["2/19/2018"] = "Presidents Day";
        holiday["3/11/2018"] = "Daylight Saving";
        holiday["3/30/2018"] = "Good Friday";
        holiday["4/1/2018"] = "Easter";
        holiday["5/13/2018"] = "Mothers Day";
        holiday["5/28/2018"] = "Memorial Day";
        holiday["6/17/2018"] = "Fathers Day";
        holiday["7/4/2018"] = "Independence Day";
        holiday["9/3/2018"] = "Labor Day";
        holiday["11/4/2018"] = "Daylight Saving";
        holiday["11/22/2018"] = "Thanksgiving";
        holiday["12/25/2018"] = "Christmas";
        holiday["01/01/2019"] = "New Year";

        return holiday;

    }

    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        //string aHoliday;
        //DateTime theDate = e.Day.Date;
        //aHoliday = holidays[theDate.Month, theDate.Day];
        //if (aHoliday != null)
        //{
        //    Label aLabel = new Label();
        //    aLabel.Text = " <br>" + aHoliday;
        //    e.Cell.Controls.Add(aLabel);
        //}

        e.Cell.Width = 80;
        e.Cell.Height = 80;

        if (HolidayList[e.Day.Date.ToShortDateString()] != null)
        {

            Literal literal = new Literal();
            literal.Text = "<br/>";
            e.Cell.Controls.Add(literal);
            Label label = new Label();
            label.Text = (string)HolidayList[e.Day.Date.ToShortDateString()];
            label.Font.Size = new FontUnit(FontSize.Small);
            e.Cell.Controls.Add(label);
            e.Cell.BackColor = System.Drawing.Color.Lavender;
        }

    }
    protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
    {
        Label1.Text = e.NewDate.Year.ToString() + ", " + e.NewDate.ToShortDateString();
    }
}