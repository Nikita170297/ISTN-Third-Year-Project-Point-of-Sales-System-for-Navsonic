Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ViewCustomerAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CreateCustomerAccountToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EditCustomerAccountToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub MakeASaleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MakeASaleToolStripMenuItem1.Click
        MakeASale.Show()


    End Sub

    Private Sub RefundsToolStripMenuItem_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub CreateCustomerAccountToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CreateCustomerAccountToolStripMenuItem.Click
        CreateCust.Show()


    End Sub

    Private Sub EditCustomerAccountToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EditCustomerAccountToolStripMenuItem.Click
        EditCustomer.Show()


    End Sub

    Private Sub ViewCustomerAccountsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ViewCustomerAccountsToolStripMenuItem.Click
        ViewCust.Show()


    End Sub

    Private Sub SubmitRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitRequestToolStripMenuItem.Click
        SubmitInstallationReq.Show()


    End Sub

    Private Sub ViewCurrentInstallationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCurrentInstallationsToolStripMenuItem.Click
        ViewCurrentInstallations.Show()


    End Sub

    Private Sub UpdateInstallationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInstallationsToolStripMenuItem.Click
        UpdateInstallation.Show()


    End Sub

    Private Sub LogAFaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogAFaultToolStripMenuItem.Click
        SubmitRepair.Show()


    End Sub

    Private Sub ViewCurrentRepairsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCurrentRepairsToolStripMenuItem.Click
        UpdateRepair.Show()


    End Sub

    Private Sub UpdateRepairPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRepairPaymentsToolStripMenuItem.Click
        RepairPayment.Show()


    End Sub

    Private Sub SearchProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchProductToolStripMenuItem.Click
        SearchProduct.Show()


    End Sub

    Private Sub txtUpdateSu_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
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
        Form1.Close()
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
        About.Close()
        Help.Close()

        ViewSup.Close()

        Login.Show()
        Me.Close()
    End Sub
End Class