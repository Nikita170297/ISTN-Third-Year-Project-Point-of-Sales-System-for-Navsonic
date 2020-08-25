Public Class CreateCust
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtEmail.Clear()
        txtLName.Clear()
        txtNumber.Clear()
        txtAddress.Clear()
        cmbStatus.Text = ""

        

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCustRewards.TextChanged

    End Sub

    Private Sub CreateCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCustRewards.Text = "R0.00"
        cmbStatus.Text = "Active"
        txtCustID.Visible = False

        Customer_DetailsTableAdapter1.Fill(Me.DSCust.Customer_Details)
        Cust_PasswordsTableAdapter1.Fill(Me.DSCust.Cust_Passwords)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, Button1.Click
        Dim Pass As String = ""
        Dim name As String = ""
        Dim surname As String = ""
        Dim ran As String = ""

        Dim rn As New Random

        Try
            If (txtName.Text <> "" And txtLName.Text <> "" And txtEmail.Text <> "" And txtNumber.Text <> "" And txtEmail.Text <> "") Then
                BindingSource1.MoveLast()

                Dim custrewards As Decimal = 0.0
                Customer_DetailsTableAdapter1.Insert(txtName.Text, txtLName.Text, txtAddress.Text, txtNumber.Text, custrewards, txtEmail.Text, cmbStatus.Text)
                MsgBox("Customer Added!")
                BindingSource1.MoveLast()
                MessageBox.Show("Your Customer ID is : " & txtCustID.Text)
                'name = txtName.Text.Substring(0, 1)
                'surname = txtLName.Text.Substring(0, 1)
                'ran = Convert.ToString(Convert.ToInt32(rn.Next(100, 10000)))
                'MessageBox.Show(ran)


                'Pass = (name + surname + ran)
                'Cust_PasswordsTableAdapter1.Insert(txtCustID.Text, Pass)
                'MessageBox.Show("Your Password is : " & Pass)

                Customer_DetailsTableAdapter1.Fill(Me.DSCust.Customer_Details)
                'Cust_PasswordsTableAdapter1.Fill(Me.DSCust.Cust_Passwords)
                txtName.Clear()
                txtEmail.Clear()
                txtLName.Clear()
                txtNumber.Clear()
                txtAddress.Clear()
                BindingSource1.MoveLast()

                txtCustRewards.Text = "R0.00"
                cmbStatus.Text = "Active"
                'txtCustID.Visible = False
                Me.Close()


            Else
                MessageBox.Show("Please Fill in all details")
            End If

        Catch ex As Exception
            MessageBox.Show("Please ensure all details are correct")





        End Try
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
            e.Handled = False



        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtLName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLName.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
            e.Handled = False



        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class