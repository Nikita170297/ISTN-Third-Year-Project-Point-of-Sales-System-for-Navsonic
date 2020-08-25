<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Create Account.aspx.vb" Inherits="Public_Pages_Page1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="height: 656px; width: 943px; background-image: url('../Wallpapers/834522_professional-backgrounds-for-websites-the-rho-chapter-of-delta_1600x1200_h.jpg');">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConflictDetection="CompareAllValues" 
            ConnectionString="<%$ ConnectionStrings:NavsonicConnectionString %>" 
            DeleteCommand="DELETE FROM [Customer_Details] WHERE [Customer_ID] = @original_Customer_ID AND [First_Name] = @original_First_Name AND [Last_Name] = @original_Last_Name AND [Address] = @original_Address AND [Contact_Number] = @original_Contact_Number AND (([Customer_Rewards] = @original_Customer_Rewards) OR ([Customer_Rewards] IS NULL AND @original_Customer_Rewards IS NULL)) AND (([Email] = @original_Email) OR ([Email] IS NULL AND @original_Email IS NULL)) AND [Status] = @original_Status" 
            InsertCommand="INSERT INTO Customer_Details(First_Name, Last_Name, Address, Contact_Number, Customer_Rewards, Email, Status) VALUES (@First_Name, @Last_Name, @Address, @Contact_Number, @Customer_Rewards, @Email, @Status); SELECT @id = SCOPE_IDENTITY()" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT * FROM [Customer_Details]" 
            UpdateCommand="UPDATE [Customer_Details] SET [First_Name] = @First_Name, [Last_Name] = @Last_Name, [Address] = @Address, [Contact_Number] = @Contact_Number, [Customer_Rewards] = @Customer_Rewards, [Email] = @Email, [Status] = @Status WHERE [Customer_ID] = @original_Customer_ID AND [First_Name] = @original_First_Name AND [Last_Name] = @original_Last_Name AND [Address] = @original_Address AND [Contact_Number] = @original_Contact_Number AND (([Customer_Rewards] = @original_Customer_Rewards) OR ([Customer_Rewards] IS NULL AND @original_Customer_Rewards IS NULL)) AND (([Email] = @original_Email) OR ([Email] IS NULL AND @original_Email IS NULL)) AND [Status] = @original_Status">
            <DeleteParameters>
                <asp:Parameter Name="original_Customer_ID" Type="Int16" />
                <asp:Parameter Name="original_First_Name" Type="String" />
                <asp:Parameter Name="original_Last_Name" Type="String" />
                <asp:Parameter Name="original_Address" Type="String" />
                <asp:Parameter Name="original_Contact_Number" Type="String" />
                <asp:Parameter Name="original_Customer_Rewards" Type="Decimal" />
                <asp:Parameter Name="original_Email" Type="String" />
                <asp:Parameter Name="original_Status" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="First_Name" 
                    PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="TextBox2" Name="Last_Name" PropertyName="Text" 
                    Type="String" />
                <asp:ControlParameter ControlID="TextBox6" Name="Address" PropertyName="Text" 
                    Type="String" />
                <asp:ControlParameter ControlID="TextBox4" Name="Contact_Number" 
                    PropertyName="Text" Type="String" />
                <asp:Parameter DefaultValue="0,00" Name="Customer_Rewards" Type="Decimal" />
                <asp:ControlParameter ControlID="TextBox5" DefaultValue="" Name="Email" 
                    PropertyName="Text" Type="String" />
                <asp:Parameter DefaultValue="Active" Name="Status" Type="String" />
                <asp:Parameter DefaultValue="0" Direction="Output" Name="id" Size="1000" 
                    Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="First_Name" Type="String" />
                <asp:Parameter Name="Last_Name" Type="String" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="Contact_Number" Type="String" />
                <asp:Parameter Name="Customer_Rewards" Type="Decimal" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Status" Type="String" />
                <asp:Parameter Name="original_Customer_ID" Type="Int16" />
                <asp:Parameter Name="original_First_Name" Type="String" />
                <asp:Parameter Name="original_Last_Name" Type="String" />
                <asp:Parameter Name="original_Address" Type="String" />
                <asp:Parameter Name="original_Contact_Number" Type="String" />
                <asp:Parameter Name="original_Customer_Rewards" Type="Decimal" />
                <asp:Parameter Name="original_Email" Type="String" />
                <asp:Parameter Name="original_Status" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Italic="True" 
            Font-Names="Bookman Old Style" Font-Size="Medium" ForeColor="Black" 
            Text="First Name(s)"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Font-Names="Arial" Font-Size="Medium"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="RequiredField*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
            runat="server" ControlToValidate="TextBox1" 
            ErrorMessage="Only Alphabets Allowed Here" ForeColor="Red" 
            ValidationExpression="^[A-Za-z]*$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <br />
        &nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Italic="True" 
            Font-Names="Bookman Old Style" Font-Size="Medium" ForeColor="Black" 
            Text="Surname"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Font-Names="Arial" Font-Size="Medium"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="RequiredField*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
            runat="server" ControlToValidate="TextBox2" 
            ErrorMessage="Only Alphabets Allowed Here" ForeColor="Red"></asp:RegularExpressionValidator>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Font-Bold="False" Font-Italic="True" 
            Font-Names="Bookman Old Style" Font-Size="Medium" ForeColor="Black" 
            Text="Contact Number"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" Font-Names="Arial" Font-Size="Medium"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="TextBox4" ErrorMessage="RequiredField*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="TextBox4" ErrorMessage=" Ensure Only Numbers Are Inputted" 
            ForeColor="Red" MaximumValue="10000000000" MinimumValue="0"></asp:RangeValidator>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Font-Bold="False" Font-Italic="True" 
            Font-Names="Bookman Old Style" Font-Size="Medium" ForeColor="Black" 
            Text="Email Address"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Font-Names="Arial" Font-Size="Medium"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="TextBox5" ErrorMessage="RequiredField*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Font-Bold="False" Font-Italic="True" 
            Font-Names="Bookman Old Style" Font-Size="Medium" ForeColor="Black" 
            Text="Address"></asp:Label>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Font-Names="Arial" Font-Size="Medium"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="TextBox6" ErrorMessage="RequiredField*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Font-Bold="False" 
            Font-Names="Bahnschrift SemiBold" Font-Size="Large" Height="35px" 
            Text="Create Account" Width="213px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Font-Bold="False" Font-Italic="True" 
            Font-Names="Bookman Old Style" Font-Size="Medium" ForeColor="Black" 
            Text="Please Remember Your Customer ID" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" Font-Names="Arial" Font-Size="Medium" 
            Visible="False" Width="149px"></asp:TextBox>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Font-Bold="False" 
            Font-Names="Bahnschrift SemiBold" Font-Size="Large" Height="35px" 
            Text="Register Account" Width="197px" PostBackUrl="~/Register2.aspx" 
            Visible="False" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </div>

</asp:Content>

