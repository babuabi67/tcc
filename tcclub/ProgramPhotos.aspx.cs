using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

public partial class ProgramPhotos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        string[] filesindirectory = Directory.GetFiles(Server.MapPath("~/Photos/Programs"));
        List<String> images = new List<string>(filesindirectory.Count());

        foreach (string item in filesindirectory)
        {
            images.Add(String.Format("~/Photos/Trips/{0}", System.IO.Path.GetFileName(item)));
        }

        Image1.ImageUrl = images.ToString();
  */

        //Timer1.Enabled = false;
        //ImageButtonStartStop.ImageUrl = "~/Images/start.jpg";

        if (!IsPostBack)
        {
            SetImageUrl();
        }
 

    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        int i = (int)ViewState["ImageDisplayed"];
        i = i + 1;
        ViewState["ImageDisplayed"] = i;

        DataRow imageDataRow = ((DataSet)ViewState["ImageData"]).Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == i.ToString());
        if (imageDataRow != null)
        {
            Image1.ImageUrl = "~/Photos/Programs/" + imageDataRow["name"].ToString();
            Label1.Text = imageDataRow["description"].ToString();
        }
        else
        {
            SetImageUrl();
        }
    }



    private void SetImageUrl()
    {
        DataSet ds = new DataSet();
        ds.ReadXml(Server.MapPath("~/Data/ImageXML.xml"));
        ViewState["ImageData"] = ds;
        ViewState["ImageDisplayed"] = 1;
        ViewState["ImageCount"] = ds.Tables[0].Rows.Count;

        DataRow imageDataRow = ds.Tables["image"].Select().FirstOrDefault(x => x["order"].ToString()=="1");
        Image1.ImageUrl="~/Photos/Programs/"+imageDataRow["name"].ToString();
        Label1.Text = imageDataRow["description"].ToString();

    }

    protected void ImageButtonStartStop_Click(object sender, ImageClickEventArgs e)
    {

        if (Timer1.Enabled)
        {
            Timer1.Enabled = false;
            //ImageButton2.Visible = true;
            //ImageButton3.Visible = true;

            ImageButtonStartStop.ImageUrl = "~/Images/start.jpg";
            //ImageButton2.ImageUrl = "~/Images/next.jpg";
            //ImageButton3.ImageUrl = "~/Images/next.jpg";
        }
        else
        {
            Timer1.Enabled = true;
            //ImageButton2.Visible = false;
            //ImageButton3.Visible = false;
            ImageButtonStartStop.ImageUrl = "~/Images/stop.jpg";
        }
    }

    protected void ImageButtonPrevious_Click(object sender, ImageClickEventArgs e)
    {

        ImageButtonStartStop.ImageUrl = "~/Images/start.jpg";
        Timer1.Enabled = false;

        int i = (int)ViewState["ImageDisplayed"];
        if (i == 1)
            i = (int)ViewState["ImageCount"];
        else
            i = i - 1;

        ViewState["ImageDisplayed"] = i;

        DataRow imageDataRow = ((DataSet)ViewState["ImageData"]).Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == i.ToString());
        if (imageDataRow != null)
        {
            Image1.ImageUrl = "~/Photos/Programs/" + imageDataRow["name"].ToString();
            Label1.Text = imageDataRow["description"].ToString();
        }
        //else
        //{
        //    SetImageUrl();
        //}

    }

    protected void ImageButtonNext_Click(object sender, ImageClickEventArgs e)
    {
        ImageButtonStartStop.ImageUrl = "~/Images/start.jpg";
        Timer1.Enabled = false;

        int i = (int)ViewState["ImageDisplayed"];
        i = i + 1;
        ViewState["ImageDisplayed"] = i;

        DataRow imageDataRow = ((DataSet)ViewState["ImageData"]).Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == i.ToString());
        if (imageDataRow != null)
        {
            Image1.ImageUrl = "~/Photos/Programs/" + imageDataRow["name"].ToString();
            Label1.Text = imageDataRow["description"].ToString();
        }
        else
        {
            SetImageUrl();
        }
    }


    protected void ImageButtonLast_Click(object sender, ImageClickEventArgs e)
    {
        ImageButtonStartStop.ImageUrl = "~/Images/start.jpg";
        Timer1.Enabled = false;

        int i = (int)ViewState["ImageCount"];
        ViewState["ImageDisplayed"] = i;

        DataRow imageDataRow = ((DataSet)ViewState["ImageData"]).Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == i.ToString());
        if (imageDataRow != null)
        {
            Image1.ImageUrl = "~/Photos/Programs/" + imageDataRow["name"].ToString();
            Label1.Text = imageDataRow["description"].ToString();
        }
    }


    protected void ImageButtonFirst_Click(object sender, ImageClickEventArgs e)
    {
        ImageButtonStartStop.ImageUrl = "~/Images/start.jpg";
        Timer1.Enabled = false;

        int i = 1;
        ViewState["ImageDisplayed"] = i;

        DataRow imageDataRow = ((DataSet)ViewState["ImageData"]).Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == i.ToString());
        if (imageDataRow != null)
        {
            Image1.ImageUrl = "~/Photos/Programs/" + imageDataRow["name"].ToString();
            Label1.Text = imageDataRow["description"].ToString();
        }
    }
}