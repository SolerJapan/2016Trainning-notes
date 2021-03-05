<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="requestInfo.aspx.cs" Inherits="memberShip.requestInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-muted" style="font-size: x-large">
        <strong>Request More Information</strong></p>
    <p class="text-muted" style="font-size: x-large">
        &nbsp;</p>
    <p class="text-muted">
        Please fill out form below to receive more information about our consultants and services.Our representative will contact    
        you shortly with the information that you have requested.</p>
    <table class="nav-justified">
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label1" runat="server" Text="Your Name :"></asp:Label>
            </td>
            <td style="width: 382px">
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            </td>
            <td style="width: 287px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nameTextBox" ErrorMessage="Please enter your name" style="color: #FF3300"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label2" runat="server" Text="Company :"></asp:Label>
            </td>
            <td style="width: 382px">
                <asp:TextBox ID="companyTextBox" runat="server"></asp:TextBox>
            </td>
            <td style="width: 287px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label3" runat="server" Text="Telephone :"></asp:Label>
            </td>
            <td style="width: 382px">
                <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox>
            </td>
            <td style="width: 287px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="phoneTextBox" ErrorMessage="Please enter your phone number" style="color: #FF3300"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="phoneTextBox" ErrorMessage="Please enter correct phone number" style="color: #FF3300" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
            </td>
            <td style="width: 382px">
                <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            </td>
            <td style="width: 287px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Please enter your email" style="color: #FF3300"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Please enter correct email" style="color: #FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 216px">Interested Services</td>
            <td style="width: 382px">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="290px">
                    <asp:ListItem>Please select one</asp:ListItem>
                    <asp:ListItem>Microsoft Solutions</asp:ListItem>
                    <asp:ListItem>Data Management and Warehousing</asp:ListItem>
                    <asp:ListItem>Networking Magagement and Configuration</asp:ListItem>
                    <asp:ListItem>eCommerce Design and Implementation</asp:ListItem>
                    <asp:ListItem>Web Design and Development</asp:ListItem>
                    <asp:ListItem>Desktop Support and Maintenance</asp:ListItem>
                    <asp:ListItem>Corp Training</asp:ListItem>
                    <asp:ListItem>None</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 287px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Please choose interested Services" style="color: #FF3300"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 216px">Additional Comments</td>
            <td style="width: 382px">
                <asp:TextBox ID="commentTextBox" runat="server" TextMode="MultiLine" Height="67px" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 287px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 216px">&nbsp;</td>
            <td style="width: 382px">
                <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="clearButton" runat="server" OnClick="clearButton_Click" Text="Clear" />
            </td>
            <td style="width: 287px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 216px">
                <asp:Label ID="Label5" runat="server" Text="Thank you for your request"></asp:Label>
            </td>
            <td style="width: 382px">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Members.aspx">Please click here to get on membership page</asp:HyperLink>
            </td>
            <td style="width: 287px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataSourceID="LinqDataSource1" GridLines="None" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="requestID" Width="598px">
                    <Columns>
                        <asp:BoundField DataField="requestID" HeaderText="requestID" InsertVisible="False" ReadOnly="True" SortExpression="requestID" />
                        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                        <asp:BoundField DataField="company" HeaderText="company" SortExpression="company" />
                        <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                        <asp:BoundField DataField="services" HeaderText="services" SortExpression="services" />
                        <asp:BoundField DataField="comment" HeaderText="comment" SortExpression="comment" />
                    </Columns>
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#33276A" />
                </asp:GridView>
                <asp:LinqDataSource ID="LinqDataSource1" runat="server" EntityTypeName="" ContextTypeName="memberShip.requestDataDataContext" EnableInsert="True" TableName="requestDatas">
                </asp:LinqDataSource>
            </td>
            <td style="width: 287px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
