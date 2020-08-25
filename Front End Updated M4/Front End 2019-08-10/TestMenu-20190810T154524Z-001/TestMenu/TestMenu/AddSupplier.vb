Public Class AddSupplier


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtSuAddress.Clear()
        txtSuEmail.Clear()
        txtSuName.Clear()
        MaskedTextBox1.Clear()

    End Sub

    Private Sub txtAddSu_Click(sender As Object, e As EventArgs) Handles txtAddSu.Click



        Try
            If (txtSuName.Text <> "" And txtSuAddress.Text <> "" And txtSuEmail.Text <> "" And MaskedTextBox1.Text <> "") Then
                SupplierTableAdapter1.Insert(txtSuName.Text, txtSuAddress.Text, MaskedTextBox1.Text, txtSuEmail.Text, ComboBox1.Text)
                MsgBox("Supplier Added!")
                Me.Close()

            Else
                MessageBox.Show("Please fill in all details")
            End If

        Catch ex As Exception
            MessageBox.Show("Please ensure all details are correct")
        Finally
            txtSuAddress.Clear()
            txtSuEmail.Clear()
            txtSuName.Clear()
            MaskedTextBox1.Clear()
        End Try


    End Sub


    Private Sub AddSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Active"
        ComboBox1.Enabled = False

    End Sub

    Private Sub txtSuName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSuName.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
            e.Handled = False



        Else
            e.Handled = True

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class