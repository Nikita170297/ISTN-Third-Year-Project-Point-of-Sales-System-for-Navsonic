<%@ Page Title="" Language="VB" MasterPageFile="~/Private Pages/CustomerMasterPage.master" AutoEventWireup="false" CodeFile="ViewRepairs.aspx.vb" Inherits="Private_Pages_ViewRepairs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width: 101%; height: 560px; background-image: url('../Wallpapers/834522_professional-backgrounds-for-websites-the-rho-chapter-of-delta_1600x1200_h.jpg');">
     <div style="float: left; width: 35%; height: 334px;">
         <b style="font-size: x-large; color: #000000; font-family: 'AR BERKLEY'; font-weight: bold"> 
         Your Repairs Summary<br />
         </b>
         <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
         <br />
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
             ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
             SelectCommand="SELECT Repair_Payment.Repair_ID, Repair_Details.Repair_Description, Repair_Details.Repair_Price, Repair_Details.Status, Repair_Payment.Amount_Paid, Repair_Payment.Date, Repair_Payment.BalanceOfPayment FROM Repair_Details INNER JOIN Repair_Payment ON Repair_Details.Repair_ID = Repair_Payment.Repair_ID WHERE (Repair_Details.Customer_ID = @cust_ID)">
             <SelectParameters>
                 <asp:ControlParameter ControlID="Label1" Name="cust_ID" PropertyName="Text" />
             </SelectParameters>
         </asp:SqlDataSource>
         <br />
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
             DataSourceID="SqlDataSource1" Height="396px" CellPadding="4" 
             ForeColor="#333333" GridLines="None" Width="917px">
             <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
             <Columns>
                 <asp:BoundField DataField="Repair_ID" HeaderText="Repair_ID" 
                     SortExpression="Repair_ID" />
                 <asp:BoundField DataField="Repair_Description" HeaderText="Repair_Description" 
                     SortExpression="Repair_Description" />
                 <asp:BoundField DataField="Repair_Price" HeaderText="Repair_Price" 
                     SortExpression="Repair_Price" />
                 <asp:BoundField DataField="Status" HeaderText="Status" 
                     SortExpression="Status" />
                 <asp:BoundField DataField="Amount_Paid" HeaderText="Amount_Paid" 
                     SortExpression="Amount_Paid" />
                 <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                 <asp:BoundField DataField="BalanceOfPayment" HeaderText="BalanceOfPayment" 
                     SortExpression="BalanceOfPayment" />
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
     </div>
     <div style="float: left; width: 60%; font-family: 'AR BLANCA'; font-weight: bold; font-size: x-large;">
         &nbsp; </div>
  </div>
</asp:Content>

