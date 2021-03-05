<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="requestInfo.aspx.cs" Inherits="WebApplication1.requestInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: x-large; color: #99FF99">
&nbsp;<table style="width: 100%; height: 98px; background-color: #ffffff">
            <tr>
                <td style="color: #000000"><span style="font-size: xx-large">Request More Information</span><br />
                    <br />
                    <span style="font-size: medium">Please fill out the form below to receive more information about our consultants and services.
                    Our representative will contact you shortly with the information you have requested.</span></td>
            </tr>
        </table>
    </p>
    <table style="width: 100%; background-color: #ffffff">
        <tr>
            <td style="width: 263px">
                <asp:Label ID="Label1" runat="server" Text="Your Name:"></asp:Label>
            </td>
            <td style="width: 288px">
                <asp:TextBox ID="nameTextbox" runat="server"></asp:TextBox>
            </td>
            <td style="width: 405px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nameTextbox" ErrorMessage="Please enter your name" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 263px; height: 24px">
                <asp:Label ID="Label2" runat="server" Text="Company:"></asp:Label>
            </td>
            <td style="width: 288px; height: 24px">
                <asp:TextBox ID="companyTextbox" runat="server"></asp:TextBox>
            </td>
            <td style="height: 24px; width: 405px">&nbsp;</td>
            <td style="height: 24px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 263px; height: 22px">
                <asp:Label ID="Label3" runat="server" Text="Phone:"></asp:Label>
            </td>
            <td style="height: 22px; width: 288px">
                <asp:TextBox ID="phoneTextbox" runat="server"></asp:TextBox>
            </td>
            <td style="height: 22px; width: 405px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="phoneTextbox" ErrorMessage="Please enter your phone" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
            <td style="height: 22px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="phoneTextbox" ErrorMessage="Please enter a U.S telephone number" style="color: #FF0000" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 263px; height: 25px;">
                <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
            </td>
            <td style="width: 288px; height: 25px;">
                <asp:TextBox ID="emailTextbox" runat="server"></asp:TextBox>
            </td>
            <td style="width: 405px; height: 25px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="emailTextbox" ErrorMessage="Please enter your email" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
            <td style="height: 25px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="emailTextbox" ErrorMessage="Please enter a Vaild email " style="color: #FF0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 263px; height: 24px">
                <asp:Label ID="Label5" runat="server" Text="Interested Services"></asp:Label>
            </td>
            <td style="width: 288px; height: 24px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Selected="True">Please Select One</asp:ListItem>
                    <asp:ListItem>Web Services</asp:ListItem>
                    <asp:ListItem>Microsoft Solutions</asp:ListItem>
                    <asp:ListItem>Data Management and warehousing</asp:ListItem>
                    <asp:ListItem>ecommerce</asp:ListItem>
                    <asp:ListItem>Web Design and Development</asp:ListItem>
                    <asp:ListItem>Desktop Support and Maintence</asp:ListItem>
                    <asp:ListItem>Corp Trainning</asp:ListItem>
                    <asp:ListItem>None</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 405px; height: 24px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Please select a service" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
            <td style="height: 24px"></td>
        </tr>
        <tr>
            <td style="width: 263px; height: 9px">Additional Comments<br />
            </td>
            <td style="width: 288px; height: 9px">
                <asp:TextBox ID="commentTextbox" runat="server" TextMode="MultiLine" Height="92px" Width="396px"></asp:TextBox>
            </td>
            <td style="width: 405px; height: 9px"></td>
            <td style="height: 9px"></td>
        </tr>
        <tr>
            <td style="width: 263px; height: 41px"></td>
            <td style="width: 288px; height: 41px">
                <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="clearButton" runat="server" OnClick="clearButton_Click" Text="Clear" />
            </td>
            <td style="height: 41px; width: 405px"></td>
            <td style="height: 41px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 263px; height: 41px">
                <asp:Label ID="Label6" runat="server" Text="Thank you for your request"></asp:Label>
            </td>
            <td style="width: 288px; height: 41px">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Members.aspx">Please click here to get to membership page</asp:HyperLink>
            </td>
            <td style="height: 41px; width: 405px">&nbsp;</td>
            <td style="height: 41px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 263px; height: 41px">
                &nbsp;</td>
            <td style="width: 288px; height: 41px">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="LinqDataSource1" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="requestID">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="requestID" HeaderText="requestID" InsertVisible="False" ReadOnly="True" SortExpression="requestID" />
                        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                        <asp:BoundField DataField="company" HeaderText="company" SortExpression="company" />
                        <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                        <asp:BoundField DataField="services" HeaderText="services" SortExpression="services" />
                        <asp:BoundField DataField="comment" HeaderText="comment" SortExpression="comment" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="WebApplication1.requestDataDataContext" EnableInsert="True" EntityTypeName="" TableName="requestDatas">
                </asp:LinqDataSource>
            </td>
            <td style="height: 41px; width: 405px">&nbsp;</td>
            <td style="height: 41px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
