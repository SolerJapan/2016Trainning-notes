<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="xmlData.aspx.cs" Inherits="WebApplication1.xmlData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: x-large">
        XML Data</p>
    <p style="font-size: x-large">
        <table style="width: 100%; background-color: #ffffff">
            <tr>
                <td style="width: 834px">
                    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/BookStore.xml" XPath="/bookstore//book"></asp:XmlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 834px">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="ISBN" DataSourceID="XmlDataSource1" GridLines="Horizontal" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="#F7F7F7" />
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                        </Columns>
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <SortedAscendingCellStyle BackColor="#F4F4FD" />
                        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                        <SortedDescendingCellStyle BackColor="#D8D8F0" />
                        <SortedDescendingHeaderStyle BackColor="#3E3277" />
                    </asp:GridView>
                </td>
                <td>
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource2" Visible="False">
                        <Columns>
                            <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
                            <asp:BoundField DataField="comment" HeaderText="comment" SortExpression="comment" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td style="width: 834px">
                    <asp:XmlDataSource ID="XmlDataSource3" runat="server" DataFile="~/App_Data/BookStore2.xml" TransformFile="~/App_Data/Bookstore2.xsl"></asp:XmlDataSource>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 834px; height: 509px;">
                    <asp:GridView ID="GridView3" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataSourceID="XmlDataSource3" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </td>
                <td style="height: 509px">
                    <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="~/App_Data/BookStore.xml" XPath="/bookstore/book/comments/userComment"></asp:XmlDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 834px; height: 1257px;"></td>
                <td style="height: 1257px">
                    <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="XmlDataSource2" GridLines="Vertical" Visible="False">
                        <AlternatingItemStyle BackColor="#DCDCDC" />
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <ItemStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <ItemTemplate>
                            User rating:
                            <asp:Label ID="ratingLabel" runat="server" Text='<%# Eval("rating") %>' />
                            <br />
                            Comment:
                            <asp:Label ID="commentLabel" runat="server" Text='<%# Eval("comment") %>' />
                            <br />
<br />
                        </ItemTemplate>
                        <SelectedItemStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SeparatorTemplate>
                            <hr />
                        </SeparatorTemplate>
                    </asp:DataList>
                </td>
            </tr>
            <tr>
                <td style="width: 834px">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 834px">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
    </asp:Content>
