<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FileViewer.aspx.cs" Inherits="UploadTesting.FileViewer" %>

<%@ Register TagPrefix="GleamTech" Namespace="GleamTech.ExamplesCore" Assembly="GleamTech.ExamplesCore" %>
<%@ Register TagPrefix="GleamTech" Namespace="GleamTech.DocumentUltimate.Web" Assembly="GleamTech.DocumentUltimate" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">    
    <asp:Label ID="lblMsg" runat="server"></asp:Label>

    <style type="text/css">
        .Fullscreen {
            position: absolute;
            left: 0;
            top: 0;
            width: 100%;
            height: 100%;
            /* Optional - just for DIV)*/
            border: solid 1px #000000;
            background-color: grey;
        }
</style>

      <div class="Fullscreen" >
        
           <div style="float: left; margin-left:0; height:100%; width:50%; overflow: hidden; display: inline-block;">
            <div>
            <asp:DropDownList ID="ddlDoc1" runat="server" ClientIDMode="Static" Width="100%"></asp:DropDownList>
           </div>

            <GleamTech:DocumentViewer ID="documentViewer" runat="server" style="margin-top:0;"
            Width="100%" 
            Height="100%"             
            Resizable="True" />
         </div>

         <div style="float: right; margin-right:0;  height:100%;  width:50%; overflow: hidden; display: inline-block;">
             <asp:DropDownList ID="ddlDoc2" runat="server" ClientIDMode="Static" Width="100%"></asp:DropDownList>
            <GleamTech:DocumentViewer ID="documentViewer1" runat="server" style="margin-top:0;"
            Width="100%" 
            Height="100%"             
            Resizable="True" />
         </div>
    </div>
       <%--<iframe id="iframe" src=" " runat="server" style="z-index: 100;  width: 50%; position: relative; height: 502px"></iframe>--%>
<%--      <div style="width:900px; height:900px; visibility:hidden;" >

       <div style="float: left;  height:900px;">
           <iframe id="iframe" src=" " runat="server" style="z-index: 100;  width: 50%; position: relative; height: 502px"></iframe>
        
        </div>
            <div style="float: right; height:900px;">
          <iframe id="iframe1" src=" " runat="server" style="z-index: 100; width: 50%; position: relative;  height: 502px"></iframe>             
   
       </div>
   </div> --%>
</asp:Content>
