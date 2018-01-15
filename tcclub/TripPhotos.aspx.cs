using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Photos : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        string[] filesindirectory = Directory.GetFiles(Server.MapPath("~/Photos/Trips"));
        List<String> images = new List<string>(filesindirectory.Count());

        foreach (string item in filesindirectory)
        {
            images.Add(String.Format("~/Photos/Trips/{0}", System.IO.Path.GetFileName(item)));
        }

        RepeaterImagesT.DataSource = images;
        RepeaterImagesT.DataBind();
    }
}
