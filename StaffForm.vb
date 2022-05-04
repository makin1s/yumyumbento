Public Class StaffForm
    Private DB As New DBAccess

    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DB.ExecuteQuery("SELECT * FROM staff")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        DBDataGridView.DataSource = DB.DBDataTable
        RecordToolStripStatusLabel.Text = "Record #: " & DB.RecordCount.ToString
        RefreshDBDataGridView()
        Me.WindowState = FormWindowState.Maximized
        UserNameLabel.Text = strStaffName
    End Sub

    Private Sub Searchstaff(StaffID As String, FirstName As String, LastName As String)
        DB.AddParam("@staffid", StaffID & "%")
        DB.AddParam("@firstname", FirstName & "%")
        DB.AddParam("@lastname", LastName & "%")
        DB.ExecuteQuery("SELECT * FROM staff WHERE Staff_ID LIKE ? AND FirstName LIKE ? AND LastName LIKE ?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        DBDataGridView.DataSource = DB.DBDataTable
        RecordToolStripStatusLabel.Text = "Record #: " & DB.RecordCount.ToString


    End Sub
    Private Sub InActiveStaff()
        If MessageBox.Show("Are you sure that you want to InActive the selected staff
record?", "InActive Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
DialogResult.No Then
            Exit Sub
        End If
        DB.AddParam("@staffid", StaffIDTextBox.Text)
        DB.ExecuteQuery("UPDATE staff SET Active = '0' WHERE Staff_ID=?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        MessageBox.Show("The Staff record has been updated successfully from the database.",
"InActive Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        InActiveButton.Enabled = False
        RefreshDBDataGridView()
        RefreshRecordToolStripStatusLabel()

    End Sub
    Private Sub RefreshDBDataGridView()
        DB.ExecuteQuery("SELECT * FROM staff ORDER BY Staff_ID ASC")
        DBDataGridView.DataSource = DB.DBDataTable
    End Sub
    Private Sub StaffIDTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles StaffIDTextBox.KeyUp
        Searchstaff(StaffIDTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text)
    End Sub
    Private Sub FirstNameTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles FirstNameTextBox.KeyUp
        Searchstaff(StaffIDTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text)
    End Sub
    Private Sub LastNameTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles LastNameTextBox.KeyUp
        Searchstaff(StaffIDTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text)
    End Sub
    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        NewStaffForm.ShowDialog()

    End Sub
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        EditStaffForm.ShowDialog()

    End Sub
    Private Sub DBDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridView.CellDoubleClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            Exit Sub
        End If

        EditStaffForm.ShowDialog()
    End Sub
    Private Sub InActiveButton_Click(sender As Object, e As EventArgs) Handles InActiveButton.Click
        InActiveStaff()
    End Sub
    Private Sub DBDataGridView_Click(sender As Object, e As EventArgs) Handles DBDataGridView.Click
        RefreshDBDataGridView()
    End Sub
    Private Sub RefreshRecordToolStripStatusLabel()
        DB.ExecuteQuery("SELECT * FROM staff ORDER BY Staff_ID ASC")
        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If
        DBDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub LabelLogout_Click(sender As Object, e As EventArgs) Handles LabelLogout.Click
        Me.Close()
        LoginForm.Show()
        LoginForm.Focus()
    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        Me.Close()
        Home.Show()
    End Sub
End Class
