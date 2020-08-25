<%@ Page Title="" Language="VB" MasterPageFile="~/Private Pages/CustomerMasterPage.master" AutoEventWireup="false" CodeFile="OnlineSale.aspx.vb" Inherits="Private_Pages_OnlineSale" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<div style="border: thin solid #808080; width: 100%; height: 98%">

    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
        SelectCommand="SELECT * FROM [Products] WHERE ([Type] = @Type)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList3" Name="Type" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
    <div align="center">
        <asp:Label ID="Label2" runat="server" Text=" Treat Yourself! You deserve it" 
            Font-Bold="True" Font-Italic="True" Font-Names="Sitka Text" Font-Size="Large" 
            ForeColor="#3366FF"></asp:Label>
        <br />
    </div>

    <div align="center">
     <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
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
    <asp:Label ID="Label1" runat="server" Font-Italic="True" 
        Font-Names="Sitka Small" Font-Size="Medium" ForeColor="Red" 
        Text="Please Select Product Type" Visible="False"></asp:Label>
    <br />
    </div>
       <div align="center">
       <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4" DataKeyNames="Product_ID" DataSourceID="SqlDataSource2" 
        ForeColor="Black" GridLines="Vertical" Height="50px" Width="373px" 
        AllowPaging="True">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="Product_ID" HeaderText="Product_ID" 
                InsertVisible="False" ReadOnly="True" SortExpression="Product_ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Cost_Price" HeaderText="Cost_Price" 
                SortExpression="Cost_Price" />
            <asp:BoundField DataField="Product_Description" 
                HeaderText="Product_Description" SortExpression="Product_Description" />
            <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
            <asp:BoundField DataField="Status" HeaderText="Status" 
                SortExpression="Status" />
            <asp:TemplateField HeaderText="Quantity To Purchase">
                <ItemTemplate>
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:ImageField DataImageUrlField="Product_ID" 
                DataImageUrlFormatString="~/Images/{0}.JPG" HeaderText="Product Image">
            </asp:ImageField>
        </Fields>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
    </asp:DetailsView>
       </div>
    
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Add To Cart" Font-Bold="True" 
        Font-Names="Bahnschrift SemiBold" Font-Size="Medium" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Clear Cart" Font-Bold="True" 
        Font-Names="Bahnschrift SemiBold" Font-Size="Medium" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Text="CheckOut" 
        PostBackUrl="~/Private Pages/Checkout.aspx" Font-Bold="True" 
        Font-Names="Bahnschrift SemiBold" Font-Size="Medium" />
    <br />
    <br />
   
   <div align="center">
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
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


