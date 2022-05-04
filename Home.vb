
Public Class Home
    Private db As New DBAccess
    Private Sub ButtonDiscountHome_Click(sender As Object, e As EventArgs) Handles ButtonDiscountHome.Click
        Me.Close()
        DiscountHome.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles LabelLogout.Click
        Me.Close()
        LoginForm.Show()
        LoginForm.Focus()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonStaffHome.Click
        Me.Close()
        StaffForm.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Close()
        Menuform.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Me.Close()
        Customers.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Me.Close()
        frmOrdering_Type.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UserNameLabel.Text = strStaffName
        lblStaffID.Text = "Staff ID " & intStaffID & vbCrLf & strStaffName & vbCrLf & "Welcome!"

        db.AddParam("@StaffID", intStaffID)
        db.ExecuteQuery("SELECT * FROM staff WHERE staff_id = ?")
        If db.DBException <> String.Empty Then
            MessageBox.Show("DB Error: " & db.DBException)
            Exit Sub
        End If
        Dim role As String = String.Empty
        role = db.DBDataTable(0)!Role.ToString()

        If role = "Server" Then
            btnOrder.Enabled = True
            ButtonStaffHome.Enabled = False
            btnMenu.Enabled = False
            btnCustomer.Enabled = False
            ButtonDiscountHome.Enabled = False
        ElseIf role = "Manager" Or role = "Chef" Then
            btnOrder.Enabled = True
            ButtonStaffHome.Enabled = True
            btnMenu.Enabled = True
            btnCustomer.Enabled = True
            ButtonDiscountHome.Enabled = True
        End If

        Me.WindowState = FormWindowState.Maximized

    End Sub
End Class