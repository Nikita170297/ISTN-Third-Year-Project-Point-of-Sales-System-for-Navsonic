<%@ Page Title="" Language="VB" MasterPageFile="~/Manager/ManagerMasterPage.master" AutoEventWireup="false" CodeFile="StaffSales.aspx.vb" Inherits="Manager_StaffSales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="height: 697px">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConflictDetection="CompareAllValues" 
            ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
            DeleteCommand="DELETE FROM [Staff] WHERE [StaffID] = @original_StaffID AND [First_Name] = @original_First_Name AND [Last_Name] = @original_Last_Name AND [Full_Salary] = @original_Full_Salary AND [Job_Title] = @original_Job_Title AND [EmailAddress] = @original_EmailAddress" 
            InsertCommand="INSERT INTO [Staff] ([First_Name], [Last_Name], [Full_Salary], [Job_Title], [EmailAddress]) VALUES (@First_Name, @Last_Name, @Full_Salary, @Job_Title, @EmailAddress)" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT [StaffID], [First_Name], [Last_Name], [Full_Salary], [Job_Title], [EmailAddress] FROM [Staff]" 
            UpdateCommand="UPDATE [Staff] SET [First_Name] = @First_Name, [Last_Name] = @Last_Name, [Full_Salary] = @Full_Salary, [Job_Title] = @Job_Title, [EmailAddress] = @EmailAddress WHERE [StaffID] = @original_StaffID AND [First_Name] = @original_First_Name AND [Last_Name] = @original_Last_Name AND [Full_Salary] = @original_Full_Salary AND [Job_Title] = @original_Job_Title AND [EmailAddress] = @original_EmailAddress">
        <DeleteParameters>
            <asp:Parameter Name="original_StaffID" Type="Int32" />
            <asp:Parameter Name="original_First_Name" Type="String" />
            <asp:Parameter Name="original_Last_Name" Type="String" />
            <asp:Parameter Name="original_Full_Salary" Type="Decimal" />
            <asp:Parameter Name="original_Job_Title" Type="String" />
            <asp:Parameter Name="original_EmailAddress" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="First_Name" Type="String" />
            <asp:Parameter Name="Last_Name" Type="String" />
            <asp:Parameter Name="Full_Salary" Type="Decimal" />
            <asp:Parameter Name="Job_Title" Type="String" />
            <asp:Parameter Name="EmailAddress" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="First_Name" Type="String" />
            <asp:Parameter Name="Last_Name" Type="String" />
            <asp:Parameter Name="Full_Salary" Type="Decimal" />
            <asp:Parameter Name="Job_Title" Type="String" />
            <asp:Parameter Name="EmailAddress" Type="String" />
            <asp:Parameter Name="original_StaffID" Type="Int32" />
            <asp:Parameter Name="original_First_Name" Type="String" />
            <asp:Parameter Name="original_Last_Name" Type="String" />
            <asp:Parameter Name="original_Full_Salary" Type="Decimal" />
            <asp:Parameter Name="original_Job_Title" Type="String" />
            <asp:Parameter Name="original_EmailAddress" Type="String" />
        </UpdateParameters>
        </asp:SqlDataSource>
        <div align="center" style="background-color: #FF9999">
            <asp:Label ID="Label1" runat="server" Text="Staff Members" Font-Italic="True" 
                Font-Names="sitka small" Font-Size="Medium"></asp:Label>
            <br />
        </div>
        <div align="center" style="width: 922px; height: 376px">
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
                DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" 
                Height="58px" Width="485px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
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
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>

        <div align="center" style="background-color: #FFCC66">
            <asp:Label ID="Label2" runat="server" Text="Staff Member Sales" 
                Font-Italic="True" Font-Names="Sitka Small" Font-Size="Medium"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="0" Visible="False"></asp:Label>
        </div>

        <div align="center">
            <asp:GridView ID="GridView2" runat="server" BackColor="White" 
                BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                DataSourceID="SqlDataSource2" GridLines="Horizontal" Visible="False" 
                Width="497px">
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
        </div>

        <div align="right">
            <br />
            <br />
            <br />
           <asp:Label ID="Label4" runat="server" Text="Total Sales   " Font-Bold="True" 
                Font-Names="sitka small" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="30px" ReadOnly="True"></asp:TextBox>
        </div>
        


</div>
</asp:Content>

