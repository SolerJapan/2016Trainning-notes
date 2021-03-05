<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<%--    <h2><%: Title %>.</h2>
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
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Account/Login.aspx">Please click here to get to membership page</asp:HyperLink>
    </p>
        <table>

        <tr>

            <td>

                <strong>Company Contact Information</strong>
            </td>
        </tr>
        <tr>
            <td>Company Name</td>
            <td>Millenium Solution Focus</td>

        </tr>

        <tr>
            <td>Address:</td>
            <td>2 Broad St. #518, Bloodfield, NJ 07003</td>

        </tr>

        <tr>
            <td>Email MSF at :</td>
            <td>
                <p>
                    <a href="mailto:trainmsf@outlook.com">Trainmsf@outlook.com</a>
                </p>

            </td>
        </tr>
        <tr>

            <td>Tel: </td>
            <td style="background-color: #99FFCC">973-429-8838</td>
        </tr>
        <tr>
            <td>Web Site:</td>
            <td>www.msfusa2000.com</td>
        </tr>
        <tr>

            <td>Map</td>
            <td>
                <%--html 5 pages embedded into aspx page--%>
              <iframe height="400" width="300" border="0" marginwidth="0" marginheight="0"
                   src="https://www.mapquest.com/embed/us/nj/bloomfield/07003/2-broad-st-40.793913,-74.197768?center=40.79391300000001,-74.19776799999998&zoom=15&maptype=map"></iframe>

            </td>
        </tr>
        <tr>
            <td>Direction</td>
        
        <td>
            <a href="direction.htm" onclick="window.open('direction.html?location=nj','direction,'width=400,height=400,resizeable=no,
                scrollbars=yes,toolbar=no,menubar=no,location=no')" target ="_blank">

              Directions to the Company
            </a>

        </td>
            
        </tr>
    </table>
</asp:Content>
