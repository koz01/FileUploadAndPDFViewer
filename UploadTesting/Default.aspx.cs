using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace UploadTesting
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
               
            string folder = string.Format(@"dll\dll\", "test");


                string name = "TEST";

                lnkView.NavigateUrl = string.Format("~/FileViewer.aspx?folder={0}&name={1}", folder, name);
                lnkView.Visible = true;

                //MergeDocument document = new MergeDocument();
                //Page page = new Page(PageSize.Letter, PageOrientation.Portrait);
                //page.Elements.Add(new Label("Cover Page", 0, 0, 512, 12));
                //document.Pages.Add(page);
                //document.Append(@"C:\DocumentA.pdf");
                //document.Draw(@"C:\MyDocument.pdf");

             //   DropDownList ddl = (DropDownList)ServerControl1.FindControl("ddl");
                if (!IsPostBack)
                {
                    ListItemCollection collection = new ListItemCollection();
                    collection.Add(new System.Web.UI.WebControls.ListItem(" "));
                    collection.Add(new System.Web.UI.WebControls.ListItem("Invoice"));
                    collection.Add(new System.Web.UI.WebControls.ListItem("HWBA"));
                    collection.Add(new System.Web.UI.WebControls.ListItem("PDF"));

                    //Pass ListItemCollection as data source
                    ddl.DataSource = collection;
                    ddl.DataBind();
                }
                ddl.SelectedIndex = 0;                
           
        }

        protected void uploadFile_Click(object sender, EventArgs e)
        {
            if (UploadImages.HasFiles)
            {
                foreach (HttpPostedFile uploadedFile in UploadImages.PostedFiles)
                {
                    uploadedFile.SaveAs(System.IO.Path.Combine(Server.MapPath("~/Images/"), uploadedFile.FileName));
                    listofuploadedfiles.Text += String.Format("{0}<br />", uploadedFile.FileName + "           " + ddl.SelectedValue);
                    ddl.SelectedIndex = 0;
                }
            }
        }  

        protected void btnUpload_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                if (TransportFileName1Upload.UploadedFiles.Count > 0)
                {
                    
                    Repeater1.Visible = true;
                    Repeater1.DataSource = TransportFileName1Upload.UploadedFiles;
                    Repeater1.DataBind();
                }

                UploadAttachmentFiles("Test", TransportFileName1Upload.UploadedFiles);

            }
        }

        protected void btnView_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {

                String[] source_files = { "D:/dll/dll/test/JOB.pdf", "D:/dll/dll/test/JOB.pdf" };
                String result = "d:/pdf/result.pdf";
                //create Document object
                Document document = new Document();
                //create PdfCopy object
                PdfCopy copy = new PdfCopy(document, new FileStream(result, FileMode.Create));
                //open the document
                document.Open();
                //PdfReader variable
                PdfReader reader;
               
                PdfReader.unethicalreading = true;
                for (int i = 0; i < source_files.Length; i++)
                {
                    //create PdfReader object
                    reader = new PdfReader(source_files[i]);
                    //merge combine pages
                    for (int page = 1; page <= reader.NumberOfPages; page++)
                        copy.AddPage(copy.GetImportedPage(reader, page));

                }
                
                
                
                document.Close();

            }
            
            Response.Redirect("~/FileViewer.aspx");
        }


        private void UploadAttachmentFiles(string folderName, UploadedFileCollection uploadFiles)
        {

            foreach (UploadedFile uploadFile in uploadFiles)
            {
                try
                {
                    string leaveFolderPath = Server.MapPath("~/dll/");
                    string fullFolderPath = leaveFolderPath + folderName;

                    if (!Directory.Exists(fullFolderPath))
                    {
                        Directory.CreateDirectory(fullFolderPath);
                    }

                    string fullFilePath = fullFolderPath + "\\" + uploadFile.FileName;

                    uploadFile.SaveAs(fullFilePath, true);

                }
                catch
                {
                    throw new IOException(uploadFile.FileName + " attachment upload fail");
                }
            }
        } 

        

    }
}