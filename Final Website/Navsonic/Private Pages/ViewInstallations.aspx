<%@ Page Title="" Language="VB" MasterPageFile="~/Private Pages/CustomerMasterPage.master" AutoEventWireup="false" CodeFile="ViewInstallations.aspx.vb" Inherits="Private_Pages_ViewInstallations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width: 101%; height: 478px; background-image: url('../Wallpapers/834522_professional-backgrounds-for-websites-the-rho-chapter-of-delta_1600x1200_h.jpg');">
     <div style="float: left; width: 35%; height: 399px;">
         <b style="font-family: 'AR BERKLEY'; font-weight: bold; color: #000000; font-size: x-large">
         Your Installations Summary<br />
         </b>
         <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
         <br />
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
             ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
             SelectCommand="SELECT Install_Payment.Installation_ID, OutsourceAgent.Name, OutsourceAgent.Surname, Details_Installation.Total_Cost, Install_Payment.Amount_Paid, Install_Payment.Date, Install_Payment.BalanceOfPayment, Details_Installation.Installation_Status FROM Details_Installation INNER JOIN Install_Payment ON Details_Installation.Installation_ID = Install_Payment.Installation_ID INNER JOIN OutsourceAgent ON Details_Installation.OutsourceAgent_ID = OutsourceAgent.OutsourceAgent_ID WHERE (Details_Installation.Customer_ID = @cust_ID)">
             <SelectParameters>
                 <asp:ControlParameter ControlID="Label1" Name="cust_ID" PropertyName="Text" />
             </SelectParameters>
         </asp:SqlDataSource>
         <br />
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
             DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" 
             GridLines="None" Height="248px" Width="919px">
             <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
             <Columns>
                 <asp:BoundField DataField="Installation_ID" HeaderText="Installation_ID" 
                     SortExpression="Installation_ID" />
                 <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                 <asp:BoundField DataField="Surname" HeaderText="Surname" 
                     SortExpression="Surname" />
                 <asp:BoundField DataField="Total_Cost" HeaderText="Total_Cost" 
                     SortExpression="Total_Cost" />
                 <asp:BoundField DataField="Amount_Paid" HeaderText="Amount_Paid" 
                     SortExpression="Amount_Paid" />
                 <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                 <asp:BoundField DataField="BalanceOfPayment" HeaderText="BalanceOfPayment" 
                     SortExpression="BalanceOfPayment" />
                 <asp:BoundField DataField="Installation_Status" 
                     HeaderText="Installation_Status" SortExpression="Installation_Status" />
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
    </div>
</asp:Content>

