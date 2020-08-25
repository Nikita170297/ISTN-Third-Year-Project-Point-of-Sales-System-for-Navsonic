<%@ Page Title="" Language="VB" MasterPageFile="~/Private Pages/CustomerMasterPage.master" AutoEventWireup="false" CodeFile="ViewSales.aspx.vb" Inherits="Private_Pages_ViewSales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

<div style="height: 1318px; width: 929px; background-image: url('../Wallpapers/834522_professional-backgrounds-for-websites-the-rho-chapter-of-delta_1600x1200_h.jpg');">


    <br />

             <div style="height: 240px; float: none; text-align: center; position: inherit; top: 2px; left: 2px; width: 918px;" 
        align="center">



              &nbsp;
                 <asp:Label ID="Label8" runat="server" Text="Customer Details" Font-Bold="True" 
                     Font-Names="Sitka" Font-Size="Large" ForeColor="Black"></asp:Label>
&nbsp;<br />
                 <asp:DetailsView ID="DetailsView1" runat="server" Height="161px" Width="906px" 
                     AutoGenerateRows="False" BackColor="White" BorderColor="#DEDFDE" 
                     BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                     DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical">
                     <AlternatingRowStyle BackColor="White" />
                     <EditRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
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
                     <FooterStyle BackColor="#CCCC99" />
                     <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                     <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                     <RowStyle BackColor="#F7F7DE" />
                 </asp:DetailsView>



                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                     ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
                     SelectCommand="SELECT * FROM [Customer_Details] WHERE ([Customer_ID] = @Customer_ID)">
                     <SelectParameters>
                         <asp:SessionParameter Name="Customer_ID" SessionField="User" Type="Int16" />
                     </SelectParameters>
                 </asp:SqlDataSource>



              </div>
              <div align="center">
                  <asp:Label ID="Label1" runat="server" Text="Sales Made" Font-Bold="True" 
                      Font-Names="Sitka Text" Font-Size="Large" ForeColor="Black"></asp:Label>
              </div>
              <div style="height: 305px; width: 917px" class="changePassword">
              
              
              
                  <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
                      SelectCommand="SELECT [Sale_ID], [Amount], [Date] FROM [Product_Sale] WHERE ([Customer_ID] = @Customer_ID)">
                      <SelectParameters>
                          <asp:SessionParameter Name="Customer_ID" SessionField="User" Type="Int16" />
                      </SelectParameters>
                  </asp:SqlDataSource>
                  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                      DataKeyNames="Sale_ID" DataSourceID="SqlDataSource2" Height="220px" 
                      Width="910px" CellPadding="4" ForeColor="#333333" GridLines="None" 
                      style="margin-left: 3px">
                      <AlternatingRowStyle BackColor="White" />
                      <Columns>
                          <asp:CommandField ShowSelectButton="True" />
                          <asp:BoundField DataField="Sale_ID" HeaderText="Sale_ID" InsertVisible="False" 
                              ReadOnly="True" SortExpression="Sale_ID" />
                          <asp:BoundField DataField="Amount" HeaderText="Amount" 
                              SortExpression="Amount" />
                          <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                      </Columns>
                      <EditRowStyle BackColor="#7C6F57" />
                      <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                      <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                      <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                      <RowStyle BackColor="#E3EAEB" />
                      <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                      <SortedAscendingCellStyle BackColor="#F8FAFA" />
                      <SortedAscendingHeaderStyle BackColor="#246B61" />
                      <SortedDescendingCellStyle BackColor="#D4DFE1" />
                      <SortedDescendingHeaderStyle BackColor="#15524A" />
                  </asp:GridView>
                  <asp:Label ID="Label9" runat="server" Text="0" Visible="False"></asp:Label>
                  <br />
                  <br />
                  <br />
                  <br />
                  <br />
              
              
              

              </div>
              <div align="center">
                  <asp:Label ID="Label2" runat="server" Text="Items Purchased" Font-Names="Sitka" 
                      Font-Size="Large" ForeColor="Black"></asp:Label>
                  <br />
                  <br />
              </div>
              <div align="center">


                  <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                      BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                      CellPadding="3" DataSourceID="SqlDataSource3" GridLines="Vertical" 
                      Height="144px" Width="859px" DataKeyNames="Line_ItemID">
                      <AlternatingRowStyle BackColor="#DCDCDC" />
                      <Columns>
                          <asp:BoundField DataField="Line_ItemID" HeaderText="Line_ItemID" 
                              SortExpression="Line_ItemID" InsertVisible="False" ReadOnly="True" />
                          <asp:BoundField DataField="Sale_ID" HeaderText="Sale_ID" 
                              SortExpression="Sale_ID" />
                          <asp:BoundField DataField="Name" HeaderText="Name" 
                              SortExpression="Name" />
                          <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                          <asp:BoundField DataField="Unit_Quantity" HeaderText="Unit_Quantity" 
                              SortExpression="Unit_Quantity" />
                          <asp:BoundField DataField="Sale_Price" HeaderText="Sale_Price" 
                              SortExpression="Sale_Price" />
                          <asp:ImageField DataImageUrlField="Product_ID" 
                              DataImageUrlFormatString="~\Images\{0}.JPG" HeaderText="Product Image">
                          </asp:ImageField>
                      </Columns>
                      <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                      <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                      <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                      <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                      <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                      <SortedAscendingCellStyle BackColor="#F1F1F1" />
                      <SortedAscendingHeaderStyle BackColor="#0000A9" />
                      <SortedDescendingCellStyle BackColor="#CAC9C9" />
                      <SortedDescendingHeaderStyle BackColor="#000065" />
                  </asp:GridView>
                  <br />
                  <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
                      SelectCommand="SELECT Sale_Line.Line_ItemID, Sale_Line.Sale_ID, Products.Name, Products.Type, Sale_Line.Unit_Quantity, Sale_Line.Sale_Price, Sale_Line.Product_ID FROM Sale_Line INNER JOIN Products ON Sale_Line.Product_ID = Products.Product_ID WHERE (Sale_Line.Sale_ID = @saleID)">
                      <SelectParameters>
                          <asp:ControlParameter ControlID="Label9" Name="saleID" PropertyName="Text" />
                      </SelectParameters>
                  </asp:SqlDataSource>
                  <br />
                  <br />


              </div>
</div>



</asp:Content>

