<%@ Page Title="" Language="VB" MasterPageFile="~/Private Pages/CustomerMasterPage.master" AutoEventWireup="false" CodeFile="CustomerHome.aspx.vb" Inherits="Private_Pages_CustomerHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<div style="background-image: url('../Wallpapers/834522_professional-backgrounds-for-websites-the-rho-chapter-of-delta_1600x1200_h.jpg')">

<div align="center">
    <asp:Label ID="Label1" runat="server" Text="Nice Work Logging In" 
        Font-Italic="True" Font-Names="sitka" Font-Size="XX-Large" ForeColor="#0066FF"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Your Personal Details:" 
        Font-Italic="True" Font-Names="Sitka" Font-Size="X-Large" ForeColor="Black"></asp:Label>

</div>
<div align="center" style="height: 461px; width: 930px">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
        SelectCommand="SELECT * FROM [Customer_Details] WHERE ([Customer_ID] = @Customer_ID)">
        <SelectParameters>
            <asp:SessionParameter Name="Customer_ID" SessionField="Customer" Type="Int16" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:DetailsView ID="DetailsView1" runat="server" Height="395px" Width="481px" 
        AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" 
        DataKeyNames="Customer_ID" DataSourceID="SqlDataSource1">
        <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="Customer_ID" HeaderText="Customer_ID" 
                InsertVisible="False" ReadOnly="True" SortExpression="Customer_ID" />
            <asp:BoundField DataField="First_Name" HeaderText="First_Name" 
                SortExpression="First_Name" />
            <asp:BoundField DataField="Last_Name" HeaderText="Last_Name" 
                SortExpression="Last_Name" />
            <asp:BoundField DataField="Address" HeaderText="Address" 
                SortExpression="Address" />
            <asp:BoundField DataField="Contact_Number" HeaderText="Contact_Number" 
                SortExpression="Contact_Number" />
            <asp:BoundField DataField="Customer_Rewards" DataFormatString="{0:c}" 
                HeaderText="Customer_Rewards" SortExpression="Customer_Rewards" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
        </Fields>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    </asp:DetailsView>
</div>
</div>
</asp:Content>

