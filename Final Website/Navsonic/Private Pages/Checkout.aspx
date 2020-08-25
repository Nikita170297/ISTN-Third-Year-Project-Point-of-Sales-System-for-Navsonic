<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Checkout.aspx.vb" Inherits="Private_Pages_Checkout" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head1" runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
   
</head>
<body background ="../Wallpapers/834522_professional-backgrounds-for-websites-the-rho-chapter-of-delta_1600x1200_h.jpg">
    <form id="Form1" runat="server">
    <div class="page">
        <div class="header" style="background-color: #CC0000">
            <div class="title">
                <h1 style="color: #808080; font-family: 'Berlin Sans FB';">
                    CHECKOUT
                </h1>
            </div>
            <div class="loginDisplay" style="color: #CC0000; background-color: #CC0000;">
            </div>
            <div class="clear hideSkiplink" style="background-color: #CC0000">
                
            </div>
        </div>
        
        <div class="main">

            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Italic="True" 
                Font-Names="Bahnschrift SemiLight" Font-Size="Medium" ForeColor="Black" 
                Text="Date"></asp:Label>
&nbsp;
            <asp:Label ID="Label3" runat="server" Font-Italic="True" 
                Font-Names="Bahnschrift SemiLight" Font-Size="Medium" ForeColor="Black" 
                Text="Date"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Italic="True" 
                Font-Names="Bahnschrift SemiLight" Font-Size="Medium" ForeColor="Black" 
                Text="Total Sale"></asp:Label>
&nbsp;<asp:Label ID="Label4" runat="server" Font-Italic="True" 
                Font-Names="Bahnschrift SemiLight" Font-Size="Medium" ForeColor="Black" 
                Text="Total Sale"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#CC0000" 
                Text="Label"></asp:Label>
            &nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#CC0000" 
                Text="Label"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label 
                ID="Label7" runat="server" Text="Shopping Cart" Font-Bold="True" 
                Font-Size="Large" ForeColor="Black"></asp:Label>
&nbsp;<asp:GridView ID="GridView1" runat="server" RowHeaderColumn="Shopping Cart" 
                ShowHeaderWhenEmpty="True" CellPadding="4" ForeColor="#333333" 
                GridLines="None">
                <AlternatingRowStyle BackColor="White" />
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
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
                DeleteCommand="DELETE FROM [Products] WHERE [Product_ID] = @original_Product_ID AND [Name] = @original_Name AND [Cost_Price] = @original_Cost_Price AND [Quantity] = @original_Quantity AND [Product_Description] = @original_Product_Description AND [Type] = @original_Type AND [Status] = @original_Status" 
                InsertCommand="INSERT INTO [Products] ([Name], [Cost_Price], [Quantity], [Product_Description], [Type], [Status]) VALUES (@Name, @Cost_Price, @Quantity, @Product_Description, @Type, @Status)" 
                OldValuesParameterFormatString="original_{0}" 
                SelectCommand="SELECT * FROM [Products]" 
                
                UpdateCommand="UPDATE Products SET Quantity = Quantity - @Quantity WHERE (Product_ID = @Product_ID)">
                <DeleteParameters>
                    <asp:Parameter Name="original_Product_ID" Type="Int32" />
                    <asp:Parameter Name="original_Name" Type="String" />
                    <asp:Parameter Name="original_Cost_Price" Type="Decimal" />
                    <asp:Parameter Name="original_Quantity" Type="Int32" />
                    <asp:Parameter Name="original_Product_Description" Type="String" />
                    <asp:Parameter Name="original_Type" Type="String" />
                    <asp:Parameter Name="original_Status" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Cost_Price" Type="Decimal" />
                    <asp:Parameter Name="Quantity" Type="Int32" />
                    <asp:Parameter Name="Product_Description" Type="String" />
                    <asp:Parameter Name="Type" Type="String" />
                    <asp:Parameter Name="Status" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Quantity" />
                    <asp:Parameter Name="Product_ID" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
                DeleteCommand="DELETE FROM [Product_Sale] WHERE [Sale_ID] = @original_Sale_ID AND [Staff_ID] = @original_Staff_ID AND [Customer_ID] = @original_Customer_ID AND [Amount] = @original_Amount AND [Date] = @original_Date" 
                InsertCommand="INSERT INTO [Product_Sale] ([Staff_ID], [Customer_ID], [Amount], [Date]) VALUES (@Staff_ID, @Customer_ID, @Amount, @Date); Select @SaleNumber = Scope_Identity()" 
                OldValuesParameterFormatString="original_{0}" 
                SelectCommand="SELECT * FROM [Product_Sale]" 
                
                UpdateCommand="UPDATE [Product_Sale] SET [Staff_ID] = @Staff_ID, [Customer_ID] = @Customer_ID, [Amount] = @Amount, [Date] = @Date WHERE [Sale_ID] = @original_Sale_ID AND [Staff_ID] = @original_Staff_ID AND [Customer_ID] = @original_Customer_ID AND [Amount] = @original_Amount AND [Date] = @original_Date">
                <DeleteParameters>
                    <asp:Parameter Name="original_Sale_ID" Type="Int32" />
                    <asp:Parameter Name="original_Staff_ID" Type="Int32" />
                    <asp:Parameter Name="original_Customer_ID" Type="Int16" />
                    <asp:Parameter Name="original_Amount" Type="Decimal" />
                    <asp:Parameter DbType="Date" Name="original_Date" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter DefaultValue="12" Name="Staff_ID" Type="Int32" />
                    <asp:ControlParameter ControlID="Label6" DefaultValue="" Name="Customer_ID" 
                        PropertyName="Text" Type="Int16" />
                    <asp:SessionParameter Name="Amount" SessionField="TotalSales" Type="Decimal" />
                    <asp:ControlParameter ControlID="Label3" DbType="Date" Name="Date" 
                        PropertyName="Text" />
                    <asp:Parameter DefaultValue="" Direction="Output" Name="SaleNumber" 
                        Size="10000" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Staff_ID" Type="Int32" />
                    <asp:Parameter Name="Customer_ID" Type="Int16" />
                    <asp:Parameter Name="Amount" Type="Decimal" />
                    <asp:Parameter DbType="Date" Name="Date" />
                    <asp:Parameter Name="original_Sale_ID" Type="Int32" />
                    <asp:Parameter Name="original_Staff_ID" Type="Int32" />
                    <asp:Parameter Name="original_Customer_ID" Type="Int16" />
                    <asp:Parameter Name="original_Amount" Type="Decimal" />
                    <asp:Parameter DbType="Date" Name="original_Date" />
                </UpdateParameters>
            </asp:SqlDataSource>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
                DeleteCommand="DELETE FROM [Sale_Line] WHERE [Line_ItemID] = @original_Line_ItemID AND [Product_ID] = @original_Product_ID AND [Sale_ID] = @original_Sale_ID AND [Unit_Quantity] = @original_Unit_Quantity AND [Sale_Price] = @original_Sale_Price" 
                InsertCommand="INSERT INTO [Sale_Line] ([Product_ID], [Sale_ID], [Unit_Quantity], [Sale_Price]) VALUES (@Product_ID, @Sale_ID, @Unit_Quantity, @Sale_Price)" 
                OldValuesParameterFormatString="original_{0}" 
                SelectCommand="SELECT * FROM [Sale_Line]" 
                
                UpdateCommand="UPDATE [Sale_Line] SET [Product_ID] = @Product_ID, [Sale_ID] = @Sale_ID, [Unit_Quantity] = @Unit_Quantity, [Sale_Price] = @Sale_Price WHERE [Line_ItemID] = @original_Line_ItemID AND [Product_ID] = @original_Product_ID AND [Sale_ID] = @original_Sale_ID AND [Unit_Quantity] = @original_Unit_Quantity AND [Sale_Price] = @original_Sale_Price">
                <DeleteParameters>
                    <asp:Parameter Name="original_Line_ItemID" Type="Int32" />
                    <asp:Parameter Name="original_Product_ID" Type="Int32" />
                    <asp:Parameter Name="original_Sale_ID" Type="Int32" />
                    <asp:Parameter Name="original_Unit_Quantity" Type="Int32" />
                    <asp:Parameter Name="original_Sale_Price" Type="Decimal" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Product_ID" Type="Int32" />
                    <asp:Parameter Name="Sale_ID" Type="Int32" />
                    <asp:Parameter Name="Unit_Quantity" Type="Int32" />
                    <asp:Parameter Name="Sale_Price" Type="Decimal" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Product_ID" Type="Int32" />
                    <asp:Parameter Name="Sale_ID" Type="Int32" />
                    <asp:Parameter Name="Unit_Quantity" Type="Int32" />
                    <asp:Parameter Name="Sale_Price" Type="Decimal" />
                    <asp:Parameter Name="original_Line_ItemID" Type="Int32" />
                    <asp:Parameter Name="original_Product_ID" Type="Int32" />
                    <asp:Parameter Name="original_Sale_ID" Type="Int32" />
                    <asp:Parameter Name="original_Unit_Quantity" Type="Int32" />
                    <asp:Parameter Name="original_Sale_Price" Type="Decimal" />
                </UpdateParameters>
            </asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Font-Bold="True" 
                Font-Names="Bahnschrift SemiBold" Font-Size="Medium" 
                onclientclick="return confirm(&quot;Are You Sure You wish to use all your rewards?&quot;)" 
                Text="Use Rewards" Width="163px" />
            <asp:Button ID="Button2" runat="server" Font-Names="Bahnschrift SemiBold" 
                Font-Size="Medium" Text="Accept Sale" 
                onclientclick="return confirm(&quot;Are you sure you wish to purchase these items?&quot;)" />
            <asp:Button ID="Button3" runat="server" Font-Names="Bahnschrift SemiBold" 
                Font-Size="Medium" Text="Reject Sale" 
                onclientclick="return confirm(&quot;Are You Sure You wish to end sale?&quot;)" />
            <br />

             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

             <div style="height: 277px; float: none; text-align: left; position: inherit; top: 2px; left: 2px; width: 425px;">



              &nbsp;
                 <asp:Label ID="Label8" runat="server" Text="Customer Details"></asp:Label>
&nbsp;<br />
                 <asp:DetailsView ID="DetailsView1" runat="server" Height="214px" Width="239px" 
                     AutoGenerateRows="False" BackColor="#CCCCCC" BorderColor="#999999" 
                     BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" 
                     DataSourceID="SqlDataSource1" ForeColor="Black">
                     <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                     <Fields>
                         <asp:BoundField DataField="First_Name" HeaderText="First_Name" 
                             SortExpression="First_Name" />
                         <asp:BoundField DataField="Last_Name" HeaderText="Last_Name" 
                             SortExpression="Last_Name" />
                         <asp:BoundField DataField="Contact_Number" HeaderText="Contact_Number" 
                             SortExpression="Contact_Number" />
                         <asp:BoundField DataField="Customer_Rewards" HeaderText="Customer_Rewards" 
                             SortExpression="Customer_Rewards" />
                         <asp:BoundField DataField="Address" HeaderText="Address" 
                             SortExpression="Address" />
                     </Fields>
                     <FooterStyle BackColor="#CCCCCC" />
                     <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                     <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                     <RowStyle BackColor="White" />
                 </asp:DetailsView>



                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                     ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
                     
                     SelectCommand="SELECT [First_Name], [Last_Name], [Contact_Number], [Customer_Rewards], [Address], [Customer_ID] FROM [Customer_Details] WHERE ([Customer_ID] = @Customer_ID)" 
                     DeleteCommand="DELETE FROM [Customer_Details] WHERE [Customer_ID] = @original_Customer_ID AND [First_Name] = @original_First_Name AND [Last_Name] = @original_Last_Name AND [Contact_Number] = @original_Contact_Number AND (([Customer_Rewards] = @original_Customer_Rewards) OR ([Customer_Rewards] IS NULL AND @original_Customer_Rewards IS NULL)) AND [Address] = @original_Address" 
                     InsertCommand="INSERT INTO [Customer_Details] ([First_Name], [Last_Name], [Contact_Number], [Customer_Rewards], [Address]) VALUES (@First_Name, @Last_Name, @Contact_Number, @Customer_Rewards, @Address)" 
                     OldValuesParameterFormatString="original_{0}" 
                     
                     UpdateCommand="UPDATE Customer_Details SET Customer_Rewards = @Customer_Rewards WHERE (Customer_ID = @Customer_ID)">
                     <DeleteParameters>
                         <asp:Parameter Name="original_Customer_ID" Type="Int16" />
                         <asp:Parameter Name="original_First_Name" Type="String" />
                         <asp:Parameter Name="original_Last_Name" Type="String" />
                         <asp:Parameter Name="original_Contact_Number" Type="String" />
                         <asp:Parameter Name="original_Customer_Rewards" Type="Decimal" />
                         <asp:Parameter Name="original_Address" Type="String" />
                     </DeleteParameters>
                     <InsertParameters>
                         <asp:Parameter Name="First_Name" Type="String" />
                         <asp:Parameter Name="Last_Name" Type="String" />
                         <asp:Parameter Name="Contact_Number" Type="String" />
                         <asp:Parameter Name="Customer_Rewards" Type="Decimal" />
                         <asp:Parameter Name="Address" Type="String" />
                     </InsertParameters>
                     <SelectParameters>
                         <asp:ControlParameter ControlID="Label6" Name="Customer_ID" PropertyName="Text" 
                             Type="Int16" />
                     </SelectParameters>
                     <UpdateParameters>
                         <asp:Parameter Name="Customer_Rewards" />
                         <asp:Parameter Name="Customer_ID" />
                     </UpdateParameters>
                 </asp:SqlDataSource>



              </div>

        </div>
    </div>
    </form>
</body>
</html>


