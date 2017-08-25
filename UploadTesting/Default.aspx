<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UploadTesting._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Modify this template to jump-start your ASP.NET application.</h2>
            </hgroup>
            <p>
                To learn more about ASP.NET, visit <a href="http://asp.net" title="ASP.NET Website">http://asp.net</a>.
                The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET.
                If you have any questions about ASP.NET visit
                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <link rel="stylesheet" type="text/css" href="styles.css" />
    <script type="text/javascript" id="jsInput" src='<%= ResolveUrl ("~/Scripts/Input.js") %>'>
    </script>

    <script type="text/javascript" id="jsUpload" src='<%= ResolveUrl ("~/Scripts/RadAsyncUpload.js") %>'>
    </script>

    <script type="text/javascript">

       // function OnClientFilesSelected(sender, args) {
      //      var upload = $find("<%= TransportFileName1Upload.ClientID %>");
       //     var uploadDiv = upload.get_element();                                    

            //var title = document.createElement("input");
            //title.id = title.name = upload.getID("title");                      
            //var ul = uploadDiv.getElementsByTagName("UL");
            //var LIs = ul[0].getElementsByTagName("LI");
            //var lastLi = LIs[LIs.length - 1];            
            //title.readOnly = "readonly";
            //var value = document.getElementById('<%=ddl.ClientID%>').value;      
            //title.value = value;               
            //lastLi.appendChild(title);

            //var fileInputSpan = uploadDiv.getElementsByTagName("span")[0];
            //var ul = uploadDiv.getElementsByTagName("UL");
            //var LIs = ul[0].getElementsByTagName("LI");
            //var lastLi = LIs[LIs.length - 1];
            //label = document.createElement("span");
            //var value = document.getElementById('<%=ddl.ClientID%>').value;
            //label.innerHTML = value;
            //label.style.fontSize = 12;            
            //lastLi.appendChild(label);
           
       // }

    
       
    </script>

    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    function selected(sender, args) {
        $telerik.$(args.get_row()).addClass("ruUploading");
    }
        </script>
</telerik:RadCodeBlock>
 
 <style type="text/css">
     li .ruBrowse {
         width: 100px;
         margin: auto 0px 0px 0px;
         padding-bottom: 5px;
         text-align:match-parent;
     }

     li input{         
         width: 100px;
         margin: auto 10px 3px 0px;
         padding-bottom:5px;
         overflow: hidden;   
         background-color:transparent;
         border-style:groove;      
     }

     .RadUpload .ruFakeInput {
         width:250px;
     }
   
      li .ruRemove {         
         font-size: 11px !important;
         padding: 0 !important;
         width: 79px !important;         
         margin: auto 10px 3px 0px;
         font-weight:bold;
     }

    span.ruFileWrap.ruStyled {
         font-size: 14px;         
         width:auto;
     }

 </style>

    <div>

    <asp:Button ID="btnUpload" runat="server" Text="Apply" OnClick="btnUpload_Click" />

     <asp:Button ID="btnView" runat="server" Text="View" OnClick="btnView_Click" />


         <div class="grid_3">     
             
              <asp:Repeater runat="server" ID="Repeater1">
                <HeaderTemplate>
                    <ul>
                </HeaderTemplate>
                <FooterTemplate></ul></FooterTemplate>
                <ItemTemplate>
                    <li>             
                    <dt>File name : <%# DataBinder.Eval(Container.DataItem, "FileName").ToString() %></dt>                         
                    <dt>Doc Type :  <%#((Telerik.Web.UI.UploadedFile)Container.DataItem).GetFieldValue("TextBox").ToString()%> </dt>
                    <dt>File size : <%# DataBinder.Eval(Container.DataItem, "ContentLength").ToString() %></dt>   
                    </li></br>
                </ItemTemplate>
            </asp:Repeater>      

        <telerik:RadAsyncUpload ID="TransportFileName1Upload" runat="server" Width="100%"   
             OnClientFileSelected="OnFileSelected" OnClientProgressUpdating="OnProgressUpdating" OnClientFileUploaded="OnFileUploaded">
         </telerik:RadAsyncUpload>
           <asp:DropDownList runat="server" ID="ddl" ClientIDMode="Static" ></asp:DropDownList>
        
         </div>

         <%--OnClientAdded="addTitle"--%> 
        
    <asp:HyperLink ID="lnkView" runat="server" Text="View" Visible="false"></asp:HyperLink>

   </div>

    <div style="visibility:hidden">
      <div>
         <asp:Label ID="listofuploadedfiles" runat="server" /> <asp:LinkButton ID="lnkDel" Text="Remove" runat="server"/>
      </div>

     <div>  
       <asp:FileUpload runat="server" ID="UploadImages" AllowMultiple="true" />  
       <asp:Button runat="server" ID="uploadedFile" Text="Upload" OnClick="uploadFile_Click" />  
     
      
    </div>   
  </div>
</asp:Content>


