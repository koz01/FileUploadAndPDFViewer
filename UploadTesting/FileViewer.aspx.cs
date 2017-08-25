
using GleamTech.ExamplesCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace UploadTesting
{
    public partial class FileViewer : System.Web.UI.Page
    {

    

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               // if (ddlDoc1.SelectedIndex == -1)
               // {
               //     documentViewer.Document = @"D:\doc.docx";
               // }
              //  else
               // {
                documentViewer.Document = @"D:\pdf\test.pdf";
              //  }
              //  if (ddlDoc2.SelectedIndex == -1)
             //   {
              //      documentViewer1.Document = @"D:\doc.docx";
             //   }
             //   else
             //   {
                documentViewer1.Document = @"D:\pdf\22pdf.pdf";
              //  }

                ListItemCollection collection = new ListItemCollection();
                collection.Add(new System.Web.UI.WebControls.ListItem(" --- Select Document --- "));
                collection.Add(new System.Web.UI.WebControls.ListItem("Invoice"));
                collection.Add(new System.Web.UI.WebControls.ListItem("HWBA"));
                collection.Add(new System.Web.UI.WebControls.ListItem("PDF"));

                ddlDoc1.DataSource = collection;
                ddlDoc1.DataBind();


                ddlDoc2.DataSource = collection;
                ddlDoc2.DataBind();
                documentViewer.Dispose();
                #region New Comment For Iframe
                //HtmlControl MyFrame = (HtmlControl)this.FindControl("iframe");
                //iframe.Attributes["src"] = @"D:\file1.xlsx";
               // iframe1.Attributes["src"] = @"~\dll\test\JOB.pdf";
                #endregion

                #region Old Comment

                //string files = Server.MapPath(@"~\dll\test\JOB.pdf");

                //  ((HtmlControl)(this.FindControl("iframe"))).Attributes["src"] = files;


                //iframe.Src="www.google.com"
               // this.iframe.Attributes.Add("src", "www.google.com");

                //Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument(files);
                //String pattern = "SplitDocument-{0}.pdf";
                //doc.Split(pattern);
                //String lastPageFileName = String.Format(pattern, doc.Pages.Count - 1);


                //    doc.Close();
                // Response.ContentType = GetContentType(@"D:\pdf\MergeDocuments.pdf");
                // Response.WriteFile(@"D:\pdf\MergeDocuments.pdf");

                //Response.End();

                 






                //string name = Request.QueryString["name"];
                //string folder = Request.QueryString["folder"];

                ////Set the appropriate ContentType.
                //Response.ContentType = GetContentType("result.pdf");

                ////Get the physical path to the file.
                //string filePath = "d:/pdf/result.pdf"; // Server.MapPath(folder + "/" + name);

                ////Write the file directly to the HTTP content output stream.
                //Response.WriteFile(filePath);

                //Response.End();
                
                //  PdfDocument doc = new PdfDocument(); ;

                //doc.LoadFromFile(@"d:/pdf/result.pdf");

	 

                ////Set

                //doc.ViewerPreferences.CenterWindow = true;

                //doc.ViewerPreferences.HideMenubar = true;

                //doc.ViewerPreferences.PageLayout = PdfPageLayout.TwoPageLeft;

                //doc.ViewerPreferences.PageMode = PdfPageMode.FullScreen;

	 

                ////Save and Launch

                //doc.SaveToFile("d:/dll/result.pdf");

                //doc.Close();

                //Response.WriteFile("d:/dll/result.pdf");

                //Response.End();
                #endregion
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

     

        
        //private string GetContentType(string fileName)
        //{

        //    string[] tempArray = fileName.Split(new char[] { '.' });

        //    string fileExtension = string.Empty;

        //    if (tempArray.Length > 1)
        //    {
        //        int index = tempArray.Length - 1;

        //        fileExtension = tempArray[index];
        //    }

        //    switch (fileExtension)
        //    {
        //        case "htm":
        //        case "html":
        //        case "log":
        //            return "text/HTML";
        //        case "txt":
        //            return "text/plain";
        //        case "doc":
        //        case "docx":
        //            return "application/ms-word";
        //        case "tiff":
        //        case "tif":
        //            return "image/tiff";
        //        case "asf":
        //            return "video/x-ms-asf";
        //        case "avi":
        //            return "video/avi";
        //        case "zip":
        //            return "application/zip";
        //        case "xls":
        //        case "xlsx":
        //        case "csv":
        //            return "application/vnd.ms-excel";
        //        case "gif":
        //            return "image/gif";
        //        case "jpg":
        //        case "jpeg":
        //            return "image/jpeg";
        //        case "bmp":
        //            return "image/bmp";
        //        case "wav":
        //            return "audio/wav";
        //        case "mp3":
        //            return "audio/mpeg3";
        //        case "mpg":
        //        case "mpeg":
        //            return "video/mpeg";
        //        case "rtf":
        //            return "application/rtf";
        //        case "asp":
        //            return "text/asp";
        //        case "pdf":
        //            return "application/pdf";
        //        case "fdf":
        //            return "application/vnd.fdf";
        //        case "ppt":
        //        case "pptx":
        //            return "application/mspowerpoint";
        //        case "dwg":
        //            return "image/vnd.dwg";
        //        case "msg":
        //            return "application/msoutlook";
        //        case "xml":
        //        case "sdxl":
        //            return "application/xml";
        //        case "xdp":
        //            return "application/vnd.adobe.xdp+xml";
        //        default:
        //            return "application/octet-stream";
        //    }
        //}
    }
}