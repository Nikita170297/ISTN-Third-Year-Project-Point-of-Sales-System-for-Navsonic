Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub StaffMembersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub AddNewStToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        MessageBox.Show("You do not have access to Staff Members", "Unauthorized Access - User13", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ManagerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub AddNewSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewSupplierToolStripMenuItem.Click

        AddSupplier.Show()



    End Sub

    Private Sub ViewSuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSuppliersToolStripMenuItem.Click
        ViewSup.Show()



    End Sub

    Private Sub AddNewStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStaffToolStripMenuItem.Click
        addStaffMember.Show()



    End Sub

    Private Sub ViewStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStaffToolStripMenuItem.Click
        ViewStaff.Show()


    End Sub

    Private Sub CreateCustomerAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateCustomerAccountToolStripMenuItem.Click
        CreateCust.Show()


    End Sub

    Private Sub EditCustomerAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCustomerAccountToolStripMenuItem.Click
        EditCustomer.Show()

    End Sub

    Private Sub ViewCustomerAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomerAccountsToolStripMenuItem.Click
        ViewCust.Show()


    End Sub

    Private Sub SearchProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchProductToolStripMenuItem.Click
        SearchProduct.Show()


    End Sub

    Private Sub ViewInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInventoryToolStripMenuItem.Click
        ViewProducts.Show()



    End Sub

    Private Sub ExchangeToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub RefundsToolStripMenuItem_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub LogAFaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogAFaultToolStripMenuItem.Click
        SubmitRepair.Show()



    End Sub

    Private Sub ViewCurrentInstallationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCurrentInstallationsToolStripMenuItem.Click
        ViewCurrentInstallations.Show()



    End Sub

    Private Sub MakeASaleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MakeASaleToolStripMenuItem1.Click
        MakeASale.Show()


    End Sub

    Private Sub SubmitRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitRequestToolStripMenuItem.Click
        SubmitInstallationReq.Show()



    End Sub

    Private Sub ViewCurrentRepairsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCurrentRepairsToolStripMenuItem.Click
        UpdateRepair.Show()


    End Sub

    Private Sub OrderNewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderNewProductToolStripMenuItem.Click
        Order_Stock.Show()



    End Sub

    Private Sub ReceiveProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveProductToolStripMenuItem.Click
        Update_Inventory.Show()



    End Sub

    Private Sub UpdateInstallationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInstallationsToolStripMenuItem.Click
        UpdateInstallation.Show()



    End Sub

    Private Sub UpdateInstallationPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUpdateSu_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub UpdateRepairPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRepairPaymentsToolStripMenuItem.Click
        AddRepairPayments.Show()


    End Sub

    Private Sub AddNewOutsourceAgentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewOutsourceAgentToolStripMenuItem.Click
        AddNewOutsourceAgent.Show()

    End Sub

    Private Sub RepairsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepairsToolStripMenuItem.Click

    End Sub

    Private Sub ViewUpdateOutsourceAgentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewUpdateOutsourceAgentToolStripMenuItem.Click
        Outsource_Agent.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()

    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        Help.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        AddNewOutsourceAgent.Close()
        AddRepairPayments.Close()
        addStaffMember.Close()
        AddSupplier.Close()
        CreateCust.Close()
        EditCustomer.Close()
        Form3.Close()
        Welcome.Close()
        InstallationPayment.Close()


        MakeASale.Close()
        Order_New_Product.Close()
        Order_Stock.Close()
        Outsource_Agent.Close()

        RepairPayment.Close()
        SearchProduct.Close()
        SubmitInstallationReq.Close()
        SubmitRepair.Close()
        Update_Inventory.Close()
        UpdateInstallation.Close()
        UpdateRepair.Close()
        ViewCurrentInstallations.Close()
        ViewCust.Close()
        ViewProducts.Close()
        ViewStaff.Close()
        ViewSup.Close()
        About.Close()
        Help.Close()


        Login.Show()
        Me.Close()
    End Sub
End Class