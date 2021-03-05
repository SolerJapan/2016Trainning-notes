<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="WebApplication1.Members" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: xx-large">
        Welcome Members!!!</p>
<p>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/dataReport.aspx">Click Here to get Data Report</asp:HyperLink>
</p>
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/xmlData.aspx">Click here to get XML data file</asp:HyperLink>
</p>
</asp:Content>
