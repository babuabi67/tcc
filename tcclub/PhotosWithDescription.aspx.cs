using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI.HtmlControls;

public partial class PhotosWithDescription : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int iFileCnt = 0;

        System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(Server.MapPath("~/Photos/Programs/"));
        FileInfo[] listfiles = dirInfo.GetFiles("*.*");

        if (listfiles.Length > 0)
        {

            foreach (FileInfo file in listfiles)
            {

                // CHECK THE TYPE OF FILE.
                if ((listfiles[iFileCnt].Extension == ".jpg" ||
                    listfiles[iFileCnt].Extension == ".jpeg" ||
                        listfiles[iFileCnt].Extension == ".png" ||
                            listfiles[iFileCnt].Extension == ".bmp" ||
                                listfiles[iFileCnt].Extension == ".gif"))
                {
                    HtmlImage img = new HtmlImage();
                    HtmlGenericControl newDiv = new HtmlGenericControl("div");
                    HtmlGenericControl textDiv = new HtmlGenericControl("div");

                    // ADD IMAGE.
                    img.Src = "~/Photos/Trips/" + listfiles[iFileCnt].Name;
                    img.Width = 180;
                    img.Height = 150;

                    newDiv.Attributes.Add("style", "float:left;padding:5px 3px;  margin:20px 3px;height:auto;overflow:hidden;");
                    newDiv.Controls.Add(img);

                    // ADD A TEXT.
                    textDiv.Attributes.Add("style", "display:block;font:13px Arial;padding:10px 0;width:" +
                        img.Width + "px;color:#666;text-align:center;cursor:pointer;");

                    textDiv.InnerText = "Various Catgories - Binding, Product Specification, Author (Price Tag)";
                    newDiv.Controls.Add(textDiv);

                    divGallary.Controls.Add(newDiv);
                }
                iFileCnt = iFileCnt + 1;
            }
        }

    }
}