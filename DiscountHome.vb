' Designed by Sridevi

Public Class DiscountHome

    Private DB As New DBAccess
    Private ActiveRowIndex As Integer
    Private Sub ButtonAddDiscount_Click(sender As Object, e As EventArgs) Handles ButtonAddDiscount.Click
        ClearDiscountDetails()
        EnableDiscountFieldsforEdit(True)
        DiscountActiveCheckbox.Checked = True
    End Sub

    Private Sub ButtonEditDiscount_Click(sender As Object, e As EventArgs) Handles ButtonEditDiscount.Click
        If ButtonEditDiscount.Text = "Edit" Then
            'edit mode
            EnableDiscountFieldsforEdit(True)
        Else

            If String.IsNullOrWhiteSpace(DiscountIDTextBox.Text) Then
                'add a new record
                AddNewDiscount()
            Else
                'update an existing record
                UpdateDiscount()
            End If
        End If
    End Sub

    Private Sub DiscountHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserNameLabel.Text = strStaffName
        DB.ExecuteQuery("SELECT * FROM discount")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        DiscountDataGridView.DataSource = DB.DBDataTable ' Pass discount data to data grid control
        DiscountCount.Text = "Discount #:" & DB.RecordCount.ToString

        ClearDiscountDetails()

        EnableDiscountFieldsforEdit(False)

        Me.WindowState = FormWindowState.Maximized

    End Sub


    Private Sub SearchDiscount()
        DB.AddParam("@discount", DiscountSearchTextBox.Text & "%")
        DB.AddParam("@description", DiscountSearchDescrTextBox.Text & "%")

        DB.ExecuteQuery("SELECT * FROM discount WHERE discount LIKE ? AND description LIKE ?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        DiscountDataGridView.DataSource = DB.DBDataTable
        DiscountCount.Text = "Discount #:" & DB.RecordCount.ToString
    End Sub

    Private Sub DiscountSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiscountSearchTextBox.TextChanged
        SearchDiscount()
    End Sub

    Private Sub DiscountSearchDescrTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiscountSearchDescrTextBox.TextChanged
        SearchDiscount()
    End Sub

    Private Sub ClearDiscountDetails()
        DiscountIDTextBox.Clear()
        DiscountTextBox.Clear()
        DiscountDescrTextBox.Clear()
        DiscountStartDate.Value = Today.Date
        DiscountEndDate.Value = Today.Date
        DiscountActiveCheckbox.Checked = False
        DiscountCreatedOn.Value = Today.Date
        DiscountUpdatedOn.Value = Today.Date

        ButtonEditDiscount.Enabled = False
        ButtonDeleteDiscount.Enabled = False

    End Sub

    Private Sub EnableDiscountFieldsforEdit(Switch As Boolean)
        DiscountIDTextBox.Enabled = False
        DiscountTextBox.Enabled = If((Switch And String.IsNullOrWhiteSpace(DiscountTextBox.Text)), True, False)
        DiscountDescrTextBox.Enabled = Switch
        DiscountStartDate.Enabled = Switch
        DiscountEndDate.Enabled = Switch
        DiscountActiveCheckbox.Enabled = False
        DiscountCreatedOn.Enabled = False
        DiscountUpdatedOn.Enabled = False

        If Switch = True Then
            ButtonEditDiscount.Text = "Save"
            ButtonAddDiscount.Enabled = False

            ButtonEditDiscount.Enabled = True
            ButtonCancelDiscount.Enabled = True
        Else
            ButtonEditDiscount.Text = "Edit"
            ButtonAddDiscount.Enabled = True

            ButtonEditDiscount.Enabled = False
            ButtonCancelDiscount.Enabled = False
        End If
    End Sub

    Private Sub ButtonCancelDiscount_Click(sender As Object, e As EventArgs) Handles ButtonCancelDiscount.Click
        ClearDiscountDetails()
        EnableDiscountFieldsforEdit(False)
    End Sub

    Private Sub AddNewDiscount()
        If ValidateDiscount() = False Then
            Exit Sub
        End If

        DB.AddParam("@Discount", DiscountTextBox.Text)
        DB.AddParam("@DiscountDescr", DiscountDescrTextBox.Text)
        DB.AddParam("@StartDate", DiscountStartDate.Value)
        DB.AddParam("@EndDate", DiscountEndDate.Value)

        DB.ExecuteQuery("INSERT INTO Discount(discount, description, start_date, end_date) VALUES(?,?,?,?)")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        MessageBox.Show("Discount " + DiscountTextBox.Text + " is added successfully.")

        SearchDiscount() 'Refreshing the data grid view
        EnableDiscountFieldsforEdit(False)

    End Sub

    Private Sub UpdateDiscount()
        If ValidateDiscount() = False Then
            Exit Sub
        End If

        DB.AddParam("@DiscountID", DiscountIDTextBox.Text)
        DB.AddParam("@Discount", DiscountTextBox.Text)
        DB.AddParam("@DiscountDescr", DiscountDescrTextBox.Text)
        DB.AddParam("@StartDate", DiscountStartDate.Value)
        DB.AddParam("@EndDate", DiscountEndDate.Value)

        DB.ExecuteQuery("UPDATE discount set discount=?, description=?, start_date=?, end_date=? WHERE discount_id=? ")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        MessageBox.Show("Discount " + DiscountTextBox.Text + " is updated successfully.")

        SearchDiscount() 'Refreshing the data grid view
        EnableDiscountFieldsforEdit(False)

    End Sub

    Private Function CheckDuplicateDiscount() As Boolean
        DB.AddParam("@Discount", DiscountTextBox.Text)

        DB.ExecuteQuery("select count(discount_id) FROM discount WHERE discount =?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Return True
        End If

        Dim discount_count As Integer
        discount_count = DB.DBDataTable(0)(0)

        If discount_count > 0 Then
            Return True
        End If

        Return False

    End Function
    Private Function ValidateDiscount() As Boolean

        ' Discount Validation
        If String.IsNullOrWhiteSpace(DiscountTextBox.Text) Then
            MessageBox.Show("Discount can't be empty.")
            DiscountTextBox.SelectAll()
            DiscountTextBox.Focus()
            Return False
        End If

        'Discount Uniqueness Check
        If String.IsNullOrWhiteSpace(DiscountIDTextBox.Text) Then
            If CheckDuplicateDiscount() Then
                MessageBox.Show("Discount " + DiscountTextBox.Text + " already exists.")
                DiscountTextBox.SelectAll()
                DiscountTextBox.Focus()
                Return False
            End If
        End If

        'Discount Description Validation
        If String.IsNullOrWhiteSpace(DiscountDescrTextBox.Text) Then
            MessageBox.Show("Discount Description can't be empty.")
            DiscountDescrTextBox.SelectAll()
            DiscountDescrTextBox.Focus()
            Return False
        End If

        'Discount Start Date Validation
        If String.IsNullOrEmpty(DiscountStartDate.Value) Then
            MessageBox.Show("Discount Start Date can't be empty.")
            DiscountStartDate.Focus()
            Return False
        End If

        'Discount End Date Validation
        If String.IsNullOrEmpty(DiscountEndDate.Value) Then
            MessageBox.Show("Discount End Date can't be empty.")
            DiscountEndDate.Focus()
            Return False
        End If

        'Discount Start and End Date Validation
        If DiscountStartDate.Value > DiscountEndDate.Value Then
            MessageBox.Show("Discount Start Date should be less than or equal to End Date.")
            DiscountStartDate.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub ButtonDeleteDiscount_Click(sender As Object, e As EventArgs) Handles ButtonDeleteDiscount.Click
        Dim aDialogResult As DialogResult
        Dim afterStatus = If((DiscountActiveCheckbox.Checked), "disable", "enable")
        Dim afterStatus2 = If((DiscountActiveCheckbox.Checked), "disabled", "enabled")

        aDialogResult = MessageBox.Show("Do you want to " & afterStatus & " discount " & DiscountTextBox.Text & "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If aDialogResult = vbNo Then
            Exit Sub
        Else

            DB.AddParam("@IsActive", Not DiscountActiveCheckbox.Checked)
            DB.AddParam("@Discount_id", DiscountIDTextBox.Text)

            DB.ExecuteQuery("UPDATE discount set is_active=? WHERE discount_id = ?")

            If DB.DBException <> String.Empty Then
                MessageBox.Show(DB.DBException)
                Exit Sub
            End If

            MessageBox.Show("Discount " & DiscountTextBox.Text & " has been " & afterStatus2 & ".")

            'Refresh discount details
            SearchDiscount()

            'Fill discount details after update
            UpdateDiscountDetails(ActiveRowIndex)

        End If
    End Sub

    Private Sub DiscountDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DiscountDataGridView.CellClick
        If e.RowIndex < 0 Or e.RowIndex = DiscountDataGridView.Rows.Count - 1 Then
            ClearDiscountDetails()
            Exit Sub
        Else

            ButtonEditDiscount.Enabled = True
            ButtonDeleteDiscount.Enabled = True
            ButtonCancelDiscount.Enabled = True

            ActiveRowIndex = e.RowIndex
            UpdateDiscountDetails(ActiveRowIndex)
        End If

    End Sub

    Private Sub UpdateDiscountDetails(RowIndex)
        DiscountIDTextBox.Text = DiscountDataGridView.Rows(RowIndex).Cells(0).Value
        DiscountTextBox.Text = DiscountDataGridView.Rows(RowIndex).Cells(1).Value
        DiscountDescrTextBox.Text = DiscountDataGridView.Rows(RowIndex).Cells(2).Value
        DiscountStartDate.Value = DiscountDataGridView.Rows(RowIndex).Cells(3).Value
        DiscountEndDate.Value = DiscountDataGridView.Rows(RowIndex).Cells(4).Value
        DiscountActiveCheckbox.Checked = DiscountDataGridView.Rows(RowIndex).Cells(5).Value
        DiscountCreatedOn.Value = DiscountDataGridView.Rows(RowIndex).Cells(6).Value
        DiscountUpdatedOn.Value = DiscountDataGridView.Rows(RowIndex).Cells(7).Value

        ButtonDeleteDiscount.Text = If((DiscountActiveCheckbox.Checked), "Disable", "Enable")
    End Sub

    Private Sub ButtonDiscountHome_Click(sender As Object, e As EventArgs) Handles ButtonDiscountHome.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelLogout.Click
        Me.Close()
        LoginForm.Show()
        LoginForm.Focus()
    End Sub
End Class