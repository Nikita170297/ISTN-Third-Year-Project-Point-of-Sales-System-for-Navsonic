Public Class SubmitInstallationReq
    Public friInID As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        InstallationPayment.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        If (txtECost.Text = "") Then
            MsgBox("Cost Cannot be Empty!")
            cmbEquipName.Enabled = True
            txtEquipName.Visible = False
            txtEquipName.Text = ""
            txtECost.Text = ""


        Else

            If cmbEquipName.Text = "" Then
                If txtEquipName.Text <> "" Then
                    Dim inputString As String = txtEquipName.Text & "      " & txtECost.Text
                    Dim Add As Decimal = txtECost.Text

                    Add = Add + txtequipCOst.Text

                    txtequipCOst.Text = Add
                    txtArea.AppendText(txtEquipName.Text & "      " & txtECost.Text & vbCrLf)
                Else
                    MsgBox("Please enter an equipment name!")
                End If

            Else

                Dim inputString As String = cmbEquipName.Text & "      " & txtECost.Text
                Dim Add As Decimal = txtECost.Text

                Add = Add + txtequipCOst.Text

                txtequipCOst.Text = Add
                txtArea.AppendText(cmbEquipName.Text & "     R " & txtECost.Text & vbCrLf)



            End If
        End If


        ' My.Computer.FileSystem.WriteAllText(
        '"C:\Users\Talia\Desktop\Final Project\TestMenu\TestMenu", inputString, True)
        cmbEquipName.Enabled = True
        txtEquipName.Visible = False
        cmbEquipName.Text = "Wiring"
        txtECost.Text = ""
        txtEquipName.Text = ""


    End Sub

    Private Sub SubmitInstallationReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group7DataSet.OutsourceAgent' table. You can move, or remove it, as needed.
        Me.OutsourceAgentTableAdapter1.Fill(Me.DSOutsource.OutsourceAgent)
        txtequipCOst.Text = "0,00"
        cmbStatus.Text = "Not Complete"
        Me.WindowState = FormWindowState.Maximized
        cmbEquipName.Text = "Wiring"
        txtEquipName.Visible = False


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ViewCust.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtCustID.Text = "" Or cmbAgent.Text = "" Then
            MsgBox("Incorrect/Empty Values In  Either Agent or Customer ID!")
            txtCustID.Clear()
            cmbAgent.Text = ""
            Exit Sub

        End If

        If txtequipCOst.Text = 0 Then
            MsgBox("Please add some equipment and their respective costs!")
            Exit Sub

        End If

        Dim AgentID As Integer
        Dim AgentFee As Decimal
        Dim NavsonicCharges As Decimal
        For i = 0 To DSOutsource.OutsourceAgent.Rows.Count - 1
            If DSOutsource.OutsourceAgent.Rows(i).Item(1) = cmbAgent.Text And txtCustID.Text <> "" Then
                AgentID = DSOutsource.OutsourceAgent.Rows(i).Item(0)
                AgentFee = DSOutsource.OutsourceAgent.Rows(i).Item(3)
                txtOutFee.Text = AgentFee
                NavsonicCharges = (AgentFee + txtequipCOst.Text) * 0.1
                Dim tot As Decimal = txtOutFee.Text + NavsonicCharges + txtequipCOst.Text
                txtNavCharges.Text = NavsonicCharges
                txtTotalCost.Text = tot

                Details_InstallationTableAdapter1.Insert(txtCustID.Text, AgentID, txtequipCOst.Text, NavsonicCharges, txtTotalCost.Text, cmbStatus.Text)
                Details_InstallationTableAdapter1.Fill(DSInstall.Details_Installation)
                MsgBox("Installation Logged!")
                InstallBS.MoveLast()

                Dim ID As Integer = txtInstallationID.Text
                friInID = txtInstallationID.Text
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("EquipCost.txt", True)
                file.WriteLine(ID & ".")
                file.WriteLine(txtArea.Text & vbCrLf)
                file.Close()
                InstallationPayment.Show()
                Me.Close()
                Exit Sub

                '  Else
                ' If txtCustID.Text <> "" Or cmbAgent.Text = "" Then
                'MsgBox("Incorrect/Empty Values In Textboxes!")
                'txtCustID.Clear()
                'cmbAgent.Text = ""
                'End If


            End If
        Next



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        txtCustID.Clear()
        txtInstallationID.Clear()
        cmbAgent.Text = ""
        txtequipCOst.Clear()
        txtOutFee.Clear()
        txtNavCharges.Clear()
        txtTotalCost.Clear()
        cmbStatus.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        UpdateInstallation.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub txtECost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtECost.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCustID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustID.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbEquipName.KeyPress
        If e.KeyChar <> "" Then



            e.Handled = True

        End If
    End Sub

    Private Sub cmbAgent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAgent.KeyPress
        If e.KeyChar <> "" Then



            e.Handled = True

        End If
    End Sub

    Private Sub txtEquipName_TextChanged(sender As Object, e As EventArgs) Handles txtEquipName.TextChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        cmbEquipName.Enabled = False
        cmbEquipName.Text = ""
        txtEquipName.Visible = True

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub
End Class