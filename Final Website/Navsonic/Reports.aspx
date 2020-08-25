<%@ Page Title="" Language="VB" MasterPageFile="~/Manager/ManagerMasterPage.master" AutoEventWireup="false" CodeFile="Reports.aspx.vb" Inherits="Reports" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div><br />
        <asp:Button ID="Button1" runat="server" Text="View Supplier Orders" 
            Font-Names="Bahnschrift SemiBold" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="View Installation Payments" 
            Font-Names="Bahnschrift SemiBold" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="View Online Sales" 
            Font-Names="Bahnschrift SemiBold" />
&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Font-Names="Bahnschrift SemiBold" 
            PostBackUrl="~/Manager/ManagerHome.aspx" Text="Back To Home" Width="131px" />
        <CR:CrystalReportViewer ID="CrystalReportViewer3" runat="server" 
            AutoDataBind="True" EnableDatabaseLogonPrompt="False" 
            EnableParameterPrompt="False" GroupTreeImagesFolderUrl="" Height="1202px" 
            ReportSourceID="CrystalReportSource3" ToolbarImagesFolderUrl="" 
            ToolPanelView="None" ToolPanelWidth="200px" Visible="False" Width="903px" />
        <CR:CrystalReportSource ID="CrystalReportSource3" runat="server">
            <Report FileName="OnlineSalesReport.rpt">
            </Report>
        </CR:CrystalReportSource>
        <CR:CrystalReportViewer ID="CrystalReportViewer2" runat="server" 
            AutoDataBind="True" EnableDatabaseLogonPrompt="False" 
            EnableParameterPrompt="False" GroupTreeImagesFolderUrl="" Height="1202px" 
            ReportSourceID="CrystalReportSource2" ToolbarImagesFolderUrl="" 
            ToolPanelView="None" ToolPanelWidth="200px" Visible="False" Width="1104px" />
        <CR:CrystalReportSource ID="CrystalReportSource2" runat="server">
            <Report FileName="InstallationPaymentReport.rpt">
            </Report>
        </CR:CrystalReportSource>
        <br />
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
            AutoDataBind="True" EnableDatabaseLogonPrompt="False" 
            EnableParameterPrompt="False" GroupTreeImagesFolderUrl="" Height="1202px" 
            ReportSourceID="CrystalReportSource1" ToolbarImagesFolderUrl="" 
            ToolPanelView="None" ToolPanelWidth="200px" Visible="False" Width="1104px" />
        <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
            <Report FileName="SupplierOrderReport.rpt">
            </Report>
        </CR:CrystalReportSource>
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
    <p>
        <br />
&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    </asp:Content>

