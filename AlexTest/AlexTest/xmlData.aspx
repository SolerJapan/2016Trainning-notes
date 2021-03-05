<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="xmlData.aspx.cs" Inherits="AlexTest.xmlData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <table style="width: 100%; background-color: #ffffff">
            <tr>
                <td style="width: 896px; height: 84px">
                    <br />
                    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/BookStore.xml" XPath="/bookstore//book"></asp:XmlDataSource>
                    <br />
                    <br />
                </td>
                <td style="height: 84px">
                    <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="~/App_Data/BookStore.xml" XPath="/bookstore/book/comments/userComment"></asp:XmlDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 896px; height: 243px">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                        </Columns>
                    </asp:GridView>
                    <br />
                </td>
                <td style="height: 243px">
                    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="XmlDataSource2" Height="351px" Width="521px">
                        <Columns>
                            <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
                            <asp:BoundField DataField="comment" HeaderText="comment" SortExpression="comment" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td style="width: 896px">
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:XmlDataSource ID="XmlDataSource3" runat="server" DataFile="~/App_Data/BookStore2.xml" TransformFile="~/App_Data/Bookstore2.xsl"></asp:XmlDataSource>
                </td>
                <td>
                    <asp:XmlDataSource ID="XmlDataSource4" runat="server" DataFile="~/App_Data/BookStore.xml" XPath="/bookstore/book/comments/userComment"></asp:XmlDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 896px">
                    <br />
                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource3">
                        <Columns>
                            <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                        </Columns>
                    </asp:GridView>
                    <br />
                    <br />
                </td>
                <td>
                    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource4">
                        <Columns>
                            <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
                            <asp:BoundField DataField="comment" HeaderText="comment" SortExpression="comment" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
