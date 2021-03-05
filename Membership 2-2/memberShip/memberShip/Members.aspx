<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="memberShip.Members" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: xx-large; color: #FF00FF"> Welcome, members!!!!</p>
    <p> 
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DataReport.aspx">Please click here to obtain Data Report</asp:HyperLink>
    </p>
    <p> 
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/xmlData.aspx">Please click here to get on XML Data File</asp:HyperLink>
    </p>
</asp:Content>
