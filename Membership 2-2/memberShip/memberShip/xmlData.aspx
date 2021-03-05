<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="xmlData.aspx.cs" Inherits="memberShip.xmlData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: xx-large; color: #9933FF">
        <strong>XML Data </strong>
                <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Bookstore.xml"></asp:XmlDataSource>
    </p>
    <table class="nav-justified">
        <tr>
            <td style="width: 476px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 476px">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="XmlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="ISBN">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                        <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                        <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </td>
            <td>
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="XmlDataSource2" ForeColor="#333333" GridLines="None" Visible="False">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
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
                <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="~/App_Data/Bookstore.xml" XPath="/bookstore/book/comments/userComment"></asp:XmlDataSource>
            </td>
        </tr>
        <tr>
            <td style="width: 476px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 476px">
                <asp:XmlDataSource ID="XmlDataSource3" runat="server" DataFile="~/App_Data/Bookstore2.xml" TransformFile="~/App_Data/Bookstore2.xsl"></asp:XmlDataSource>
                <asp:GridView ID="GridView3" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="XmlDataSource3">
                    <Columns>
                        <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                        <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                        <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                    </Columns>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </td>
            <td>
                <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataSourceID="XmlDataSource2" ForeColor="#333333" Visible="False">
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <ItemTemplate>
                        User rating:
                        <asp:Label ID="ratingLabel" runat="server" Text='<%# Eval("rating") %>' />
                        <br />
                        Comment:
                        <asp:Label ID="commentLabel" runat="server" Text='<%# Eval("comment") %>' />
                        <br />
<br />
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SeparatorTemplate>
                        <hr />
                    </SeparatorTemplate>
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td style="width: 476px">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 476px">
                <asp:XmlDataSource ID="XmlDataSource4" runat="server" DataFile="~/App_Data/Bookstore2.xml"></asp:XmlDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 476px">
                <asp:GridView ID="GridView4" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="XmlDataSource4">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p style="font-size: xx-large; color: #9933FF">
        &nbsp;</p>
    <p style="font-size: xx-large; color: #9933FF">
        &nbsp;</p>
</asp:Content>
