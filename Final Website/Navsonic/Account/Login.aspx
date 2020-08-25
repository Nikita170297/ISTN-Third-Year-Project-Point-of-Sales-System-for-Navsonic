<%@ Page Title="Log In" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeFile="Login.aspx.vb" Inherits="Account_Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div style="height: 418px; width: 920px">

     <h2>
        &nbsp;Log In
    </h2>
    <p style="font-family: 'Times New Roman', Times, serif; font-size: medium">
        Please enter your username and password.<asp:LinkButton ID="LinkButton1" 
            runat="server" PostBackUrl="~/Register2.aspx">Register</asp:LinkButton>
&nbsp;&nbsp;if you don't have an account.
    <asp:Login ID="LoginUser" runat="server" EnableViewState="False" 
        BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" 
        BorderWidth="1px" DestinationPageUrl="~/Default.aspx" 

        Font-Names="Verdana" Font-Size="10pt" Height="163px" Width="442px">
        <LayoutTemplate>
            <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                <tr>
                    <td>
                        <table cellpadding="0" style="height:163px;width:442px;">
                            <tr>
                                <td align="center" colspan="2" 
                                    style="color:White;background-color:#6B696B;font-weight:bold;">
                                    Log In</td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                        ControlToValidate="UserName" ErrorMessage="User Name is required." 
                                        ToolTip="User Name is required." ValidationGroup="LoginUser">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                        ControlToValidate="Password" ErrorMessage="Password is required." 
                                        ToolTip="Password is required." ValidationGroup="LoginUser">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time." />
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2" style="color:Red;">
                                    <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" colspan="2">
                                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" 
                                        ValidationGroup="LoginUser" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" 
            ForeColor="#FFFFFF" />
             </asp:Login>
             <div style="float: left; width: 54px;">
        </div>
    </p>
        &nbsp; 
        

        
    </div>

   
   
</asp:Content>