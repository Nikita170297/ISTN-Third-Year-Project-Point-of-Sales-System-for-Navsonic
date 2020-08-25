<%@ Page Title="" Language="VB" MasterPageFile="~/Manager/ManagerMasterPage.master" AutoEventWireup="false" CodeFile="ManagerHelp.aspx.vb" Inherits="Manager_ManagerHelp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="height: 51px; margin-top: 7px;text-align:center;font-family:Cambria Math;Color:Black;font-size:20px">
         <b>Since you are a manager you have privileged access to our website.</b> </div>
        <div style="height:64px; text-align:center;font-family:Cambria Math;Color:Black;font-size:20px"><b> Here's everything you need to know about how to navigate your way around !</b>
    </div>

    <div style="height:34px; Color:Black">
        You have a choice of Viewing Reports, Viewing Stock , Updating Stock of Viewing the Sales made by Staff.

    </div>

    <div style="height:63px; Color:Black"> 
        So if you choose to view all the Reports about Supplier Orders , Installation Payments or Online Sales. All of these reports have 
        the Date showing when you accessed each report , so all information is dated.
    </div>

    <div style="height:75px; Color:Black">
        The "Supplier Order Report" shows you the status of the suppliers business so that we will know if they are still in business or have closed down. This report basically tells you how much we buy from each of our suppliers. It also shows 
        you a "Total Cost" which indicates how much we have spent collectively on all suppliers. All of this is shown on the bar
        graph so it is easy to visualize.

    </div>

    <div style="height:77px; Color:Black">
       The "Installation Payment Report" uses a cross tab table and a bar graph. In the cross tab table the customer's ID as well as the 
       installation ID is shown, so if a customer has more than 1 installation we can easily view it. For each customer you will see
       that the amount that they have paid as well as the balance owing is shown. Finally the total at the bottom represents the total
       of the balance due by all customers.
    </div>

    <div style="height:80px; Color:Black"> 
       The "Online Sales Report" shows the staff. The customers who have purchased from us online is shown
       as well as the amount that they purchased for. The subtotal represents the total that the customer bought online for and the total represents 
       the total amount that was bought online by all customers.

    </div>

    <div style="height:49px; margin-top: 5px;Color:Black">
       If you choose to View Stock ,you simply click on "View Catalogue" and here you will be able to see all of the products we have in stock.
    </div>

    <div style="height:43px; Color:Black">
       If you choose to Update Stock, you simply click on "Update Catalogue" and here you will be able to update the prices and quantity
       on hand of our products.
    </div>

    <div style="height:40px;Color:Black ">
       If you choose to check the progress of your staff, simply click on "View Staff Sales" ,and here you can select a staff member and view 
       all of the sales they made
    </div>
</asp:Content>

