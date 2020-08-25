<%@ Page Title="" Language="VB" MasterPageFile="~/Manager/ManagerMasterPage.master" AutoEventWireup="false" CodeFile="Edit Catalogue.aspx.vb" Inherits="Manager_Edit_Catalogue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width: 924px; height: 2388px; z-index: auto; position: inherit; top: auto; left: auto; background-image: url('../Wallpapers/834522_professional-backgrounds-for-websites-the-rho-chapter-of-delta_1600x1200_h.jpg');">
    
  
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConflictDetection="CompareAllValues" 
            ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
            DeleteCommand="DELETE FROM [Products] WHERE [Product_ID] = @original_Product_ID AND [Name] = @original_Name AND [Cost_Price] = @original_Cost_Price AND [Quantity] = @original_Quantity AND [Product_Description] = @original_Product_Description AND [Type] = @original_Type AND [Status] = @original_Status" 
            InsertCommand="INSERT INTO [Products] ([Name], [Cost_Price], [Quantity], [Product_Description], [Type], [Status]) VALUES (@Name, @Cost_Price, @Quantity, @Product_Description, @Type, @Status)" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT * FROM [Products] WHERE ([Type] = @Type)" 
            UpdateCommand="UPDATE [Products] SET [Name] = @Name, [Cost_Price] = @Cost_Price, [Quantity] = @Quantity, [Product_Description] = @Product_Description, [Type] = @Type, [Status] = @Status WHERE [Product_ID] = @original_Product_ID AND [Name] = @original_Name AND [Cost_Price] = @original_Cost_Price AND [Quantity] = @original_Quantity AND [Product_Description] = @original_Product_Description AND [Type] = @original_Type AND [Status] = @original_Status">
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
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="Type" 
                    PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Cost_Price" Type="Decimal" />
                <asp:Parameter Name="Quantity" Type="Int32" />
                <asp:Parameter Name="Product_Description" Type="String" />
                <asp:Parameter Name="Type" Type="String" />
                <asp:Parameter Name="Status" Type="String" />
                <asp:Parameter Name="original_Product_ID" Type="Int32" />
                <asp:Parameter Name="original_Name" Type="String" />
                <asp:Parameter Name="original_Cost_Price" Type="Decimal" />
                <asp:Parameter Name="original_Quantity" Type="Int32" />
                <asp:Parameter Name="original_Product_Description" Type="String" />
                <asp:Parameter Name="original_Type" Type="String" />
                <asp:Parameter Name="original_Status" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            Font-Names="Franklin Gothic Medium" Font-Size="Medium" Height="22px" 
            Width="264px">
            <asp:ListItem>Select Type</asp:ListItem>
            <asp:ListItem>SPEAKER</asp:ListItem>
            <asp:ListItem>INSTALLATION</asp:ListItem>
            <asp:ListItem>CD/MP3 RECEIVER</asp:ListItem>
            <asp:ListItem>AMPLIFIER</asp:ListItem>
            <asp:ListItem>SUBWOOFER</asp:ListItem>
            <asp:ListItem>DIGITAL MEDIA RECEIVER</asp:ListItem>
            <asp:ListItem>CABLE</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" DataKeyNames="Product_ID" DataSourceID="SqlDataSource1" 
            GridLines="Vertical" Height="54px" style="margin-left: 21px" Width="888px">
            <AlternatingRowStyle BackColor="Gainsboro" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" 
                    SortExpression="Name" />
                <asp:BoundField DataField="Cost_Price" DataFormatString="{0:c}" 
                    HeaderText="Cost_Price" SortExpression="Cost_Price" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" 
                    SortExpression="Quantity" />
                <asp:BoundField DataField="Product_Description" 
                    HeaderText="Product_Description" ReadOnly="True" 
                    SortExpression="Product_Description" />
                <asp:BoundField DataField="Status" HeaderText="Status" ReadOnly="True" 
                    SortExpression="Status" />
                <asp:ImageField DataImageUrlField="Product_ID" 
                    DataImageUrlFormatString="~\Images\{0}.JPG" HeaderText="Product Image" 
                    ReadOnly="True">
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
    
  
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    
  
</div>
</asp:Content>

