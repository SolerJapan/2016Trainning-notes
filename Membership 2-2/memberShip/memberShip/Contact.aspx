<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="memberShip.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <%--  <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>--%>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Account/Login.aspx">Please click here to get into membership page</asp:HyperLink>
    </p>
     <table>
   <tr>
     <td> 
        <strong>Company Contact Information</strong>
     </td>
   </tr>

   <tr>
     <td>Company Name</td>
     <td>Millennium Solution Focus</td>
   </tr>

   <tr>
   <td>Address:</td>
   <td>2 Broad St. #518, Bloomfield, NJ 07003</td>
   </tr>

   <tr>
   <td>Email MSF at : </td>
   <td>
   <p>
   <a href="mailto:trainmsf@outlook.com">trainmsf@outlook.com</a>
   </p>

   </td>


   </tr>
   <tr>
   <td>Tel: </td>
   <td>973-429-8838</td>
   </tr>
   <tr>
   <td>Fax: </td>
   <td>973-429-8871</td>

   </tr>
   <tr>
   <td>Web Site: </td>
   <td>www.msfusa2000.com</td>

   </tr>
   <tr>
   <td>Map</td>
   <td>
  <%-- html 5 tags embeded into aspx page--%>
    <iframe height="400" width="300" border="0" marginwidth="0" marginheight="0" 
    src="https://www.mapquest.com/embed/search/results?query=2%20Broad%20St,%20Bloomfield,%20NJ%2007003&boundingBox=38.20581359813473,-122.61291503906249,37.2456348218214,-120.1904296875&page=0&center=40.79391300000001,-74.19630887829588&zoom=11&maptype=map">

    </iframe>

   </td>

   </tr>
   <tr>
   <td>Direction</td>
   <td>
   <a href="direction.htm" onclick="window.open('direction.html?location=nj','direction','width=400,height=400,resizeable=no,
   scrollbars=yes,toobar=no,menubar=no,location=no')" target="_blank">

   Dirving/Company Direction
   </a>


   </td>


   </tr>


   </table>


</asp:Content>
