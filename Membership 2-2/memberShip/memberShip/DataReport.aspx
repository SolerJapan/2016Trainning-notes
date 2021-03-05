<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataReport.aspx.cs" Inherits="memberShip.DataReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: x-large; color: #003399">
    <strong>Data Report</strong></p>
<table class="nav-justified">
    <tr>
        <td>
    <strong>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem>0</asp:ListItem>
                <asp:ListItem>100</asp:ListItem>
                <asp:ListItem>200</asp:ListItem>
                <asp:ListItem>300</asp:ListItem>
                <asp:ListItem>400</asp:ListItem>
            </asp:DropDownList>
            </strong></td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="OrderID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="OrderID" HeaderText="OrderID" InsertVisible="False" ReadOnly="True" SortExpression="OrderID" />
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                    <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" SortExpression="EmployeeID" />
                    <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" SortExpression="OrderDate" />
                    <asp:BoundField DataField="RequiredDate" HeaderText="RequiredDate" SortExpression="RequiredDate" />
                    <asp:BoundField DataField="ShippedDate" HeaderText="ShippedDate" SortExpression="ShippedDate" />
                    <asp:BoundField DataField="ShipVia" HeaderText="ShipVia" SortExpression="ShipVia" />
                    <asp:BoundField DataField="Freight" HeaderText="Freight" SortExpression="Freight" />
                    <asp:BoundField DataField="ShipName" HeaderText="ShipName" SortExpression="ShipName" />
                    <asp:BoundField DataField="ShipAddress" HeaderText="ShipAddress" SortExpression="ShipAddress" />
                    <asp:BoundField DataField="ShipCity" HeaderText="ShipCity" SortExpression="ShipCity" />
                    <asp:BoundField DataField="ShipRegion" HeaderText="ShipRegion" SortExpression="ShipRegion" />
                    <asp:BoundField DataField="ShipPostalCode" HeaderText="ShipPostalCode" SortExpression="ShipPostalCode" />
                    <asp:BoundField DataField="ShipCountry" HeaderText="ShipCountry" SortExpression="ShipCountry" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" DeleteCommand="DELETE FROM [Orders] WHERE [OrderID] = @OrderID" InsertCommand="INSERT INTO [Orders] ([CustomerID], [EmployeeID], [OrderDate], [RequiredDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity], [ShipRegion], [ShipPostalCode], [ShipCountry]) VALUES (@CustomerID, @EmployeeID, @OrderDate, @RequiredDate, @ShippedDate, @ShipVia, @Freight, @ShipName, @ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry)" SelectCommand="SELECT * FROM [Orders]
Where Freight&gt;@SelectedValue" UpdateCommand="UPDATE [Orders] SET [CustomerID] = @CustomerID, [EmployeeID] = @EmployeeID, [OrderDate] = @OrderDate, [RequiredDate] = @RequiredDate, [ShippedDate] = @ShippedDate, [ShipVia] = @ShipVia, [Freight] = @Freight, [ShipName] = @ShipName, [ShipAddress] = @ShipAddress, [ShipCity] = @ShipCity, [ShipRegion] = @ShipRegion, [ShipPostalCode] = @ShipPostalCode, [ShipCountry] = @ShipCountry WHERE [OrderID] = @OrderID">
                <DeleteParameters>
                    <asp:Parameter Name="OrderID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="CustomerID" Type="String" />
                    <asp:Parameter Name="EmployeeID" Type="Int32" />
                    <asp:Parameter Name="OrderDate" Type="DateTime" />
                    <asp:Parameter Name="RequiredDate" Type="DateTime" />
                    <asp:Parameter Name="ShippedDate" Type="DateTime" />
                    <asp:Parameter Name="ShipVia" Type="Int32" />
                    <asp:Parameter Name="Freight" Type="Decimal" />
                    <asp:Parameter Name="ShipName" Type="String" />
                    <asp:Parameter Name="ShipAddress" Type="String" />
                    <asp:Parameter Name="ShipCity" Type="String" />
                    <asp:Parameter Name="ShipRegion" Type="String" />
                    <asp:Parameter Name="ShipPostalCode" Type="String" />
                    <asp:Parameter Name="ShipCountry" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" DefaultValue="0" Name="SelectedValue" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="CustomerID" Type="String" />
                    <asp:Parameter Name="EmployeeID" Type="Int32" />
                    <asp:Parameter Name="OrderDate" Type="DateTime" />
                    <asp:Parameter Name="RequiredDate" Type="DateTime" />
                    <asp:Parameter Name="ShippedDate" Type="DateTime" />
                    <asp:Parameter Name="ShipVia" Type="Int32" />
                    <asp:Parameter Name="Freight" Type="Decimal" />
                    <asp:Parameter Name="ShipName" Type="String" />
                    <asp:Parameter Name="ShipAddress" Type="String" />
                    <asp:Parameter Name="ShipCity" Type="String" />
                    <asp:Parameter Name="ShipRegion" Type="String" />
                    <asp:Parameter Name="ShipPostalCode" Type="String" />
                    <asp:Parameter Name="ShipCountry" Type="String" />
                    <asp:Parameter Name="OrderID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </td>
    </tr>
</table>
</asp:Content>
